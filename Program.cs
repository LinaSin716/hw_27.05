namespace hw_27._05
{
    // нет сортировки товаров
    internal class Program
    {
        static void Main(string[] args)
        {
            StoreInventory storeInventory = new StoreInventory();
            storeInventory.items = new List<StoreItem>{
                    new StoreItem("001", 450m),
                    new StoreItem("002", 1000m),
                    new StoreItem("003", 5m),
                    new StoreItem("004", 50m),
                    new StoreItem("006", 10m),
                    new StoreItem("007", 600m),
                    new StoreItem("010", 110m),
                    new StoreItem("200", 50m),
                };
            Console.WriteLine("Все товары: ");
            foreach (StoreItem item in storeInventory.items)
            {
                Console.WriteLine($"Id: {item.ItemId} Price: {item.Price}");
            }
            Console.WriteLine();
            try
            {
                Console.WriteLine("Добавили товар 005 со стоимостью 66\n");
                storeInventory.AddItem(new StoreItem("005", 66m));

                Console.WriteLine("Найти 005: \nId " + storeInventory.FindByItemId("005").ItemId 
                    + " Price: " + storeInventory.FindByItemId("005").Price);
                storeInventory.RemoveItem("005");
                Console.WriteLine("\nУдалили товар 005");
                Console.WriteLine("Найти 005: \n" + storeInventory.FindByItemId("005").ItemId
                    + " " + storeInventory.FindByItemId("005").Price);

            }
            catch(ItemIdException ex) { Console.WriteLine("\nItemIdException: " + ex.Message); }
            catch(Exception ex) { Console.WriteLine(ex.Message); }

            
            decimal price = 50m;
            Console.WriteLine($"\nНайти товары с ценой {price}");
            foreach(StoreItem item in storeInventory.items.Where(i => i.Price == price))
            {
                Console.WriteLine($"Id: {item.ItemId} Price: {item.Price}");
            }
            Console.WriteLine();


            decimal start_price = 50m;
            decimal end_price = 700m;
            Console.WriteLine($"\nТовары с ценой в диапазоне с {start_price} до {end_price}: ");
            foreach (StoreItem item in storeInventory.items.Where(i => i.Price <= end_price && i.Price>=start_price))
            {
                Console.WriteLine($"Id: {item.ItemId} Price: {item.Price}");
            }
            Console.WriteLine();


            Console.WriteLine("Найти 010: \nId: " + storeInventory.FindByItemId("010").ItemId
                    + " Price: " + storeInventory.FindByItemId("010").Price);
            Console.WriteLine("пусть цена станет другой");
            decimal new_price = 99m;
            storeInventory.NewPrice("010", new_price);
            Console.WriteLine("Найти 010: \nId: " + storeInventory.FindByItemId("010").ItemId
                    + " Price: " + storeInventory.FindByItemId("010").Price);

        }
    }
}