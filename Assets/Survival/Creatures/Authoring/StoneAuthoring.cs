using Unity.Entities;
using UnityEngine;

namespace Survival.Creatures
{
    public struct StoneTag : IComponentData { }

    [DisallowMultipleComponent]
    public class StoneAuthoring : MonoBehaviour
    {
        public class StoneBaker : Baker<StoneAuthoring>
        {
            public override void Bake(StoneAuthoring authoring)
            {
                AddComponent<StoneTag>();
            }
        }
    }
}
