using System;
using UnityEngine;

namespace Survival.Datas.Items
{
    [CreateAssetMenu(fileName = "����Ʒ", menuName = "����/��Ʒ")]
    [Serializable]
    public class ItemDataSO : ScriptableObject
    {
        public ItemData ItemData;

        public Sprite Sprite;

        public GameObject Prefab;
    }
}