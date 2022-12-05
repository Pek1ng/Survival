using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;

namespace Survival.Controls
{
    [BurstCompile]
    public struct InputData : IComponentData
    {
        public RaycastHit Hit;

        public float2 Move;
    }
}
