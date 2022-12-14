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
        Transform _cameraTransform;
        float3 _cameraOffset;

        protected override void OnCreate()
        {
            _cameraTransform = Camera.main.transform;
            _cameraOffset = new float3(0, 6f, -8f);

            RequireForUpdate<GhostOwnerComponent>();
        }

        protected override void OnUpdate()
        {
            var myConnection = SystemAPI.GetSingleton<NetworkIdComponent>().Value;

            Entities
                    .WithoutBurst()
                    .WithAll<PlayerTag>()
                    .ForEach((in TransformAspect transformAspect, in GhostOwnerComponent owner) =>
                    {
                        if (owner.NetworkId != myConnection)
                        {
                            return;
                        }
                        _cameraTransform.position = transformAspect.LocalPosition + _cameraOffset; //计算相机位置
                    }).Run();
        }
    }
}
