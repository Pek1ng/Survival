using Unity.Burst;
using Unity.Entities;
using UnityEngine;

namespace Taxa.Entities.Inputs
{
    public struct MouseRaySingleton : IComponentData
    {
        public Ray Ray;

        public bool LeftMouseClick;
    }

    [BurstCompile]
    public partial class MouseInputSystem : SystemBase
    {
        [BurstCompile]
        protected override void OnUpdate()
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            var rayRW = SystemAPI.GetSingletonRW<MouseRaySingleton>();

            rayRW.ValueRW.Ray = ray;

            rayRW.ValueRW.LeftMouseClick = Input.GetMouseButtonDown(0);
        }
    }

}
