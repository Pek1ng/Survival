using System;
using UnityEngine;

namespace Survival.Datas.Items
{
    [CreateAssetMenu(fileName = "新物品", menuName = "数据/物品")]
    [Serializable]
    public class ItemDataSO : ScriptableObject
    {
        public ItemData ItemData;

        public Sprite Sprite;

        public GameObject Prefab;
    }
}