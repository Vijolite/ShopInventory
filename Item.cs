namespace ShopInventory
{
    public class Item
    {
        // private String _name;
        // get 
        // {
        //     return _name;
        // }
        // set
        // {
        //     _name=value;
        // }
        public String Name {get; set;}

        public Item (String name)
        {
            Name=name;
        }
        public void PrintName()
        {
            Console.WriteLine(Name);
        }
    }
}