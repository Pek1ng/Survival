using System;
using Unity.Entities;
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

        protected override void OnCreate()
        {
            _inputActions = new UserControls();
            _inputActions.Player.Move.performed += MoveInput;

            _inputActions.Enable();
        }

        protected override void OnDestroy()
        {
            _inputActions.Dispose();
        }

        protected override void OnUpdate()
        {
            //float h = Input.GetAxis("Horizontal");
            //float v = Input.GetAxis("Vertical");

            //foreach (var playerInput in SystemAPI.Query<RefRW<InputData>>().WithAll<GhostOwnerIsLocal>())
            //{
            //    playerInput.ValueRW = default;

            //    playerInput.ValueRW.Horizontal = h;
            //    playerInput.ValueRW.Vertical = v;
            //}
        }

        private void MoveInput(InputAction.CallbackContext context)
        {
            
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
