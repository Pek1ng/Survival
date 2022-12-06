using Survival.Controls;
using Unity.Entities;
using UnityEngine;

namespace Survival.Entities.Authoring
{
    public struct PlayerTag : IComponentData { }

    public class PlayerAuthoring : MonoBehaviour
    {
        public float MovementSpeed;
    }

    public class PlayerBaker : Baker<PlayerAuthoring>
    {
        public override void Bake(PlayerAuthoring authoring)
        {
            AddComponent<PlayerTag>();
            AddComponent<InputData>();
            AddComponent(new MovementSpeed { Value = authoring.MovementSpeed });

            AddComponent<Target>();
            AddComponent<HaveTartgetTag>();
            SetComponentEnabled<HaveTartgetTag>(GetEntity(),false);
        }
    }
}