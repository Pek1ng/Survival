using Unity.NetCode;
using UnityEngine;
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

            //在编辑器下自动创建世界，否则创建默认的世界    
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
