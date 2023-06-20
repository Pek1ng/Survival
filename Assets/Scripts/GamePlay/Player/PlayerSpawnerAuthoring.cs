using Unity.Entities;
using UnityEngine;

public struct PlayerSpawner : IComponentData
{
    public Entity Prefab;
}

[DisallowMultipleComponent]
public partial class PlayerSpawnerAuthoring : MonoBehaviour
{
    public GameObject PlayerPrefab;

    private class PlayerSpawnerAuthoringBaker : Baker<PlayerSpawnerAuthoring>
    {
        public override void Bake(PlayerSpawnerAuthoring authoring)
        {
            Entity e = GetEntity(TransformUsageFlags.None);
            PlayerSpawner spawner = default;
            spawner.Prefab = GetEntity(authoring.PlayerPrefab, TransformUsageFlags.Dynamic);
            AddComponent(e, spawner);
        }
    }
}
