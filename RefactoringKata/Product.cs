using System.Runtime.InteropServices.WindowsRuntime;

namespace RefactoringKata
{
    public class Product
    {
        public static int SIZE_NOT_APPLICABLE = -1;

        public string Code { get; set; }
        public ProductColor Color { get; set; }
        public ProductSize Size { get; set; }

        public double Price { get; set; }
        public string Currency { get; set; }

        public Product(string code, ProductColor color, ProductSize size, double price, string currency)
        {
            Code = code;
            Color = color;
            Size = size;
            Price = price;
            Currency = currency;
        }
    }
}
