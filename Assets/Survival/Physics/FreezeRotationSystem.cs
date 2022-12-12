using Survival.Controller;
using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;

[BurstCompile]
public partial struct FreezeRotationSystem : ISystem
{
    [BurstCompile]
    public void OnCreate(ref SystemState state)
    {
        
    }

    [BurstCompile]
    public void OnDestroy(ref SystemState state)
    {

    }

    [BurstCompile]
    public void OnUpdate(ref SystemState state)
    {
        foreach (var physicsMass in SystemAPI.Query<RefRW<PhysicsMass>>().WithAll<PlayerTag>())
        {
            physicsMass.ValueRW.InverseInertia.xz = float2.zero;
        }
    }
}
