using Unity.Entities;
using Unity.Burst;
using Unity.Collections;
using Unity.NetCode;
using Unity.Mathematics;
using Unity.Transforms;

namespace Survival.Nework
{
    public struct ConnectGameRequest : IRpcCommand
    {
    }

    [BurstCompile]
    // When server receives go in game request, go in game and delete request
    [WorldSystemFilter(WorldSystemFilterFlags.ServerSimulation)]
    public partial struct ConnectGameServerSystem : ISystem
    {
        private ComponentLookup<NetworkIdComponent> networkIdFromEntity;

        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            state.RequireForUpdate<CubeSpawner>();
            var builder = new EntityQueryBuilder(Allocator.Temp)
                .WithAll<ConnectGameRequest>()
                .WithAll<ReceiveRpcCommandRequestComponent>();
            state.RequireForUpdate(state.GetEntityQuery(builder));
            networkIdFromEntity = state.GetComponentLookup<NetworkIdComponent>(true);
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            var prefab = SystemAPI.GetSingleton<CubeSpawner>().Cube;

            state.EntityManager.GetName(prefab, out var prefabName);
            var worldName = new FixedString32Bytes(state.WorldUnmanaged.Name);

            var commandBuffer = new EntityCommandBuffer(Allocator.Temp);
            networkIdFromEntity.Update(ref state);

            foreach (var (reqSrc, reqEntity) in SystemAPI.Query<RefRO<ReceiveRpcCommandRequestComponent>>().WithAll<ConnectGameRequest>().WithEntityAccess())
            {
                commandBuffer.AddComponent<NetworkStreamInGame>(reqSrc.ValueRO.SourceConnection);
                var networkIdComponent = networkIdFromEntity[reqSrc.ValueRO.SourceConnection];

                UnityEngine.Debug.Log($"'{worldName}' setting connection '{networkIdComponent.Value}' to in game");
                UnityEngine.Debug.Log($"'{worldName}' setting connection '{networkIdComponent.Value}' to in game, spawning a Ghost '{prefabName}' for them!");

                var player = commandBuffer.Instantiate(prefab);
                commandBuffer.SetComponent(player, new GhostOwnerComponent { NetworkId = networkIdComponent.Value });

                // 将玩家添加到链接的实体组中，这样在断开连接时就会自动销毁。
                commandBuffer.AppendToBuffer(reqSrc.ValueRO.SourceConnection, new LinkedEntityGroup { Value = player });
                commandBuffer.DestroyEntity(reqEntity);
            }
            commandBuffer.Playback(state.EntityManager);
        }
    }

}
