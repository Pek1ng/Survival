﻿using JetBrains.Annotations;
using Survival.Controls;
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

            foreach ((var targetRW,var inputData,var entity) in SystemAPI.Query<RefRW<Target>,InputData>().WithEntityAccess())
            {
                if (inputData.MouseClick)
                {
                    state.EntityManager.SetComponentEnabled<HaveTartgetTag>(entity,true);
                    targetRW.ValueRW.Position = inputData.Hit.Position;
                    targetRW.ValueRW.Entity=inputData.Hit.Entity;
                }
            }
        }
    }

    [BurstCompile]
    public readonly partial struct TargetPositionAspect : IAspect
    {
        private readonly EnabledRefRW<HaveTartgetTag> _haveTartgetTag;
        private readonly RefRW<Target> _targetPositionRW;
        private readonly TransformAspect _transformAspect;
        private readonly RefRO<MovementSpeed> _movementSpeedRO;
        private readonly RefRW<PhysicsVelocity> _physicsVelocityRW;

        [BurstCompile]
        public void Move(float deltaTime)
        {
            var distance = math.distance(_targetPositionRW.ValueRO.Position.xz, _transformAspect.WorldPosition.xz);

            if (distance < 0.1f)
            {
                _haveTartgetTag.ValueRW = false;
            }
            else
            {
                var direction = math.normalize(_targetPositionRW.ValueRO.Position.xz - _transformAspect.LocalPosition.xz);
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
