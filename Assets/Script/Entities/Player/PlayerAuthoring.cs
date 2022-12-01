using Unity.Entities;
using UnityEngine;

namespace Taxa.Entities.Player
{
    public struct PlayerTag : IComponentData { }

    public class PlayerAuthoring : MonoBehaviour
    {
        public float MovementSpeed;

        public class PlayerBaker : Baker<PlayerAuthoring>
        {
            public override void Bake(PlayerAuthoring authoring)
            {
                AddComponent<PlayerTag>();
                AddComponent(new MovementSpeed { Value = authoring.MovementSpeed });
                AddComponent<TargetPosition>();
            }
        }
    }
}