using System.Text;
using Unity.Entities;
using UnityEngine;

namespace Survival.Items.Inventory
{
    public struct Inventory : IComponentData
    {
        public int MaxSlots;
    }

    public class InventoryAuthoring : MonoBehaviour
    {
        public int MaxSlots;

    }

    public class InventoryBaker : Baker<InventoryAuthoring>
    {
        public override void Bake(InventoryAuthoring authoring)
        {
            AddComponent(new Inventory { MaxSlots = authoring.MaxSlots });

            var buffers = AddBuffer<InventoryItemBuffer>();
            buffers.Add(new InventoryItemBuffer { Count = 1 });
            buffers.Add(new InventoryItemBuffer { Count = 2 });
            buffers.Add(new InventoryItemBuffer { Count = 3 });
        }
    }
}
