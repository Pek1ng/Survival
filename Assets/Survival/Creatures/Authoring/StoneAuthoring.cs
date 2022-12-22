using Unity.Entities;
using UnityEngine;

namespace Survival.Creatures
{
    public struct StoneTag : IComponentData { }

    [DisallowMultipleComponent]
    public class StoneAuthoring : MonoBehaviour
    {
        public class StoneAuthoringBaker : Baker<StoneAuthoring>
        {
            public override void Bake(StoneAuthoring authoring)
            {
                AddComponent<StoneTag>();
            }
        }
    }
}
