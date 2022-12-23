using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;

namespace Survival.Creatures
{
    [BurstCompile]
    [WorldSystemFilter(WorldSystemFilterFlags.ServerSimulation)]
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
        private readonly EnabledRefRW<TartgetTag> _TartgetTag;
        private readonly RefRW<Target> _targetPositionRW;
        private readonly TransformAspect _transformAspect;
        private readonly RefRO<MovementSpeed> _movementSpeedRO;
        private readonly RefRW<PhysicsVelocity> _physicsVelocityRW;

        [BurstCompile]
        public void Move(float deltaTime)
        {
            var direction = _targetPositionRW.ValueRO.Position.xz - _transformAspect.LocalPosition.xz;

            //var SquareOfDistance

            var distancesq = math.distancesq(_targetPositionRW.ValueRO.Position.xz, _transformAspect.WorldPosition.xz);

            if (distancesq < 0.01f)
            {
                _TartgetTag.ValueRW = false;
            }
            else
            {
                _physicsVelocityRW.ValueRW.Linear.xz += math.normalize(direction) * deltaTime * _movementSpeedRO.ValueRO.Value;
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
