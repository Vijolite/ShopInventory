namespace ShopInventory
{
    public class Purchase
    {
        public List<Buy> PurchaseList {get; set;}
        public Customer Customer {get; set;}
        public DateTime Date {get; set;}
        
        public Purchase (Customer  customer)
        {
            PurchaseList = new List<Buy>();
            Customer=customer;
            Date=DateTime.Now;
        }

        public void AddToBasket(Stock st, int count) 
        {
            int countCanBuy=st.SubtractAmount(count);
            Item item = new Item (st.Item.Name);
            Buy buy = new Buy (item,countCanBuy);
            PurchaseList.Add(buy);
        }

        public void PrintPurchaseInfo () 
        {
            Console.WriteLine("Customer {0} bought {1}:",Customer.Name, Date.ToString("dd-MM-yyyy"));
            foreach (Buy buy in PurchaseList) {
                Console.WriteLine("Item: {0} Count: {1}",buy.Item.Name, buy.Amount);
            };
        }
    }
}