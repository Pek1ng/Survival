using Survival.Controller;
using Survival.Creatures;
using Survival.Datas.Inventory;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Physics;

namespace Survival.Physics
{
    /// <summary>
    /// 捡物品系统
    /// </summary>
    [BurstCompile]
    [WorldSystemFilter(WorldSystemFilterFlags.ServerSimulation)]
    public partial struct PickUpItemSystem : ISystem
    {
        private ComponentLookup<PlayerTag> _playerLookup;
        private ComponentLookup<StoneTag> _stoneLookup;
        private BufferLookup<InventorySlotBufferElement> _inventorySlotLookup;

        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            _playerLookup = state.GetComponentLookup<PlayerTag>(true);
            _stoneLookup = state.GetComponentLookup<StoneTag>(true);
            _inventorySlotLookup = state.GetBufferLookup<InventorySlotBufferElement>();
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

            _playerLookup.Update(ref state);  //更新数据
            _stoneLookup.Update(ref state);
            _inventorySlotLookup.Update(ref state);

            var jobHandle = new CollisionJob
            {
                PlayerLookup = _playerLookup,
                StoneLookup = _stoneLookup,
                BufferLookup = _inventorySlotLookup,
                CommandBuffer = ecb,
            }.Schedule(simulationSingleton, state.Dependency);

            jobHandle.Complete();
        }

        [BurstCompile]
        public partial struct CollisionJob : ICollisionEventsJob
        {
            [ReadOnly] public ComponentLookup<PlayerTag> PlayerLookup;
            [ReadOnly] public ComponentLookup<StoneTag> StoneLookup;
            public BufferLookup<InventorySlotBufferElement> BufferLookup;
            public EntityCommandBuffer CommandBuffer;

            [BurstCompile]
            public void Execute(CollisionEvent collisionEvent)
            {
                if (PlayerLookup.HasComponent(collisionEvent.EntityA)) 
                {
                    if (StoneLookup.HasComponent(collisionEvent.EntityB))
                    {
                        CommandBuffer.DestroyEntity(collisionEvent.EntityB);
                        BufferLookup.TryGetBuffer(collisionEvent.EntityA, out var bufferData);
                        bufferData.ElementAt(0).Count++;  //当捡到物品，计数增加
                    }
                }
            }
        }
    }
}
