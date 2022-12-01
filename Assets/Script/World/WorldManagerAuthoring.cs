using Entities.Inputs;
using Unity.Entities;
using UnityEngine;

namespace Taxa.World
{
    public class WorldManagerAuthoring : MonoBehaviour
    {
        public class WorldManagerBaker : Baker<WorldManagerAuthoring>
        {
            public override void Bake(WorldManagerAuthoring authoring)
            {
                AddComponent<MouseRaySingleton>();
            }
        }
    }
}
