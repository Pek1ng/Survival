using System;
using Unity.Entities;

namespace Survival.Datas.Items
{
    [Serializable]
    public struct ItemData : IComponentData
    {
        public BlobString ID;

        public ItemCategory ItemCategory;

        public ItemType ItemType;

        public int Price;

        public int MaxStacks;

        public Entity Entity;
    }
}
