namespace Les1_ProjectOpzet.InventorySystem
{
    public class Item
    {
        public string Name { get; private set; }

        public Item(string name)
        {
            this.Name = name;
        }
    }
}