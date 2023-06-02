using Unity.NetCode;
using UnityEngine.Scripting;

namespace Survival.Netcode
{
     /// <summary>
     /// �Զ���������ʵ���Զ�����
     /// </summary>
    [Preserve]//��ֹ������ü�
    public class GameBootstrap : ClientServerBootstrap
    {
        public override bool Initialize(string defaultWorldName)
        {
            AutoConnectPort = 7979; // �����Զ�����
            return base.Initialize(defaultWorldName); // ʹ�ó��������
        }
    }
}
