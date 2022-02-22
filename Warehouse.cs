namespace ShopInventory
{
    public class Warehouse
    {
        public List<Stock> StockList {get; set;}
        
        public Warehouse ()
        {
            StockList = new List<Stock>();
        }

        public void AddStock(Stock stock)
        { 
            StockList.Add(stock);
        }
        public void PrintStockList()
        {
            Console.WriteLine("--------------Current list of items in warehouse--------------");
            foreach (Stock st in StockList) {
                st.PrintInfo();
            };
            Console.WriteLine("--------------------------------------------------------------");
        }
    }
}