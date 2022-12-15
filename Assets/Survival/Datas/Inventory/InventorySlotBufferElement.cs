using Unity.Entities;

namespace Survival.Datas.Inventory
{
    [InternalBufferCapacity(100)]
    public struct InventorySlotBufferElement : IBufferElementData
    {
        /// <summary>
        /// 物体的实体
        /// </summary>
        public Entity ItemEntity;

        /// <summary>
        /// 当前物品的数量
        /// </summary>
        public int Count;
    }
}
