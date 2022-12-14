using Unity.Entities;
using UnityEngine;

namespace Survival.Datas.Inventory
{
    public class InventoryAuthoring : MonoBehaviour
    {
        [Range(10, 100)]
        public int MaxSlots;

        public class InventoryBaker : Baker<InventoryAuthoring>
        {
            public override void Bake(InventoryAuthoring authoring)
            {
                var dynamicBuffer = AddBuffer<InventorySlotBufferElement>();

                for (int i = 0; i < authoring.MaxSlots; i++)
                {
                    dynamicBuffer.Add(new InventorySlotBufferElement());
                }
            }
        }
    }
}
