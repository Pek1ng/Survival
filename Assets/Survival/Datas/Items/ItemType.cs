using System;

namespace Survival.Datas.Items
{
    /// <summary>
    /// 物品分类
    /// </summary>
    [Flags]
    public enum ItemType
    {
        None = 0,
        /// <summary>
        /// 死亡不掉落
        /// </summary>
        Binding = 1,
        /// <summary>
        /// 可以装备的
        /// </summary>
        Equippable = 2,
        /// <summary>
        /// 隐藏
        /// </summary>
        Hidden = 4,
        /// <summary>
        /// 可以使用
        /// </summary>
        Usable = 8,
    }
}
