namespace ShopInventory
{
    public class Order
    {
        public List<Buy> OrderList {get; set;}
        public Manager Manager {get; set;}
        public DateTime Date {get; set;}
        
        public Order (Manager  manager)
        {
            OrderList = new List<Buy>();
            Manager=manager;
            Date=DateTime.Now;
        }

        public void AddToOrder(Stock st, int count) 
        {
            Item item = new Item (st.Item.Name);
            Buy buy = new Buy (item,count);
            st.AddAmount(count);
            OrderList.Add(buy);
        }

        public void PrintOrderInfo () 
        {
            Console.WriteLine("Manager {0} ordered {1}:",Manager.Name, Date.ToString("dd-MM-yyyy"));
            foreach (Buy buy in OrderList) {
                Console.WriteLine("Item: {0} Count: {1}",buy.Item.Name, buy.Amount);
            };
        }
    }
}