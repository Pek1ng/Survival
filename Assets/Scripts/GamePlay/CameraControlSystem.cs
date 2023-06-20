using Unity.Burst;
using Unity.Entities;
using Unity.Mathematics;
using Unity.NetCode;
using Unity.Transforms;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.UIElements;

namespace Survival.GamePlay
{
    [WorldSystemFilter(WorldSystemFilterFlags.ClientSimulation)]
    [BurstCompile]
    public partial struct CameraControlSystem : ISystem, ISystemStartStop
    {
        private  TransformAccessArray _cameraTransforms;
        private float3 _startPosition;


        public void OnStartRunning(ref SystemState state)
        {
            _cameraTransforms = new TransformAccessArray(new[] { Camera.main.transform });
            _startPosition = _cameraTransforms[0].position;
        }

        public void OnStopRunning(ref SystemState state)
        {
            _cameraTransforms.Dispose();
        }

        [BurstCompile]
        public void OnUpdate(ref SystemState state)
        {
            float3 position = default;

            foreach (var transform in SystemAPI.Query<LocalTransform>().WithAll<GhostOwnerIsLocal>())
            {
                position = transform.Position;
            }

            var handle = new UpdateTransformJob
            {
                Position = position + _startPosition
            }.Schedule(_cameraTransforms, state.Dependency);
        }

        public struct UpdateTransformJob : IJobParallelForTransform
        {
            public float3 Position;

            public void Execute(int index, TransformAccess transform)
            {
                transform.position = Position;
            }
        }
    }
}