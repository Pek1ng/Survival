using Survival.Entities;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Physics.Authoring;
using Unity.Transforms;

namespace Survival.Controls
{
    [BurstCompile]
    [UpdateAfter(typeof(InputListeningSystem))]
    public partial struct PlayerControllerSystem : ISystem
    {
        private CollisionFilter _collisionFilter;

        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            _collisionFilter = new CollisionFilter //射线监测过滤
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
            var physicsWorldSingleton = SystemAPI.GetSingleton<PhysicsWorldSingleton>();
            var deltaTime = SystemAPI.Time.DeltaTime;

            var jobHandle = new PlayerControllerJob
            {
                DeltaTime = deltaTime,
                PhysicsWorldSingleton = physicsWorldSingleton,
                CollisionFilter = _collisionFilter,
            }.ScheduleParallel(state.Dependency);

            jobHandle.Complete();
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
        private readonly TargetPositionEnableAspect _targetPositionEnableAspect;


        [BurstCompile]
        public void Move(float deltaTime)
        {
            _physicsMass.ValueRW.InverseInertia.x = 0f; //锁定轴防止人物旋转
            _physicsMass.ValueRW.InverseInertia.z = 0f;

            _physicsVelocity.ValueRW.Linear.xz += _inputData.ValueRO.Move * deltaTime * _movementSpeed.ValueRO.Value; //人物移动

            if (_inputData.ValueRO.Move.x != 0 || _inputData.ValueRO.Move.y != 0)
            {
                _targetPositionEnableAspect.Enable.ValueRW = false;
            }
        }

        public void Look(CollisionFilter collisionFilter, PhysicsWorldSingleton physicsWorldRW)
        {
            var raycastInput = new RaycastInput
            {
                Start = _inputData.ValueRO.Ray.origin,
                End = _inputData.ValueRO.Ray.GetPoint(100f),
                Filter = collisionFilter
            };

            physicsWorldRW.CastRay(raycastInput, out RaycastHit hit);

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