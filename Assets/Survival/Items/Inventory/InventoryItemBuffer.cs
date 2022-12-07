using Unity.Entities;

namespace Survival.Items.Inventory
{
    public struct InventoryItemBuffer : IBufferElementData
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
