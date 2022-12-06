using Unity.Collections;
using Unity.Entities;

namespace Survival.Inventory
{
    public struct InventorySlotBufferElement : IBufferElementData
    {
        public FixedString32Bytes ID;

        public int Count;
    }
}
