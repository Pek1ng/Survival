using Unity.Entities;
using Unity.Mathematics;

namespace Survival.Creatures
{
    public struct HaveTartgetTag : IComponentData, IEnableableComponent { }

    public struct Target : IComponentData
    {

        public float3 Position;

        public Entity Entity;
    }
}