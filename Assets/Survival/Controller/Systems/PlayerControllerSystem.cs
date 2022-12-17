using Survival.Creatures;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Physics;
using Unity.Physics.Authoring;
using Unity.Transforms;
using UnityEngine;

namespace Survival.Controller
{
    [BurstCompile]
    [WorldSystemFilter(WorldSystemFilterFlags.ServerSimulation)]
    public partial struct PlayerControllerSystem : ISystem
    {
        private CollisionFilter _collisionFilter;

        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            _collisionFilter = new CollisionFilter //射线检测过滤
            {
                BelongsTo = new PhysicsCategoryTags
                {
                    Category00 = true
                }.Value,

                CollidesWith = PhysicsCategoryTags.Everything.Value
            };
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {

        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            var deltaTime = SystemAPI.Time.DeltaTime;
            var physicsWorldSingleton = SystemAPI.GetSingleton<PhysicsWorldSingleton>();

            var jobHandle = new PlayerControllerJob
            {
                DeltaTime = deltaTime,
                PhysicsWorldSingleton = physicsWorldSingleton,
                CollisionFilter = _collisionFilter
            }.ScheduleParallel(state.Dependency);

            jobHandle.Complete();

            foreach ((var target, var inputData, var entity) in SystemAPI.Query<RefRW<Target>, InputData>().WithEntityAccess())
            {
                if (inputData.Move.x != 0 || inputData.Move.y != 0)
                {
                    state.EntityManager.SetComponentEnabled<TartgetTag>(entity, false);
                }
                else
                {
                    if (inputData.MouseClick)
                    {
                        state.EntityManager.SetComponentEnabled<TartgetTag>(entity, true);
                        target.ValueRW.Position = inputData.HitPosition;
                    }
                }
            }
        }
    }

    [BurstCompile]
    public readonly partial struct PlayerControllerAspect : IAspect
    {
        private readonly TransformAspect _transformAspect;
        private readonly RefRW<PhysicsVelocity> _physicsVelocity;
        private readonly RefRW<InputData> _inputData;
        private readonly RefRO<MovementSpeed> _movementSpeed;
        private readonly RefRW<Target> _target;

        [BurstCompile]
        public void Move(float deltaTime)
        {
            _physicsVelocity.ValueRW.Linear.xz += _inputData.ValueRO.Move * deltaTime * _movementSpeed.ValueRO.Value; //人物移动
        }

        [BurstCompile]
        public void Look(CollisionFilter collisionFilter, PhysicsWorldSingleton physicsWorldSingleton)
        {
            var raycastInput = new RaycastInput
            {
                Start = _inputData.ValueRO.RayOrigin,
                End = _inputData.ValueRO.RayEnd,
                Filter = collisionFilter
            };

            physicsWorldSingleton.CastRay(raycastInput, out Unity.Physics.RaycastHit hit);
            var target = hit.Position;

            _inputData.ValueRW.HitPosition = target;
            _target.ValueRW.Entity = hit.Entity;

            target.y = 0;

            _transformAspect.LookAt(target);
        }
    }

    [BurstCompile]
    public partial struct PlayerControllerJob : IJobEntity
    {
        public float DeltaTime;
        public CollisionFilter CollisionFilter;
        [ReadOnly] public PhysicsWorldSingleton PhysicsWorldSingleton;

        [BurstCompile]
        public void Execute(PlayerControllerAspect aspect)
        {
            aspect.Move(DeltaTime);
            aspect.Look(CollisionFilter, PhysicsWorldSingleton);
        }
    }
}