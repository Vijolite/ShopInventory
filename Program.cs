namespace ShopInventory
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("'Program'");
            Item book1 = new Item("book - Harry Potter");
            Item apple = new Item("Apple");
            Item greeting = new Item("Greeting Card");
            //book1.PrintName();
            Stock book1_st = new Stock (book1,5);
            Stock apple_st = new Stock (apple,15);
            Stock greeting_st = new Stock (greeting,150);
            //book1_st.PrintInfo();
            Warehouse w = new Warehouse();
            w.AddStock(book1_st);
            w.AddStock(apple_st);
            w.AddStock(greeting_st);
            w.PrintStockList();

            Customer mary = new Customer("Mary");
            Purchase mary_p1 = new Purchase (mary);
            mary_p1.AddToBasket(apple_st,7);
            mary_p1.AddToBasket(greeting_st,2);
            mary_p1.PrintPurchaseInfo(); 
            w.PrintStockList();

            Customer jacob = new Customer("Jacob");
            Purchase jacob_p1 = new Purchase (jacob);
            jacob_p1.AddToBasket(book1_st,1);
            jacob_p1.AddToBasket(greeting_st,2);
            jacob_p1.PrintPurchaseInfo(); 
            w.PrintStockList();
        }
    }
}
