using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Survival.Controls
{
    [BurstCompile]
    public struct InputData : IComponentData
    {
        public Ray Ray;

        public float2 Move;

        public float3 Look;
    }
}
