# Inventory 仓库系统

## 核心设计

- 使用OOP实现，考虑到以下几点
  - 如果用实体来做物体，然后存储引用，会需要大量的Component，难以管理
  - 库存计算并不多，大部分都是依靠事件驱动
  - 库存的访问修改全在主线程
  - 方便与UI交互，这点非常重要，UI的访问也是在主线程