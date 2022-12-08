using Survival.Creatures;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Physics.Authoring;
using Unity.Transforms;

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
            //var physicsWorldSingleton = SystemAPI.GetSingleton<PhysicsWorldSingleton>();
            var deltaTime = SystemAPI.Time.DeltaTime;

            var jobHandle = new PlayerControllerJob
            {
                DeltaTime = deltaTime,
                //PhysicsWorldSingleton = physicsWorldSingleton,
                //CollisionFilter = _collisionFilter,
            }.ScheduleParallel(state.Dependency);

            jobHandle.Complete();

            //foreach ((var targetRW, var inputData, var entity) in SystemAPI.Query<RefRW<Target>, InputData>().WithEntityAccess())
            //{
            //    if (inputData.Move.x != 0 || inputData.Move.y != 0)
            //    {
            //        state.EntityManager.SetComponentEnabled<HaveTartgetTag>(entity, false);
            //    }
            //    else
            //    {
            //        if (inputData.MouseClick)
            //        {
            //            state.EntityManager.SetComponentEnabled<HaveTartgetTag>(entity, true);
            //            targetRW.ValueRW.Position = inputData.Hit.Position;
            //            targetRW.ValueRW.Entity = inputData.Hit.Entity;
            //        }
            //    }
            //}
        }
    }

    [BurstCompile]
    public readonly partial struct PlayerControllerAspect : IAspect
    {
        private readonly TransformAspect _transformAspect;
        private readonly RefRW<PhysicsMass> _physicsMass;
        private readonly RefRW<PhysicsVelocity> _physicsVelocity;
        private readonly RefRW<InputData> _inputData;
        private readonly RefRO<MovementSpeed> _movementSpeed;

        [BurstCompile]
        public void Move(float deltaTime)
        {
            _physicsMass.ValueRW.InverseInertia.x = 0f; //锁定轴防止人物旋转
            _physicsMass.ValueRW.InverseInertia.z = 0f;

            _physicsVelocity.ValueRW.Linear.xz += _inputData.ValueRO.Move * deltaTime * _movementSpeed.ValueRO.Value; //人物移动
        }

        public void Look(CollisionFilter collisionFilter, PhysicsWorldSingleton physicsWorldRW)
        {
            var raycastInput = new RaycastInput
            {
                Start = _inputData.ValueRO.Ray.origin,
                End = _inputData.ValueRO.Ray.GetPoint(100f),
                Filter = collisionFilter
            };

            physicsWorldRW.CastRay(raycastInput, out Unity.Physics.RaycastHit hit);

            _inputData.ValueRW.Hit = hit;

            float3 target = hit.Position;

            target.y = 0;

            _transformAspect.LookAt(target);
        }
    }

    [BurstCompile]
    public partial struct PlayerControllerJob : IJobEntity
    {
        public float DeltaTime;
        //public CollisionFilter CollisionFilter;
        //[ReadOnly] public PhysicsWorldSingleton PhysicsWorldSingleton;

        [BurstCompile]
        public void Execute(PlayerControllerAspect aspect)
        {
            aspect.Move(DeltaTime);
            //aspect.Look(CollisionFilter, PhysicsWorldSingleton);
        }
    }
}