using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;
using UnityEngine;

namespace Taxa.Entities.Player
{
    public partial class CharacterControlSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            var h = Input.GetAxisRaw("Horizontal");
            var v = Input.GetAxisRaw("Vertical");

            //椭圆映射，解决斜角速度块的问题
            var h2 = h * math.sqrt(1 - v * v / 2f);
            var v2 = v * math.sqrt(1 - h * h / 2f);

            var deltaTime = SystemAPI.Time.DeltaTime;

            var targetPosition = CameraLink.Instance.PositionOfTheMouseRay;
            targetPosition.y = 0;

            float3 cameraPosition = Vector3.zero;
            var moveData = new float2(h2, v2);

            Entities.WithAll<PlayerTag>()
                    .ForEach((ref TransformAspect transform, ref PhysicsVelocity physiceVelocity, ref TargetPosition targetPosition, in MovementSpeed speed) =>
                    {
                        if (h2 != 0f || v2 != 0f)
                        {
                            targetPosition.Enable = false; //当有操作时就不让自动移动
                        }

                        cameraPosition = transform.LocalPosition + new float3(0, 6f, -8f); //计算相机位置

                        physiceVelocity.Linear.xz += moveData * deltaTime * speed.Value; //人物移动
                        physiceVelocity.Angular = float3.zero;
                    }).Run();

            CameraLink.Instance.MainCamera.transform.position = cameraPosition;
        }
    }
}