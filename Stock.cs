namespace ShopInventory
{
    public class Stock
    {
        public Item Item {get; set;}
        public int Amount {get; set;}
        public Stock (Item item, int amount)
        {
            Item=item;
            Amount=amount;
        }
        public Stock (Item item)
        {
            Item=item;
            Amount=0;
        }
        public void PrintInfo()
        { 
            Console.WriteLine("Item name = {0}, Amount = {1}",Item.Name,Amount);
        }
        public void AddAmount(int amount)
        {
            Amount+=amount;
        }
        public int SubtractAmount(int amount)
        {
            int subtracted;
            if (Amount-amount>0) 
            {
                subtracted=amount;
                Amount-=amount;
            }
            else
            {
                subtracted=Amount;
                Amount=0;
            }
            return subtracted;
        }
    }
}