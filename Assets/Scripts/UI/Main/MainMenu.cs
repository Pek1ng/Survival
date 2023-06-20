using System;
using System.Net;
using TMPro;
using Unity.Entities;
using Unity.NetCode;
using Unity.Networking.Transport;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
using PlayType = Unity.NetCode.ClientServerBootstrap.PlayType;

namespace Survival.UI
{
    public sealed class MainInterface : MonoBehaviour
    {
        public TMP_InputField IPInputField;

        public TMP_InputField PortInputField;

        public static string DefaultWorldName;

        public void StartHost()
        {
            if (!IsValidPlayType(PlayType.ClientAndServer))
            {
                return;
            }

            var server = ClientServerBootstrap.CreateServerWorld("ServerWorld");
            var client = ClientServerBootstrap.CreateClientWorld("ClientWorld");

            SceneManager.LoadScene("World");
            DestroyLocalSimulationWorld();

            if (World.DefaultGameObjectInjectionWorld == null)
            {
                World.DefaultGameObjectInjectionWorld = server;
            }
                
            var port = Convert.ToUInt16(PortInputField.text);
            NetworkEndpoint ep = NetworkEndpoint.AnyIpv4.WithPort(port);
            {
                using var drvQuery = server.EntityManager.CreateEntityQuery(ComponentType.ReadWrite<NetworkStreamDriver>());
                drvQuery.GetSingletonRW<NetworkStreamDriver>().ValueRW.Listen(ep);
            }
            ep = NetworkEndpoint.LoopbackIpv4.WithPort(port);
            {
                using var drvQuery = client.EntityManager.CreateEntityQuery(ComponentType.ReadWrite<NetworkStreamDriver>());
                drvQuery.GetSingletonRW<NetworkStreamDriver>().ValueRW.Connect(client.EntityManager, ep);
            }
        }

        public void StartServer()
        {
            if (!IsValidPlayType(PlayType.Server))
            {
                return;
            }

            var server = ClientServerBootstrap.CreateServerWorld("ServerWorld");

            SceneManager.LoadScene("World");
            DestroyLocalSimulationWorld();

            if (World.DefaultGameObjectInjectionWorld == null)
            {
                World.DefaultGameObjectInjectionWorld = server;
            }

            var port = Convert.ToUInt16(PortInputField.text);
            NetworkEndpoint ep = NetworkEndpoint.AnyIpv4.WithPort(port);
            {
                using var drvQuery = server.EntityManager.CreateEntityQuery(ComponentType.ReadWrite<NetworkStreamDriver>());
                drvQuery.GetSingletonRW<NetworkStreamDriver>().ValueRW.Listen(ep);
            }
        }

        public void ConnectToServer()
        {
            if (!IsValidPlayType(PlayType.Client))
            {
                return;
            }

            var client = ClientServerBootstrap.CreateClientWorld("ClientWorld");

            SceneManager.LoadScene("World");
            DestroyLocalSimulationWorld();

            if (World.DefaultGameObjectInjectionWorld == null)
            {
                World.DefaultGameObjectInjectionWorld = client;
            }          

            var ip = IPInputField.text;
            var port = Convert.ToUInt16(PortInputField.text);
            var ep = NetworkEndpoint.Parse(ip, port);
            {
                using var drvQuery = client.EntityManager.CreateEntityQuery(ComponentType.ReadWrite<NetworkStreamDriver>());
                drvQuery.GetSingletonRW<NetworkStreamDriver>().ValueRW.Connect(client.EntityManager, ep);
            }
        }

        /// <summary>
        /// 销毁默认的世界
        /// </summary>
        private void DestroyLocalSimulationWorld()
        {
            foreach (var world in World.All)
            {
                if (world.Flags == WorldFlags.Game)
                {
                    DefaultWorldName = world.Name;
                    world.Dispose();
                    break;
                }
            }
        }

        /// <summary>
        /// 检查
        /// </summary>
        /// <param name="playType">期望的运行模式</param>
        /// <returns></returns>
        private bool IsValidPlayType(PlayType playType)
        {
            if (ClientServerBootstrap.RequestedPlayType != playType)
            {
                Debug.LogError($"以{playType}模式运行失败，需要的运行模式为{ClientServerBootstrap.RequestedPlayType}");
                return false;
            }

            return true;
        }
    }
}
