using Survival.Entities.Controls;
using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics.Authoring;
using Unity.Physics;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Survival.Controls
{
    [BurstCompile]
    public partial class InputListeningSystem : SystemBase, InputActions.IPlayerActions
    {
        private float2 _move;

        private CollisionFilter _collisionFilter;

        protected override void OnCreate()
        {
            InputActions inputAction = new InputActions();
            inputAction.Enable();
            inputAction.Player.SetCallbacks(this);

            _collisionFilter = new CollisionFilter
            {
                BelongsTo = new PhysicsCategoryTags
                {
                    Category00 = true
                }.Value,

                CollidesWith = PhysicsCategoryTags.Everything.Value
            };
        }

        [BurstCompile]
        protected override void OnUpdate()
        {
            var move = _move;

            Entities.ForEach((ref InputData inputData) =>
            {
                inputData.Move = move;
            }).ScheduleParallel();
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            _move = context.ReadValue<Vector2>();
        }

        public void OnClick(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                var ray = Camera.main.ScreenPointToRay(context.ReadValue<Vector2>());

                var raycastInput = new RaycastInput
                {
                    Start = ray.origin,
                    End = ray.GetPoint(100f),
                    Filter = _collisionFilter
                };

                PhysicsWorldSingleton physicsWorld = SystemAPI.GetSingleton<PhysicsWorldSingleton>();
                physicsWorld.CastRay(raycastInput, out Unity.Physics.RaycastHit hit);
            }
        }
    }
}
