using Unity.NetCode;
using UnityEngine;
using UnityEngine.Scripting;

namespace Survival.Netcode
{
    /// <summary>
    /// �Զ���������ʵ���Զ�����
    /// </summary>
    [Preserve]//��ֹ������ü�
    public class GameBootstrap : ClientServerBootstrap
    {
        public static string DefaultWorldName;

        public override bool Initialize(string defaultWorldName)
        {
            DefaultWorldName = defaultWorldName;

            var sceneName = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
            bool isWorld = sceneName == "World";

            //�ڱ༭�����Զ��������磬���򴴽�Ĭ�ϵ�����    
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
