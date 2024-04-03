using System.Security.Cryptography.X509Certificates;

using System.Diagnostics;

internal class Program
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }

    public class Bill
    {
        public List<Product> Products = new List<Product>();
        
        public void AddProductList(Product _pd)
        {
            Products.Add(_pd);
        }
        public void PrintProductList()
        {
            foreach (Product _pd in Products)
            {
                Console.Write("Name :");
                Console.WriteLine(_pd.Name);
                Console.Write("Price :");
                Console.WriteLine(_pd.Price);
            }
        }
    }


    private static void Main(string[] args)
    {
        Bill bill = new Bill();
        bill.AddProductList(new Product("1",1));
        bill.AddProductList(new Product("2", 3));
        bill.AddProductList(new Product("4", 5));
        bill.PrintProductList();

        Debug.WriteLine("Hello, World!");
        //Console.WriteLine("Hello, World!");
    }
}