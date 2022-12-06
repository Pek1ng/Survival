using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;

namespace Survival.Entities
{
    [BurstCompile]
    public partial struct TargetSystem : ISystem
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
        private readonly RefRW<Target> _targetPositionRW;
      //  private readonly TargetPositionEnableAspect targetPositionEnableAspect;
        private readonly TransformAspect _transformAspect;
        private readonly RefRO<MovementSpeed> _movementSpeedRO;
        private readonly RefRW<PhysicsVelocity> _physicsVelocityRW;

        [BurstCompile]
        public void Move(float deltaTime)
        {

            var distance = math.distance(_targetPositionRW.ValueRO.Position.xz, _transformAspect.WorldPosition.xz);

            if (distance < 0.1f)
            {
                //targetPositionEnableAspect.Enable.ValueRW= false;
            }
            else
            {
                var direction = math.normalize(_targetPositionRW.ValueRO.Position.xz - _transformAspect.LocalPosition.xz);
                _physicsVelocityRW.ValueRW.Linear.xz += direction * deltaTime * _movementSpeedRO.ValueRO.Value;
            }
        }
    }


    public readonly partial struct TargetPositionEnableAspect : IAspect
    {
       public readonly EnabledRefRW<Target> Enable;
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
