using Survival.Controller;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.UniversalDelegates;
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
            //var simulationSingleton = SystemAPI.GetSingleton<SimulationSingleton>();
            //var ecb = SystemAPI.GetSingleton<BeginSimulationEntityCommandBufferSystem.Singleton>().CreateCommandBuffer(state.WorldUnmanaged);

            //new TriggerJob
            //{
            //    PlayerTag = state.GetComponentLookup<PlayerTag>(true)
            //}.Schedule(simulationSingleton, state.Dependency);
        }

        public partial struct TriggerJob : ICollisionEventsJob
        {
            public EntityCommandBuffer commandBuffer;

            [ReadOnly] public ComponentLookup<PlayerTag> PlayerTag;

            public void Execute(CollisionEvent collisionEvent)
            {
                Debug.Log(collisionEvent.EntityB.Index);
            }
        }
    }
}
