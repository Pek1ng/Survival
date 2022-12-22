﻿using Unity.Mathematics;
using Unity.NetCode;

namespace Survival.Controller
{
    public struct InputData : IInputComponentData
    {
        [GhostField(Quantization = 100)]
        public float3 RayOrigin;

        [GhostField(Quantization = 100)]
        public float3 RayEnd;

        [GhostField(SendData =false)]
        public float3 HitPosition;

        [GhostField(Quantization = 100)]
        public float2 Move;

        [GhostField]
        public bool MouseClick;
    }
}