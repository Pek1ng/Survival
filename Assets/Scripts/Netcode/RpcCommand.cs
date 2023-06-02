using Unity.NetCode;

namespace Survival.Netcode
{
    // 客户端为进入游戏向服务器发出RPC请求
    public struct GoInGameRequest : IRpcCommand
    {
    }
}
