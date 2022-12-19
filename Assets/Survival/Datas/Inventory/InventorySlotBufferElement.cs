using Survival.Datas.Items;
using Unity.Collections;
using Unity.Entities;

namespace Survival.Datas.Inventory
{
    [InternalBufferCapacity(100)]
    public struct InventorySlotBufferElement : IBufferElementData
    {
        public FixedString32Bytes ID;

        /// <summary>
        /// 当前物品的数量
        /// </summary>
        public int Count;
    }
}
