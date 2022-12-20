using Unity.Entities;

public struct WorldResource : IComponentData
{
    public Entity Prefabs;
}

[UnityEngine.DisallowMultipleComponent]
public class WorldResourceAuthoring : UnityEngine.MonoBehaviour
{
    public UnityEngine.GameObject Prefabs;

    public class WorldResourceAuthoringBaker : Baker<WorldResourceAuthoring>
    {
        public override void Bake(WorldResourceAuthoring authoring)
        {
            AddComponent(new WorldResource { Prefabs = GetEntity(authoring.Prefabs) });
        }
    }
}