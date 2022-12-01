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
            var h = Input.GetAxis("Horizontal");
            var v = Input.GetAxis("Vertical");

            //��Բӳ�䣬���б���ٶȿ������
            h = h * math.sqrt(1 - v * v / 2f);
            v = v * math.sqrt(1 - h * h / 2f);

            var deltaTime = SystemAPI.Time.DeltaTime;

            var targetPosition = CameraLink.Instance.PositionOfTheMouseRay;
            targetPosition.y = 0;

            float3 cameraPosition = Vector3.zero;
            var moveData = new float2(h, v);

            Entities.WithAll<PlayerTag>()
                    .ForEach((ref TransformAspect transform, ref PhysicsVelocity physiceVelocity, in MovementSpeed speed) =>
                    {
                        cameraPosition = transform.Position + new float3(0, 6f, -8f); //�������λ��

                        physiceVelocity.Linear.xz = moveData * deltaTime * speed.Value; //�����ƶ�
                        physiceVelocity.Angular = float3.zero;
                    }).Run();

            CameraLink.Instance.MainCamera.transform.position = cameraPosition;
        }
    }
}