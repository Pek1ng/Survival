using System.Net;
using Unity.Entities;
using Unity.NetCode;
using Unity.Networking.Transport;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public ushort NetworkPort = 7979;

    public void StartHost()
    {
        var server = ClientServerBootstrap.CreateServerWorld("ServerWorld");
        var client = ClientServerBootstrap.CreateClientWorld("ClientWorld");

        SceneManager.LoadSceneAsync("World");

        NetworkEndpoint ep = NetworkEndpoint.AnyIpv4.WithPort(NetworkPort);
        {
            using var drvQuery = server.EntityManager.CreateEntityQuery(ComponentType.ReadWrite<NetworkStreamDriver>());
            drvQuery.GetSingletonRW<NetworkStreamDriver>().ValueRW.Listen(ep);
        }

        ep = NetworkEndpoint.LoopbackIpv4.WithPort(NetworkPort);
        {
            using var drvQuery = client.EntityManager.CreateEntityQuery(ComponentType.ReadWrite<NetworkStreamDriver>());
            drvQuery.GetSingletonRW<NetworkStreamDriver>().ValueRW.Connect(client.EntityManager, ep);
        }
    }

    public void ConnectToServer()
    {
        var client = ClientServerBootstrap.CreateClientWorld("ClientWorld");

        SceneManager.LoadSceneAsync("World");

        NetworkEndpoint ep = NetworkEndpoint.Parse("localhost", NetworkPort);
        {
            using var drvQuery = client.EntityManager.CreateEntityQuery(ComponentType.ReadWrite<NetworkStreamDriver>());
            drvQuery.GetSingletonRW<NetworkStreamDriver>().ValueRW.Connect(client.EntityManager, ep);
        }
    }
}