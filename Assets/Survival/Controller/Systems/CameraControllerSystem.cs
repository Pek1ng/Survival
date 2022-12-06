using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

namespace Survival.Controller
{
    [UpdateAfter(typeof(PlayerControllerSystem))]
    [BurstCompile]
    public partial class CameraControllerSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            var cameraPosition = float3.zero;

            Entities.WithAll<PlayerTag>()
                    .ForEach((in TransformAspect transformAspect) =>
                    {
                        cameraPosition = transformAspect.LocalPosition + new float3(0, 6f, -8f); //计算相机位置
                    }).Run();

            Camera.main.transform.position = cameraPosition;
        }
    }
}
