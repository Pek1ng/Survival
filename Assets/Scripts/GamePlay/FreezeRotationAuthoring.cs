using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using UnityEngine;

namespace Survival.GamePlay
{
    public struct FreezeRotation : IComponentData
    {
        public bool3 Value;
    }

    [RequireComponent(typeof(Rigidbody))]
    [DisallowMultipleComponent]
    public class FreezeRotationAuthoring : MonoBehaviour
    {
        public bool3 Flags;

        private class FreezeRotationAuthoringBaker : Baker<FreezeRotationAuthoring>
        {
            public override void Bake(FreezeRotationAuthoring authoring)
            {
                Entity e = GetEntity(authoring, TransformUsageFlags.None);
                AddComponent(e, new FreezeRotation { Value = authoring.Flags });
            }
        }
    }

    [BurstCompile]
    public partial struct FreezeRotationSystem : ISystem
    {
        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            foreach (var (physicsMassRW, flags) in SystemAPI.Query<RefRW<PhysicsMass>, FreezeRotation>())
            {
                if (flags.Value.x)
                {
                    physicsMassRW.ValueRW.InverseInertia.x = 0;
                }
                if (flags.Value.y)
                {
                    physicsMassRW.ValueRW.InverseInertia.y = 0;
                }
                if (flags.Value.z)
                {
                    physicsMassRW.ValueRW.InverseInertia.z = 0;
                }
            }
        }
    }
}