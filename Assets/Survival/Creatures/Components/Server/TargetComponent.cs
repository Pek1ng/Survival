using Unity.Entities;
using Unity.Mathematics;
using Unity.NetCode;

namespace Survival.Creatures
{
    [GhostComponent(PrefabType =GhostPrefabType.Server)] //仅在服务器上有用的组件
    public struct TartgetTag : IComponentData, IEnableableComponent { }

    [GhostComponent(PrefabType = GhostPrefabType.Server)]
    public struct Target : IComponentData
    {

        public float3 Position;

        public Entity Entity;
    }
}
