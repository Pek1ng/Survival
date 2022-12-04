using Unity.Entities;
using UnityEngine;

namespace Survival.Worlds
{
    public class WorldManagerAuthoring : MonoBehaviour
    {
        public class WorldManagerBaker : Baker<WorldManagerAuthoring>
        {
            public override void Bake(WorldManagerAuthoring authoring)
            {

            }
        }
    }
}
