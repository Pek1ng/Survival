using Survival.Entities.Controls;
using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Survival.Controls
{
    [BurstCompile]
    public partial class InputListeningSystem : SystemBase, InputActions.IPlayerActions
    {
        private float2 _move;
        private bool _mouseClick;

        protected override void OnCreate()
        {
            InputActions inputAction = new InputActions();
            inputAction.Enable();
            inputAction.Player.SetCallbacks(this);
        }

        [BurstCompile]
        protected override void OnUpdate()
        {
            var ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue()); //ÀÏ°æ±¾ÉäÏß
            var move = _move;
            var mouseClick = _mouseClick;

            Entities.ForEach((ref InputData inputData) =>
                {
                    inputData.Ray =ray;
                    inputData.Move = move;
                    inputData.MouseClick = mouseClick;
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
                _mouseClick= true;
            }
        }

        public void OnLook(InputAction.CallbackContext context)
        {

        }
    }
}
