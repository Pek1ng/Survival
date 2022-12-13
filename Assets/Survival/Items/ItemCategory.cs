using System;

namespace Survival.Items
{
    /// <summary>
    /// 物品分类
    /// </summary>
    [Flags]
    public enum ItemCategory
    {
        /// <summary>
        /// 装备
        /// </summary>
        Equip = 0,
        /// <summary>
        /// 食物
        /// </summary>
        Food = 1,
        /// <summary>
        /// 植物
        /// </summary>
        Plant = 2,
        /// <summary>
        /// 矿物
        /// </summary>
        Stone = 4,
        /// <summary>
        /// 建筑
        /// </summary>
        Building=8,
    }
}
