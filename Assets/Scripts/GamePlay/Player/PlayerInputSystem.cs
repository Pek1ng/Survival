using Unity.Entities;
using Unity.Mathematics;
using Unity.NetCode;
using Unity.Transforms;
using UnityEngine;

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
    public partial struct PlayerInputSystem : ISystem
    {
        public void OnUpdate(ref SystemState state)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            foreach (var playerInput in SystemAPI.Query<RefRW<InputData>>().WithAll<GhostOwnerIsLocal>())
            {
                playerInput.ValueRW = default;

                playerInput.ValueRW.Horizontal = h;
                playerInput.ValueRW.Vertical = v;
            }
        }
    }

    [UpdateInGroup(typeof(GhostInputSystemGroup))]
    [WorldSystemFilter(WorldSystemFilterFlags.ThinClientSimulation)]
    public partial struct ThinPlayerInputSystem : ISystem
    {
        public void OnUpdate(ref SystemState state)
        {
            foreach (var (playerInput, transform) in SystemAPI.Query<RefRW<InputData>, LocalToWorld>().WithAll<GhostOwnerIsLocal>())
            {
                playerInput.ValueRW = default;

                playerInput.ValueRW.Horizontal = noise.cnoise(transform.Position.xz);
                playerInput.ValueRW.Vertical = noise.cnoise(transform.Position.xz);

                Debug.Log(playerInput.ValueRW);
            }
        }
    }
}
