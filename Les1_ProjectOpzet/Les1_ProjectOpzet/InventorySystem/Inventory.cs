using System.Collections.Generic;

namespace Les1_ProjectOpzet.InventorySystem
{
    public class Inventory
    {
        private List<Item> items;

        public Inventory()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public Item[] GetAllItems()
        {
            return items.ToArray();
        }
    }
}