namespace ShopInventory
{
    public class Buy
    {
        public Item Item {get; set;}
        public int Amount {get; set;}
        public Stock Stock {get; set;}
        public Buy (Item item, int amount, Stock stock)
        {
            Item=item;
            Amount=amount;
            Stock=stock;
        }
        public Buy (Item item, Stock stock)
        {
            Item=item;
            Amount=0;
            Stock=stock;
        }
        
    }
}