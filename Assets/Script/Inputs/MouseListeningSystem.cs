using Taxa.Entities;
using Taxa.Entities.Player;
using Unity.Burst;
using Unity.Entities;
using Unity.Physics;
using Unity.Physics.Authoring;
using Unity.Transforms;
using UnityEngine;
using RaycastHit = Unity.Physics.RaycastHit;

namespace Entities.Inputs
{
    public struct MouseRaySingleton : IComponentData
    {
        public UnityEngine.Ray Ray;

        public bool LeftMouseClick;
    }

    [BurstCompile]
    public partial class MouseListeningSystem : SystemBase
    {
        [BurstCompile]
        protected override void OnUpdate()
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            var rayRW = SystemAPI.GetSingletonRW<MouseRaySingleton>();

            rayRW.ValueRW.Ray = ray;

            rayRW.ValueRW.LeftMouseClick = Input.GetMouseButtonDown(0);
        }
    }

    //[UpdateInGroup()]
    [UpdateAfter(typeof(MouseListeningSystem))]
    [BurstCompile]
    public partial struct HandlingMouseInput : ISystem
    {
        private CollisionFilter _collisionFilter;
        private Entity _player;

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

            EntityQuery entityQuery = state.EntityManager.CreateEntityQuery(typeof(MovementSpeed));
            _player = entityQuery.ToEntityArray(Unity.Collections.Allocator.Temp)[0];
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


            foreach (var transformAspect in SystemAPI.Query<TransformAspect>().WithAll<PlayerTag>())
            {
                transformAspect.LookAt(targetPosition);
            }

            if (singleton.LeftMouseClick)
            {
                state.EntityManager.SetComponentEnabled<TargetPosition>(_player, true);
            }
        }
    }
}

