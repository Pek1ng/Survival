using Unity.Entities;

public struct WorldResourceSingleton : IComponentData
{
    public Entity Prefab;
}

[UnityEngine.DisallowMultipleComponent]
public class WorldResourceAuthoring : UnityEngine.MonoBehaviour
{
    public UnityEngine.GameObject Prefab;

    public class WorldResourceAuthoringBaker : Baker<WorldResourceAuthoring>
    {
        public override void Bake(WorldResourceAuthoring authoring)
        {
            AddComponent(new WorldResourceSingleton { Prefab = GetEntity(authoring.Prefab) });
        }
    }
}