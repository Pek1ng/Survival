using Survival.Entities.Controls;
using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Survival.Controls
{
    //public partial struct InputListeningISystem : ISystem, InputActions.IPlayerActions
    //{
    //    private float2 _move { get; set; }
    //    private float2 _look { get; set; }

    //    public void OnCreate(ref SystemState state)
    //    {
    //        InputActions inputAction = new InputActions();
    //        inputAction.Enable();
    //        inputAction.Player.SetCallbacks(this);
    //    }

    //    public void OnDestroy(ref SystemState state)
    //    {
           
    //    }

    //    public void OnUpdate(ref SystemState state)
    //    {
    //        var jobHandle = new InputListeningJob
    //        {
    //            Move = _move,
    //            Look = _look,
    //        }.ScheduleParallel(state.Dependency);

    //        jobHandle.Complete();
    //    }

    //    public void OnLook(InputAction.CallbackContext context)
    //    {
    //        _look = context.ReadValue<Vector2>();
    //    }

    //    public void OnMove(InputAction.CallbackContext context)
    //    {
    //        _move = context.ReadValue<Vector2>();
    //    }

    //    public void OnFire(InputAction.CallbackContext context)
    //    {
            
    //    }

    //    [BurstCompile]
    //    public partial struct InputListeningJob : IJobEntity
    //    {
    //        public float2 Move;
    //        public float2 Look;

    //        [BurstCompile]
    //        public void Execute(ref InputData inputData)
    //        {
    //            inputData.Look = Look;
    //            inputData.Move = Move;
    //        }
    //    }
    //}
}
