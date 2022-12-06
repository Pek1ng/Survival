using System;

namespace Survival.Inventory
{
    /// <summary>
    /// 物品分类
    /// </summary>
    [Flags]
    public enum ItemCategory
    {
        /// <summary>
        /// 可以装备的
        /// </summary>
        Equippable,
        /// <summary>
        /// 可使用的
        /// </summary>
        Usable,
    }
}
