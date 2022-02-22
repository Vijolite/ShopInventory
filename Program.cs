namespace ShopInventory
{
    class Program
    {
        static void Main(String[] args)
        {
            Item book1 = new Item("book - Harry Potter");
            Item apple = new Item("Apple");
            Item greeting = new Item("Greeting Card");

            Stock book1_st = new Stock (book1,5);
            Stock apple_st = new Stock (apple,15);
            Stock greeting_st = new Stock (greeting,150);

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

            Customer jacob = new Customer("Jacob","London road 54 NE32OL");
            Purchase jacob_p1 = new Purchase (jacob);
            jacob_p1.AddToBasket(book1_st,1);
            jacob_p1.AddToBasket(greeting_st,2);
            jacob_p1.PrintPurchaseInfo(); 
            w.PrintStockList();
            jacob_p1.CancelPurchase();
            jacob_p1.PrintPurchaseInfo(); 
            w.PrintStockList();

            Manager anna = new Manager("Anna");
            Order anna_o1 = new Order(anna);
            anna_o1.AddToOrder(book1_st,10);
            anna_o1.AddToOrder(greeting_st,10);
            anna_o1.AddToOrder(apple_st,10);
            anna_o1.AddToOrder("candle",25,w);
            anna_o1.PrintOrderInfo(); 
            w.PrintStockList();
        }
    }
}
