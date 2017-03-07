namespace RefactoringKata
{
    public class Product
    {
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

        public string GetFormat()
        {
            string sizeSubString = string.Empty;
            if(Size != ProductSize.SizeNotApplicable)
                sizeSubString = string.Format("\"size\": \"{0}\", ",Size.GetDescription());
            var productStringFormat = "{{\"code\": \"{0}\", \"color\": \"{1}\", {2}\"price\": {3}, \"currency\": \"{4}\"}}";
            return string.Format(productStringFormat, Code, Color.GetDescription(), sizeSubString, Price, Currency);
        }
    }
}
