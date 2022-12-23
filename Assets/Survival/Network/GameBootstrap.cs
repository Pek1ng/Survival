using Unity.NetCode;
using UnityEngine.Scripting;

namespace Survival.Nework
{
    [Preserve] //防止被裁剪
    public class GameBootstrap : ClientServerBootstrap
    {
        public static ushort NetworkPort = 7979;

        public override bool Initialize(string defaultWorldName)
        {
#if UNITY_EDITOR       //在编辑器模式下能直接构建世界
            var sceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
            bool isWorld = sceneName == "World";

            if (isWorld)
            {
                AutoConnectPort = NetworkPort;
                CreateDefaultClientServerWorlds();
            }
            else
            {
                AutoConnectPort = 0;
                CreateLocalWorld(defaultWorldName);
            }
#else
            CreateLocalWorld(defaultWorldName);
#endif
            return true;
        }
    }
}
