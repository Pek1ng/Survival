using Survival.Datas.Items;
using Unity.Entities;

namespace Survival.Datas.Inventory
{
    [InternalBufferCapacity(100)]
    public struct InventorySlotBufferElement : IBufferElementData
    {
        /// <summary>
        /// 物体的实体
        /// </summary>
        public BlobAssetReference<ItemData> Reference;

        /// <summary>
        /// 当前物品的数量
        /// </summary>
        public int Count;
    }
}
