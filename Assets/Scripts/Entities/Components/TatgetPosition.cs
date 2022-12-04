using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;

namespace Survival.Entities
{
    [BurstCompile]
    public struct TargetPosition : IComponentData, IEnableableComponent
    {
        public float3 Value;
    }
}
