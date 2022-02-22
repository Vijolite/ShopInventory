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
            if (countCanBuy>0)
            {
                Item item = new Item (st.Item.Name);
                Buy buy = new Buy (item,countCanBuy,st);
                PurchaseList.Add(buy);
            }
            else
                Console.WriteLine("The amount of {0} is already 0, you cannot buy it ",st.Item.Name);
        }

        public void CancelPurchase()
        {
            foreach (Buy buy in PurchaseList) {
                buy.Stock.AddAmount(buy.Amount);
            };
            PurchaseList.Clear();
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