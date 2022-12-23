using Unity.NetCode;
using UnityEngine.Scripting;

namespace Survival.Nework
{
    [Preserve] //��ֹ���ü�
    public class GameBootstrap : ClientServerBootstrap
    {
        public static ushort NetworkPort = 7979;

        public override bool Initialize(string defaultWorldName)
        {
#if UNITY_EDITOR       //�ڱ༭��ģʽ����ֱ�ӹ�������
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
