using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.NetCode;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Survival.Controller
{
    [BurstCompile]
    [UpdateInGroup(typeof(GhostInputSystemGroup))] //该组只在本地运行
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
            var ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue()); //老版本射线
            var origin = ray.origin;
            var end = ray.GetPoint(100f);

            var move = _move;
            var mouseClick = _mouseClick;

            Entities.ForEach((ref InputData inputData) =>
                {
                    inputData.RayOrigin = origin;
                    inputData.RayEnd = end;
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
            _mouseClick = context.performed;

        }

        public void OnLook(InputAction.CallbackContext context)
        {

        }

        public void OnSwitchTabBar(InputAction.CallbackContext context)
        {
            Debug.Log(context.ReadValue<float>());
        }
    }
}
