using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Jobs;

namespace Survival.GamePlay
{
    [BurstCompile]
    partial struct CameraControlSystem : ISystem
    {
        TransformAccessArray _camera;

        [BurstCompile]
        public void OnCreate(ref SystemState state)
        {
            _camera=new TransformAccessArray(new[] { Camera.main.transform } );
        }

        [BurstCompile]
        public void OnDestroy(ref SystemState state)
        {
            _camera.Dispose();
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            _camera[0].position = new float3(0, 0, 0);
        }
    }
}