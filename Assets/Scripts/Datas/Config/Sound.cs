using System;
using Unity.Mathematics;

namespace Survival.Datas
{
    /// <summary>
    /// ����������
    /// </summary>
    [Serializable]
    public class Sound : IJsonFile
    {
        private int _music = 100;

        /// <summary>
        /// ������С
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

        private int _effets = 100;

        /// <summary>
        /// ��Ч��С
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


