using Unity.NetCode;
using UnityEngine.Scripting;

namespace Survival.Nework
{
    [Preserve] //∑¿÷π±ª≤√ºÙ
    public class GameBootstrap : ClientServerBootstrap
    {
        public override bool Initialize(string defaultWorldName)
        {
            AutoConnectPort = 7979;

            return base.Initialize(defaultWorldName);
        }
    }
}
