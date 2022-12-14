using Survival.Creatures;
using Unity.Entities;
using UnityEngine;

namespace Survival.Controller
{
    public struct PlayerTag : IComponentData { }

    [DisallowMultipleComponent]
    public class PlayerAuthoring : MonoBehaviour
    {
        public float MovementSpeed;

        private class PlayerBaker : Baker<PlayerAuthoring>
        {
            public override void Bake(PlayerAuthoring authoring)
            {
                AddComponent<PlayerTag>();
                AddComponent<InputData>();
                AddComponent(new MovementSpeed { Value = authoring.MovementSpeed });

                AddComponent<Target>();
                AddComponent<TartgetTag>();
                SetComponentEnabled<TartgetTag>(GetEntity(), false);
            }
        }
    }
}