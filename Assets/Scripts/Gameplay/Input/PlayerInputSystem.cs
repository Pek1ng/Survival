using Unity.Entities;
using Unity.Mathematics;
using Unity.NetCode;
using Unity.Physics;
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
        private Camera _camera;

        private float2 _move = default;
        private bool _mouse;
        private float2 _look = default;

        CollisionFilter _collisionFilter;

        protected override void OnStartRunning()
        {
            _camera = Camera.main;

            _inputActions = new();
            _inputActions.Player.Move.performed += MoveInput;
            _inputActions.Player.Look.performed += LookInput;

            _inputActions.Enable();

            _collisionFilter = new CollisionFilter
            {
                BelongsTo = ~0u,
                CollidesWith = ~0u,
                GroupIndex = 0
            };
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

                if (!_mouse)
                {
                    playerInput.ValueRW.Look = _look;

                }
                else
                {
                    _look = _look - transform.Position.xz;
                    playerInput.ValueRW.Look = _look;
                    _mouse = false;
                }
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
                if (context.control.device.name == "Mouse")
                {
                    var ray = _camera.ScreenPointToRay(context.ReadValue<Vector2>());

                    RaycastInput raycast = new()
                    {
                        Start = ray.origin,
                        End = ray.GetPoint(100f),
                        Filter = _collisionFilter
                    };

                    SystemAPI.GetSingleton<PhysicsWorldSingleton>().CastRay(raycast, out var hit);

                    _look = hit.Position.xz;
                    _mouse = true;
                }
                else
                {
                    var value = context.ReadValue<Vector2>();

                    if (math.any(math.abs(value) >= new float2(0.5f, 0.5f)))
                    {
                        _look = value;
                    }

                    _mouse = false;
                }
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
