namespace ShopInventory
{
    public class Manager : Human
    {   
        public Manager (String name) : base (name)
        {
            Name = name;
        }
        public void PrintInfo()
        { 
            Console.WriteLine("Manager {0} is working here",Name);
        }
    }
}