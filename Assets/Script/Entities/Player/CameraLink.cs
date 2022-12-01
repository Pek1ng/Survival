using System;
using Unity.Mathematics;
using UnityEngine;


namespace Taxa.Entities.Player
{
    //[Obsolete("请使用CameraLinkSystem")]
    public class CameraLink : MonoBehaviour
    {
        public static CameraLink Instance;

        public Camera MainCamera;

        public float3 PositionOfTheMouseRay;

        private void Awake()
        {
            MainCamera = GetComponent<Camera>();
            Instance = this;
        }

        private void Update()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo = new RaycastHit();
            Physics.Raycast(ray, out hitInfo, 100f);

            PositionOfTheMouseRay = hitInfo.point;
        }
    }
}

