using Survival.Datas.Items;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace Survival.Datas.Inventory
{
    public class InventoryAuthoring : MonoBehaviour
    {
        [Range(10, 100)]
        public int MaxSlots;

        public ItemDataSO ItemSO;

        public class InventoryBaker : Baker<InventoryAuthoring>
        {
            public override void Bake(InventoryAuthoring authoring)
            {
                var dynamicBuffer = AddBuffer<InventorySlotBufferElement>();

                for (int i = 0; i < authoring.MaxSlots; i++)
                {
                    dynamicBuffer.Add(new InventorySlotBufferElement());
                }

                //BlobBuilder blobBuilder = new BlobBuilder(Allocator.Temp);
                //ref ItemData root = ref blobBuilder.ConstructRoot<ItemData>();

                //root = authoring.ItemSO.ItemData;

                //blobBuilder.Dispose();
            }
        }
    }
}
