namespace ShopInventory
{
    public class Customer : Human
    {   
        public String Address {get; set;}
        public Customer (String name) : base (name)
        {
            Name = name;
            Address="unknown";
        }
        public Customer (String name, String address) : base (name)
        {
            Name = name;
            Address=address;
        }
        public void PrintInfo()
        { 
            Console.WriteLine("Customer's {0} address is {1}",Name,Address);
        }
    }
}