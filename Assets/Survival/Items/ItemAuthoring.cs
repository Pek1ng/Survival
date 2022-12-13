using System;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace Survival.Items
{
    [Serializable]
    public struct ItemData : IComponentData
    {
        public ItemCategory ItemCategory;

        public ItemType ItemType;

        public int Price;

        public int MaxStacks;
    }

    public class ItemAuthoring : MonoBehaviour
    {
        public ItemData ItemData;
    }

    public class ItemBaker : Baker<ItemAuthoring>
    {
        public override void Bake(ItemAuthoring authoring)
        {
            AddComponent(authoring.ItemData);
        }
    }
}
