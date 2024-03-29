using Survival.GamePlay;
using Unity.Entities;
using UnityEngine;

namespace Survival.Netcode
{
    public struct Player : IComponentData { }

    public partial class PlayerAuthoring : MonoBehaviour
    {
        private class PlayerAuthoringBaker : Baker<PlayerAuthoring>
        {
            public override void Bake(PlayerAuthoring authoring)
            {
                Entity e = GetEntity(authoring, TransformUsageFlags.None);
                AddComponent<Player>(e);
                AddComponent<InputData>(e);
            }
        }
    }
}
