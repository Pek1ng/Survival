using Unity.Entities;
using Unity.Mathematics;
using Unity.NetCode;
using UnityEngine;

namespace Survival.GamePlay
{
    [GhostComponent(PrefabType = GhostPrefabType.AllPredicted)]
    public struct InputData : IInputComponentData
    {
        public int Horizontal;
        public int Vertical;
    }

    [UpdateInGroup(typeof(GhostInputSystemGroup))]
    [WorldSystemFilter(WorldSystemFilterFlags.ClientSimulation)]
    public partial struct PlayerInputSystem : ISystem
    {
        public void OnUpdate(ref SystemState state)
        {
            bool left = Input.GetKey("left");
            bool right = Input.GetKey("right");
            bool down = Input.GetKey("down");
            bool up = Input.GetKey("up");

            foreach (var playerInput in SystemAPI.Query<RefRW<InputData>>().WithAll<GhostOwnerIsLocal>())
            {
                playerInput.ValueRW = default;
                if (left)
                {
                    playerInput.ValueRW.Horizontal -= 1;
                }
                if (right)
                {
                    playerInput.ValueRW.Horizontal += 1;
                }
                if (down)
                {
                    playerInput.ValueRW.Vertical -= 1;
                }
                if (up)
                {
                    playerInput.ValueRW.Vertical += 1;
                }
            }
        }
    }

    [UpdateInGroup(typeof(GhostInputSystemGroup))]
    [WorldSystemFilter(WorldSystemFilterFlags.ThinClientSimulation)]
    public partial struct ThinPlayerInputSystem : ISystem
    {
        public void OnUpdate(ref SystemState state)
        {
            bool left = Input.GetKey("left");
            bool right = Input.GetKey("right");
            bool down = Input.GetKey("down");
            bool up = Input.GetKey("up");

            foreach (var playerInput in SystemAPI.Query<RefRW<InputData>>().WithAll<GhostOwnerIsLocal>())
            {
                playerInput.ValueRW = default;
                if (left)
                {
                    playerInput.ValueRW.Horizontal -= 1;
                }
                if (right)
                {
                    playerInput.ValueRW.Horizontal += 1;
                }
                if (down)
                {
                    playerInput.ValueRW.Vertical -= 1;
                }
                if (up)
                {
                    playerInput.ValueRW.Vertical += 1;
                }
            }
        }
    }
}
