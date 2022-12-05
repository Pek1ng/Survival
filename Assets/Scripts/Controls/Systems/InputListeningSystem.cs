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
        private Vector2 _look;

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
            var ray = Camera.main.ScreenPointToRay(_look);
            var raycastInput = new RaycastInput
            {
                Start = ray.origin,
                End = ray.GetPoint(100f),
                Filter = _collisionFilter
            };

            PhysicsWorldSingleton physicsWorld = SystemAPI.GetSingleton<PhysicsWorldSingleton>();
            physicsWorld.CastRay(raycastInput, out Unity.Physics.RaycastHit hit);


            var move = _move;
            var look = hit.Position;
            look.y = 0;

            Entities.ForEach((ref InputData inputData) =>
            {
                inputData.Look = look;
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
                
            }
        }

        public void OnLook(InputAction.CallbackContext context)
        {
            _look = context.ReadValue<Vector2>();
        }
    }
}
