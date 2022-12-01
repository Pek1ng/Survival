using System;
using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;

namespace Taxa.Entities
{
    [BurstCompile]
    public partial struct TargetPositionSystem : ISystem
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
            //foreach ((var targetPositionRO, var transformAspect) in SystemAPI.Query<EnabledRefRW<TargetPosition>, TransformAspect>())
            //{
            //    var distance = math.distance(targetPositionRO.ValueRO.Value, transformAspect.Position);

            //    if (distance < float.Epsilon)
            //    {

            //    }
            //    else
            //    {
            //        transformAspect.TranslateWorld(targetPositionRO.ValueRO.Value);
            //    }
            //}
        }
    }
}
