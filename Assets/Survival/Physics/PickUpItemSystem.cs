using Survival.Controller;
using Unity.Burst;
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
            //var s=  SystemAPI.GetSingleton<SimulationSingleton>();

            //new TriggerJob
            //{

            //}.Schedule(s,state.Dependency);
        }

        public partial struct TriggerJob : ICollisionEventsJob
        {
            public void Execute(CollisionEvent collisionEvent)
            {
                
            }
        }
    }
}
