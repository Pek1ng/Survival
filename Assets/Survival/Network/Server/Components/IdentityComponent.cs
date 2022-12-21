using Unity.Entities;
using Unity.NetCode;

namespace Survival.Nework
{
    [GhostComponent(PrefabType = GhostPrefabType.Server)]
    public struct IdentityComponent : IComponentData
    {

    }
}

