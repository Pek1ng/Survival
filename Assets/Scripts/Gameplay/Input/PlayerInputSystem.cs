using System;
using Unity.Entities;
using Unity.Mathematics;
using Unity.NetCode;
using Unity.Transforms;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Survival.GamePlay
{
    [GhostComponent(PrefabType = GhostPrefabType.AllPredicted)]
    public struct InputData : IInputComponentData
    {
        public float2 Move;

        public float2 Look;
    }

    [UpdateInGroup(typeof(GhostInputSystemGroup))]
    [WorldSystemFilter(WorldSystemFilterFlags.ClientSimulation)]
    public partial class PlayerInputSystem : SystemBase
    {
        private UserControls _inputActions;

        private float2 _move = default;

        private float2 _look = default;

        protected override void OnCreate()
        {
            _inputActions = new();
            _inputActions.Player.Move.performed += MoveInput;
            _inputActions.Player.Look.performed += LookInput;

            _inputActions.Enable();
        }

        protected override void OnDestroy()
        {
            _inputActions.Disable();
        }

        protected override void OnUpdate()
        {
            foreach (var (playerInput, transform) in SystemAPI.Query<RefRW<InputData>, LocalTransform>().WithAll<GhostOwnerIsLocal>())
            {
                playerInput.ValueRW.Move = _move;
                playerInput.ValueRW.Look = _look;
            }
        }

        private void MoveInput(InputAction.CallbackContext context)
        {
            _move = context.ReadValue<Vector2>();
        }

        private void LookInput(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                _look = context.ReadValue<Vector2>();
            }
        }
    }

    //[UpdateInGroup(typeof(GhostInputSystemGroup))]
    //[WorldSystemFilter(WorldSystemFilterFlags.ThinClientSimulation)]
    //public partial struct ThinPlayerInputSystem : ISystem
    //{
    //    public void OnUpdate(ref SystemState state)
    //    {
    //        foreach (var playerInput in SystemAPI.Query<RefRW<InputData>>().WithAll<GhostOwnerIsLocal>())
    //        {

    //        }
    //    }
    //}
}
