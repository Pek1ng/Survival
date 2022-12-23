using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.NetCode;
using Unity.Transforms;
using UnityEngine;

namespace Survival.Controller
{
    [BurstCompile]
    [UpdateAfter(typeof(TransformSystemGroup))]
    [WorldSystemFilter(WorldSystemFilterFlags.ClientSimulation)]
    public partial class CameraControllerSystem : SystemBase
    {
        float3 _cameraOffset;

        protected override void OnCreate()
        {
            _cameraOffset = new float3(0, 6f, -8f);

            RequireForUpdate<GhostOwnerComponent>();
        }

        protected override void OnUpdate()
        {
            Entities
                    .WithoutBurst()
                    .WithAll<PlayerTag>()
                    .ForEach((in TransformAspect transformAspect, in GhostOwnerComponent owner) =>
                    {
                        Camera.main.transform.position = transformAspect.LocalPosition + _cameraOffset; //计算相机位置
                    }).Run();
        }
    }
}
