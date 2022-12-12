using Unity.Entities;
using Unity.Mathematics;
using Unity.NetCode;

namespace Survival.Controller
{
    [GhostComponent(PrefabType = GhostPrefabType.AllPredicted)]
    public struct InputData : IInputComponentData
    {
        [GhostField(Quantization = 100)]
        public float3 RayOrigin;

        [GhostField(Quantization = 100)]
        public float3 RayEnd;

        [GhostField(Quantization = 100)]
        public float3 HitPosition;

        [GhostField(Quantization = 100)]
        public float2 Move;

        [GhostField]
        public bool MouseClick;
    }
}
