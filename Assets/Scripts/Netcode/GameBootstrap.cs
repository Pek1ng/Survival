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
        public static string DefaultWorldName;

        public override bool Initialize(string defaultWorldName)
        {
            DefaultWorldName = defaultWorldName;

            var sceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
            bool isWorld = sceneName == "World";

            if (!isWorld)
            {
                CreateLocalWorld(defaultWorldName);
            }
            else
            {
                AutoConnectPort = 7979;
                CreateDefaultClientServerWorlds();
            }

            return true; 
        }
    }
}
