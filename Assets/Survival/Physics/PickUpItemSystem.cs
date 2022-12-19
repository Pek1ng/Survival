using Survival.Controller;
using Survival.Creatures;
using Survival.Datas.Inventory;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Physics;
using UnityEngine;

namespace Survival.Physics
{
    [BurstCompile]
    public partial struct PickUpItemSystem : ISystem
    {
        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {

        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {

        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            var simulationSingleton = SystemAPI.GetSingleton<SimulationSingleton>();
            var ecb = SystemAPI.GetSingleton<BeginSimulationEntityCommandBufferSystem.Singleton>().CreateCommandBuffer(state.WorldUnmanaged);
            var be = state.GetBufferLookup<InventorySlotBufferElement>();

            var jobHandle = new CollisionJob
            {
                PlayerLookup = state.GetComponentLookup<PlayerTag>(true),
                StoneLookup = state.GetComponentLookup<StoneTag>(true),
                BufferLookup = be,
                CommandBuffer = ecb,
            }.Schedule(simulationSingleton, state.Dependency);

            jobHandle.Complete();
        }

        public partial struct CollisionJob : ICollisionEventsJob
        {
            [ReadOnly] public ComponentLookup<PlayerTag> PlayerLookup;
            [ReadOnly] public ComponentLookup<StoneTag> StoneLookup;
            public BufferLookup<InventorySlotBufferElement> BufferLookup;
            public EntityCommandBuffer CommandBuffer;

            public void Execute(CollisionEvent collisionEvent)
            {
                if (PlayerLookup.HasComponent(collisionEvent.EntityA))
                {
                    if (StoneLookup.HasComponent(collisionEvent.EntityB))
                    {
                        CommandBuffer.DestroyEntity(collisionEvent.EntityB);
                        BufferLookup.TryGetBuffer(collisionEvent.EntityA, out var dy);

                        dy.ElementAt(0).Count ++;
                    }
                }
            }
        }
    }
}
