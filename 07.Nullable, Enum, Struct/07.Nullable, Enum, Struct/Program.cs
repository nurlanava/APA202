using System;

namespace SimpleCafeOrder
{
    
    public enum DrinkType
    {
        Coffee = 0,
        Tea = 1,
        Juice = 2,
        Water = 3
    }

    public enum DrinkSize
    {
        Small = 0,
        Medium = 1,
        Large = 2
    }

    public enum OrderStatus
    {
        New = 0,
        Preparing = 1,
        Ready = 2,
        Delivered = 3
    }

    
    public class DrinkOrder
    {
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public DrinkType Drink { get; set; }
        public DrinkSize Size { get; set; }
        public OrderStatus Status { get; set; }
        public decimal Price { get; set; }

      
        public DrinkOrder(int orderNumber, string customerName, DrinkType drink, DrinkSize size)
        {
            OrderNumber = orderNumber;
            CustomerName = customerName;
            Drink = drink;
            Size = size;
            Status = OrderStatus.New;
            Price = CalculatePrice();
        }

        public decimal CalculatePrice()
        {
            decimal price = 0m;

            switch (Drink)
            {
                case DrinkType.Coffee:
                    switch (Size)
                    {
                        case DrinkSize.Small: price = 3; break;
                        case DrinkSize.Medium: price = 4; break;
                        case DrinkSize.Large: price = 5; break;
                    }
                    break;

                case DrinkType.Tea:
                    switch (Size)
                    {
                        case DrinkSize.Small: price = 2; break;
                        case DrinkSize.Medium: price = 3; break;
                        case DrinkSize.Large: price = 4; break;
                    }
                    break;

                case DrinkType.Juice:
                    switch (Size)
                    {
                        case DrinkSize.Small: price = 4; break;
                        case DrinkSize.Medium: price = 5; break;
                        case DrinkSize.Large: price = 6; break;
                    }
                    break;

                case DrinkType.Water:
                    switch (Size)
                    {
                        case DrinkSize.Small: price = 1; break;
                        case DrinkSize.Medium: price = 1.5m; break;
                        case DrinkSize.Large: price = 2; break;
                    }
                    break;
            }

            return price;
        }

        public void UpdateStatus(OrderStatus newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"Sifariş #{OrderNumber} statusu: {newStatus}");
        }

        public void DisplayOrder()
        {
            Console.WriteLine("Sifariş ");
            Console.WriteLine($"Order Number: {OrderNumber}");
            Console.WriteLine($"Customer Name: {CustomerName}");
            Console.WriteLine($"Drink: {Drink} | Size: {Size}");
            Console.WriteLine($"Status: {Status}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine(" ");
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
         
            DrinkOrder order1 = new DrinkOrder(101, "Ali", DrinkType.Coffee, DrinkSize.Medium);
            DrinkOrder order2 = new DrinkOrder(102, "Leyla", DrinkType.Tea, DrinkSize.Large);
            DrinkOrder order3 = new DrinkOrder(103, "Vüqar", DrinkType.Juice, DrinkSize.Small);

            order1.DisplayOrder();
            order1.UpdateStatus(OrderStatus.Preparing);
            order1.UpdateStatus(OrderStatus.Ready);
            order1.UpdateStatus(OrderStatus.Delivered);

            order2.DisplayOrder();
            order2.UpdateStatus(OrderStatus.Ready);

         
            order3.DisplayOrder();

            
            Console.WriteLine("\nBütün DrinkType deyerleri:");
            foreach (var d in Enum.GetValues(typeof(DrinkType)))
            {
                Console.WriteLine(d);
            }

            Console.WriteLine("\nBütün DrinkSize deyerleri:");
            foreach (var s in Enum.GetValues(typeof(DrinkSize)))
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\nBütün OrderStatus deyerleri:");
            foreach (var st in Enum.GetValues(typeof(OrderStatus)))
            {
                Console.WriteLine(st);
            }

           
            DrinkType parsedDrink = (DrinkType)Enum.Parse(typeof(DrinkType), "Tea");
            DrinkSize parsedSize = (DrinkSize)Enum.Parse(typeof(DrinkSize), "Medium");
            Console.WriteLine($"\nParsed DrinkType: {parsedDrink}");
            Console.WriteLine($"Parsed DrinkSize: {parsedSize}");
            Console.WriteLine($"ToString numunesi: {DrinkType.Coffee.ToString()}");

            
            decimal total = order1.Price + order2.Price + order3.Price;
            Console.WriteLine("\n----- Statistika -----");
            Console.WriteLine("Ümumi sifariş: 3");
            Console.WriteLine($"1-ci sifarişin qiymeti: {order1.Price} AZN");
            Console.WriteLine($"2-ci sifarişin qiymeti: {order2.Price} AZN");
            Console.WriteLine($"3-cü sifarişin qiymeti: {order3.Price} AZN");
            Console.WriteLine($"Ümumi mebleg: {total} AZN");

            Console.ReadKey();
        }
    }
}