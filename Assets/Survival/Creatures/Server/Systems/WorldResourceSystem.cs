using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using Survival.Creatures;
using Survival.Shared;

[BurstCompile]
[WorldSystemFilter(WorldSystemFilterFlags.ServerSimulation)]
public partial struct WorldResourceSystem : ISystem
{
    private EntityQuery _stoneQuery;

    [BurstCompile]
    public void OnCreate(ref SystemState state)
    {
        //用于查询当前Stone的数量
        EntityQueryBuilder queryBuilder = new EntityQueryBuilder(Allocator.Temp);
        queryBuilder.WithAll<StoneTag>();  
        _stoneQuery = state.EntityManager.CreateEntityQuery(queryBuilder);

        state.RequireForUpdate<WorldResourceSingleton>();  //防止拿不到单例
        state.RequireForUpdate<RandomSingleton>();
    }

    [BurstCompile]
    public void OnDestroy(ref SystemState state)
    {
        _stoneQuery.Dispose();
    }

    [BurstCompile]
    public void OnUpdate(ref SystemState state)
    {
        var stoneArray = _stoneQuery.ToComponentDataArray<StoneTag>(Allocator.Temp);

        if (stoneArray.Length < 10)
        {
            var prefab = SystemAPI.GetSingleton<WorldResourceSingleton>().Prefab;
            var commandBuffer = SystemAPI.GetSingleton<BeginSimulationEntityCommandBufferSystem.Singleton>().CreateCommandBuffer(state.WorldUnmanaged);
            var randomRW = SystemAPI.GetSingletonRW<RandomSingleton>();

            var entity = commandBuffer.Instantiate(prefab);
            var position = float3.zero;
            position.y = -0.75f;
            position.xz = randomRW.ValueRW.Random.NextFloat2(-50f, 50f);

            commandBuffer.SetComponent(entity, new LocalTransform { Position = position, Rotation = quaternion.identity, Scale = 1f });
        }
    }
}
