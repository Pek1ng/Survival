using Unity.Burst;
using Unity.Mathematics;
using Unity.NetCode;
using Unity.Physics;

namespace Survival.Controller
{
    [BurstCompile]
    [GhostComponent(PrefabType = GhostPrefabType.AllPredicted)]
    public struct InputData :  IInputComponentData
    {
        public UnityEngine.Ray Ray;

        public RaycastHit Hit;

        public float2 Move;

        public bool MouseClick;
    }
}
