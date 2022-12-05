using Unity.Entities;
using Unity.Mathematics;

namespace Survival.Entities
{
    public struct Target : IComponentData, IEnableableComponent
    {

        public float3 Position;

        public Entity Entity;
    }
}
