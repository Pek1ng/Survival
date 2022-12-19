﻿using Unity.Entities;
using Unity.Burst;
using Unity.Collections;
using Unity.NetCode;
using Unity.Mathematics;
using Unity.Transforms;
using System;
using Random = Unity.Mathematics.Random;

namespace Survival.Nework
{
    public struct GoInGameRequest : IRpcCommand
    {
    }

    [BurstCompile]
    [WorldSystemFilter(WorldSystemFilterFlags.ClientSimulation | WorldSystemFilterFlags.ThinClientSimulation)]
    public partial struct GoInGameClientSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            state.RequireForUpdate<CubeSpawner>();
            var builder = new EntityQueryBuilder(Allocator.Temp)
                .WithAll<NetworkIdComponent>()
                .WithNone<NetworkStreamInGame>();
            state.RequireForUpdate(state.GetEntityQuery(builder));
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            var commandBuffer = new EntityCommandBuffer(Allocator.Temp);
            foreach (var (id, entity) in SystemAPI.Query<RefRO<NetworkIdComponent>>().WithEntityAccess().WithNone<NetworkStreamInGame>())
            {
                commandBuffer.AddComponent<NetworkStreamInGame>(entity);
                var req = commandBuffer.CreateEntity();
                commandBuffer.AddComponent<GoInGameRequest>(req);
                commandBuffer.AddComponent(req, new SendRpcCommandRequestComponent { TargetConnection = entity });
            }
            commandBuffer.Playback(state.EntityManager);
        }
    }

    [BurstCompile]
    // When server receives go in game request, go in game and delete request
    [WorldSystemFilter(WorldSystemFilterFlags.ServerSimulation)]
    public partial struct GoInGameServerSystem : ISystem
    {
        private ComponentLookup<NetworkIdComponent> networkIdFromEntity;

        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            state.RequireForUpdate<CubeSpawner>();
            var builder = new EntityQueryBuilder(Allocator.Temp)
                .WithAll<GoInGameRequest>()
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

            foreach (var (reqSrc, reqEntity) in SystemAPI.Query<RefRO<ReceiveRpcCommandRequestComponent>>().WithAll<GoInGameRequest>().WithEntityAccess())
            {
                commandBuffer.AddComponent<NetworkStreamInGame>(reqSrc.ValueRO.SourceConnection);
                var networkIdComponent = networkIdFromEntity[reqSrc.ValueRO.SourceConnection];

                UnityEngine.Debug.Log($"'{worldName}' setting connection '{networkIdComponent.Value}' to in game");
                UnityEngine.Debug.Log($"'{worldName}' setting connection '{networkIdComponent.Value}' to in game, spawning a Ghost '{prefabName}' for them!");


                var player = commandBuffer.Instantiate(prefab);


                Random random = new Random(1222);
                commandBuffer.SetComponent(player, new LocalTransform { Position = new float3(random.NextFloat(0f, 5f), 0f, random.NextFloat(0, 5f)), Rotation = quaternion.identity, Scale = 1f });
                commandBuffer.SetComponent(player, new GhostOwnerComponent { NetworkId = networkIdComponent.Value });

                // Add the player to the linked entity group so it is destroyed automatically on disconnect
                commandBuffer.AppendToBuffer(reqSrc.ValueRO.SourceConnection, new LinkedEntityGroup { Value = player });
                commandBuffer.DestroyEntity(reqEntity);
            }
            commandBuffer.Playback(state.EntityManager);
        }
    }

}
