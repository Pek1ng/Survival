using System;

namespace Survival.Datas
{
    /// <summary>
    /// 声音设置项
    /// </summary>
    [Serializable]
    public class Sound
    {
        private int _music = 100;

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
                _music = Math.Clamp(value, 0, 100);
            }
        }

        private int _effets = 100;

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
                _music = Math.Clamp(value, 0, 100);
            }
        }
    }
}


