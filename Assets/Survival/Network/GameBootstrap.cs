using Unity.NetCode;
using UnityEngine.Scripting;

namespace Survival.Nework
{
    [Preserve] //��ֹ���ü�
    public class GameBootstrap : ClientServerBootstrap
    {
        public override bool Initialize(string defaultWorldName)
        {
#if UNITY_EDITOR       //�ڱ༭��ģʽ����ֱ�ӹ�������
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
