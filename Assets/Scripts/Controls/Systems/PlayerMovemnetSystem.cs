using Survival.Entities;
using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;

namespace Survival.Controls
{
    [BurstCompile]
    [UpdateAfter(typeof(InputListeningSystem))]
    public partial struct PlayerMovemnetSystem : ISystem
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
            var deltaTime = SystemAPI.Time.DeltaTime;

            var jobHandle = new MovemnetJob
            {
                DeltaTime = deltaTime
            }.ScheduleParallel(state.Dependency);

            jobHandle.Complete();
        }
    }

    [BurstCompile]
    public partial struct MovemnetJob : IJobEntity
    {
        public float DeltaTime;

        [BurstCompile]
        public void Execute(ref TransformAspect transformAspect, ref PhysicsMass physicsMass, ref PhysicsVelocity physiceVelocity, in InputData inputData, in MovementSpeed speed)
        {
            physicsMass.InverseInertia.x = 0f;
            physicsMass.InverseInertia.z = 0f;

            physiceVelocity.Linear.xz += inputData.Move * DeltaTime * speed.Value; //人物移动
            physiceVelocity.Angular = float3.zero;

            float3 direction = float3.zero;
            direction.xz = transformAspect.LocalPosition.xz + inputData.Move;

            if (inputData.Move.x != 0 || inputData.Move.y != 0) //没有输入时就不转向
            {
                transformAspect.LookAt(direction); //人物看向移动方向
            }
        }
    }
}