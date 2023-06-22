using Unity.Entities;
using Unity.Mathematics;
using Unity.NetCode;
using Unity.Transforms;
using Unity.Burst;

namespace Survival.GamePlay
{
    [UpdateInGroup(typeof(PredictedSimulationSystemGroup))]
    [BurstCompile]
    public partial struct PlayerMovementSystem : ISystem
    {
        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            var speed = SystemAPI.Time.DeltaTime * 4;
            foreach (var (input, trans) in SystemAPI.Query<RefRO<InputData>, RefRW<LocalTransform>>().WithAll<Simulate>())
            {
                var moveInput = math.normalizesafe(input.ValueRO.Move) * speed;
                trans.ValueRW.Position += new float3(moveInput.x, 0, moveInput.y);

                float3 target = trans.ValueRW.Position + new float3(input.ValueRO.Look.x, 0, input.ValueRO.Look.y);
                trans.ValueRW.Rotation = TransformHelpers.LookAtRotation(trans.ValueRW.Position, target, math.up());
            }
        }
    }
}