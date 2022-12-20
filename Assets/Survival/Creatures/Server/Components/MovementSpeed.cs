using Unity.Entities;
using Unity.NetCode;

namespace Survival.Creatures
{
    [GhostComponent(PrefabType = GhostPrefabType.Server)]
    public struct MovementSpeed : IComponentData
    {
        public float Value;
    }
}
