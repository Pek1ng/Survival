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
        private int _music;

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

        private int _effets;

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


