namespace ShopInventory
{
    public class Buy
    {
        public Item Item {get; set;}
        public int Amount {get; set;}
        public Buy (Item item, int amount)
        {
            Item=item;
            Amount=amount;
        }
        public Buy (Item item)
        {
            Item=item;
            Amount=0;
        }
        
    }
}