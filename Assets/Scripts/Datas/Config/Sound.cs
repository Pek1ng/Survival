using System;
using Unity.Mathematics;

namespace Survival.Datas
{
    /// <summary>
    /// 声音设置项
    /// </summary>
    [Serializable]
    public class Sound : IJsonFile
    {
        private int _music;

        /// <summary>
        /// 音量大小
        /// </summary>
        public int Music
        {
            get
            {
                return _music;
            }
            set
            {
                _music = math.clamp(value, 0, 100);
            }
        }

        private int _effets;

        /// <summary>
        /// 音效大小
        /// </summary>
        public int Effets
        {
            get
            {
                return _music;
            }
            set
            {
                _music = math.clamp(value, 0, 100);
            }
        }
    }
}


