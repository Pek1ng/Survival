using System;
using UnityEngine;

namespace Survival.Datas.Items
{
    [CreateAssetMenu(fileName = "����Ʒ", menuName = "����/��Ʒ")]
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