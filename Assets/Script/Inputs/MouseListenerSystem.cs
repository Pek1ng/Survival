using Taxa.Entities.Player;
using TMPro;
using Unity.Burst;
using Unity.Entities;
using Unity.Physics;
using Unity.Physics.Authoring;
using Unity.Transforms;

namespace Taxa.Entities.Inputs
{
    [UpdateAfter(typeof(MouseInputSystem))]
    [BurstCompile]
    public partial struct MouseListenerSystem : ISystem
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
            //Unity old ray
            var singleton = SystemAPI.GetSingletonRW<MouseRaySingleton>().ValueRO;

            var raycastInput = new RaycastInput
            {
                Start = singleton.Ray.origin,
                End = singleton.Ray.GetPoint(100f),
                Filter = _collisionFilter
            };

            PhysicsWorldSingleton physicsWorld = SystemAPI.GetSingleton<PhysicsWorldSingleton>();

            physicsWorld.CastRay(raycastInput, out RaycastHit hit);

            var targetPosition = hit.Position;
            targetPosition.y = 0;


            foreach ((var transformAspect, Entity e) in SystemAPI.Query<TransformAspect>().WithAll<PlayerTag>().WithEntityAccess())
            {
                if (singleton.LeftMouseClick)
                {
                    state.EntityManager.SetComponentEnabled<TargetPosition>(e, true);
                    state.EntityManager.SetComponentData(e, new TargetPosition { Value = targetPosition });
                }

                transformAspect.LookAt(targetPosition);
            }
        }
    }
}

