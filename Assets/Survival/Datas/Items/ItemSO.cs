using System;
using UnityEngine;

namespace Survival.Datas.Items
{
    [CreateAssetMenu(fileName = "新物品", menuName = "数据/物品")]
    [Serializable]
    public class ItemSO : ScriptableObject
    {
        public string ID;

        public Sprite Sprite;

        public GameObject Prefab;

        public ItemType Type;

        public ItemCategory Category;

        public int MaxStacks;

        public int Price;
    }
}