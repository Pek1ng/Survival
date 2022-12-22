using Unity.NetCode;
using UnityEngine.Scripting;

namespace Survival.Nework
{
    [Preserve] //防止被裁剪
    public class GameBootstrap : ClientServerBootstrap
    {
        public override bool Initialize(string defaultWorldName)
        {
#if UNITY_EDITOR       //在编辑器模式下能直接构建世界
            var sceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
            bool isWorld = sceneName == "World";

            if (isWorld)
            {
                AutoConnectPort = 7979;
                CreateDefaultClientServerWorlds();
            }
            else
            {
                CreateLocalWorld(defaultWorldName);
            }
#else
            AutoConnectPort = 0; 
            CreateLocalWorld(defaultWorldName);
#endif
            return true;
        }
    }
}
