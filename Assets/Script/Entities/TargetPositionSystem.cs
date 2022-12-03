using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;

namespace Taxa.Entities
{
    [BurstCompile]
    public struct TargetPosition : IComponentData
    {
        public bool Enable;

        public float3 Value;
    }

    [BurstCompile]
    public partial struct TargetPositionSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {

        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {

        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            float deltaTime = SystemAPI.Time.DeltaTime;

            var jobHandle = new TargetPositionJob
            {
                DeltaTime = deltaTime
            }.ScheduleParallel(state.Dependency);

            jobHandle.Complete();
        }
    }

    [BurstCompile]
    public readonly partial struct TargetPositionAspect : IAspect
    {
        private readonly RefRW<TargetPosition> _targetPositionRW;
        private readonly TransformAspect _transformAspect;
        private readonly RefRO<MovementSpeed> _movementSpeedRO;
        private readonly RefRW<PhysicsVelocity> _physicsVelocityRW;

        [BurstCompile]
        public void Move(float deltaTime)
        {
            if (_targetPositionRW.ValueRW.Enable == false)
            {
                return;
            }

            var distance = math.distance(_targetPositionRW.ValueRO.Value.xz, _transformAspect.WorldPosition.xz);

            if (distance < 0.1f)
            {
                _targetPositionRW.ValueRW.Enable = false;
            }
            else
            {
                var direction = math.normalize(_targetPositionRW.ValueRO.Value.xz - _transformAspect.LocalPosition.xz);
                _physicsVelocityRW.ValueRW.Linear.xz += direction * deltaTime * _movementSpeedRO.ValueRO.Value;
            }
        }
    }


    [BurstCompile]
    public partial struct TargetPositionJob : IJobEntity
    {
        public float DeltaTime;

        public void Execute(TargetPositionAspect targetPositionAspect)
        {
            targetPositionAspect.Move(DeltaTime);
        }
    }
}
