using Unity.NetCode;
using UnityEngine.Scripting;

namespace Survival.Netcode
{
     /// <summary>
     /// 自定义引导，实现自动连接
     /// </summary>
    [Preserve]//防止被代码裁剪
    public class GameBootstrap : ClientServerBootstrap
    {
        public override bool Initialize(string defaultWorldName)
        {
            AutoConnectPort = 7979; // 启用自动连接
            return base.Initialize(defaultWorldName); // 使用常规的引导
        }
    }
}
