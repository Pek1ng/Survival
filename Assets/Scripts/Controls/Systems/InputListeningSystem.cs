using Survival.Entities.Controls;
using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Survival.Controls
{
    [BurstCompile]
    public partial struct InputListeningSystem : ISystem, InputActions.IPlayerActions
    {
        private static float2 _move;
        private static float2 _look;

        public void OnCreate(ref SystemState state)
        {
            InputActions inputAction = new InputActions();
            inputAction.Enable();
            inputAction.Player.SetCallbacks(this);
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {

        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            var jobHandle = new InputListeningJob
            {
                Move = _move,
                Look = _look
            }.ScheduleParallel(state.Dependency);

            jobHandle.Complete();
        }

        public void OnFire(InputAction.CallbackContext context)
        {

        }

        public void OnLook(InputAction.CallbackContext context)
        {
            _look = context.ReadValue<Vector2>();
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            _move = context.ReadValue<Vector2>();
        }
    }

    [BurstCompile]
    public partial struct InputListeningJob : IJobEntity
    {
        public float2 Move;
        public float2 Look;

        [BurstCompile]
        public void Execute(ref InputData inputData)
        {
            inputData.Move = Move;
            inputData.Look = Look;
        }
    }
}
