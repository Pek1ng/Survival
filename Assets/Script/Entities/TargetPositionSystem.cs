using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

namespace Taxa.Entities
{
    [BurstCompile]
    public struct TargetPosition : IComponentData, IEnableableComponent
    {
        public float3 Value;
    }

    [BurstCompile]
    public partial struct TargetPositionSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            foreach (var targetPosition in SystemAPI.Query<EnabledRefRW<TargetPosition>>())
            {
                targetPosition.ValueRW = false;
            }
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {

        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            var deltaTime = SystemAPI.Time.DeltaTime;

            foreach ((var targetPositionRW, var enableRW, var transformAspect) in SystemAPI.Query<RefRW<TargetPosition>, EnabledRefRW<TargetPosition>, TransformAspect>())
            {
                var distance = math.distance(targetPositionRW.ValueRO.Value.xz, transformAspect.Position.xz);

                if (distance < float.Epsilon)
                {
                    enableRW.ValueRW = false;
                }
                else
                {
                    transformAspect.TranslateWorld(math.normalize(targetPositionRW.ValueRO.Value - transformAspect.Position) * deltaTime);
                }
            }
        }
    }
}
