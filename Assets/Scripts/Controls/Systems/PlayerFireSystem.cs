using Survival.Controls;
using Unity.Burst;
using Unity.Entities;
using Unity.Physics;
using Unity.Physics.Authoring;
using Unity.Transforms;

namespace Survival.Entities.Inputs
{
    [UpdateAfter(typeof(InputListeningSystem))]
    [BurstCompile]
    public partial struct PlayerFireSystem : ISystem
    {
        private CollisionFilter _collisionFilter;

        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            var belongsTo = new PhysicsCategoryTags
            {
                Category00 = true
            };

            var collidesWith = PhysicsCategoryTags.Everything;

            _collisionFilter = new CollisionFilter
            {
                BelongsTo = belongsTo.Value,
                CollidesWith = collidesWith.Value
            };
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {

        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            foreach ((var transformAspect, var inputData, Entity e) in SystemAPI.Query<TransformAspect, RefRO<InputData>>().WithEntityAccess())
            {
                var raycastInput = new RaycastInput
                {
                    Start = inputData.ValueRO.Ray.origin,
                    End = inputData.ValueRO.Ray.GetPoint(100f),
                    Filter = _collisionFilter
                };

                PhysicsWorldSingleton physicsWorld = SystemAPI.GetSingleton<PhysicsWorldSingleton>();
                physicsWorld.CastRay(raycastInput, out RaycastHit hit);

                var targetPosition = hit.Position;
                targetPosition.y = 0;


                //transformAspect.LookAt(targetPosition);
            }
        }
    }

    [BurstCompile]
    public partial struct PlayerFireJob : IJobEntity
    {
        [BurstCompile]
        public void Execute()
        {

        }
    }
}

