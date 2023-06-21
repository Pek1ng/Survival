using System;
using Unity.Entities;
using Unity.Mathematics;
using Unity.NetCode;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Survival.GamePlay
{
    [GhostComponent(PrefabType = GhostPrefabType.AllPredicted)]
    public struct InputData : IInputComponentData
    {
        public float Horizontal;
        public float Vertical;
    }

    [UpdateInGroup(typeof(GhostInputSystemGroup))]
    [WorldSystemFilter(WorldSystemFilterFlags.ClientSimulation)]
    public partial class PlayerInputSystem : SystemBase
    {
        private UserControls _inputActions;

        private float2 _move = default;

        protected override void OnCreate()
        {
            _inputActions = new();
            _inputActions.Player.Move.performed += MoveInput;

            _inputActions.Enable();
        }

        protected override void OnDestroy()
        {
            _inputActions.Disable();
        }

        protected override void OnUpdate()
        {
            foreach (var playerInput in SystemAPI.Query<RefRW<InputData>>().WithAll<GhostOwnerIsLocal>())
            {
                playerInput.ValueRW.Horizontal = _move.x;
                playerInput.ValueRW.Vertical = _move.y;
            }
        }

        private void MoveInput(InputAction.CallbackContext context)
        {
            _move = context.ReadValue<Vector2>();
        }
    }

    //[UpdateInGroup(typeof(GhostInputSystemGroup))]
    //[WorldSystemFilter(WorldSystemFilterFlags.ThinClientSimulation)]
    //public partial struct ThinPlayerInputSystem : ISystem
    //{
    //    public void OnUpdate(ref SystemState state)
    //    {
    //        foreach (var (playerInput, transform) in SystemAPI.Query<RefRW<InputData>, LocalToWorld>().WithAll<GhostOwnerIsLocal>())
    //        {

    //        }
    //    }
    //}
}
