namespace Shopping_Card_2
{
    public class Program
    {
        private static ShoppingCard FillingCard()
        {
            ShoppingCard card = new ShoppingCard();

            card.Products.Add(new Product() { Name = "Bolg'a", Price = 10.3M });
            card.Products.Add(new Product() { Name = "Arra", Price = 23.3M });
            card.Products.Add(new Product() { Name = "Tesha", Price = 15.3M });
            card.Products.Add(new Product() { Name = "Drell", Price = 123.3M });
            card.Products.Add(new Product() { Name = "Perfarator", Price = 180.4M });
            card.Products.Add(new Product() { Name = "Kompressor", Price = 15.3M });
      
            return card;
        }
        private static decimal CalculateTotalProductPrice(List<Product> products)
        {
            return products.Sum(p => p.Price);
        }
        private static void PrintTotalDiscountAmount(decimal totalPrise, decimal discountPrice)
        {
            Console.WriteLine($"% amount is: {totalPrise - discountPrice} OFF!");
        }

        public static void Main(string[] args)
        {
            IUser normalUser = new NormalUser() { FullName = "Botirov Zokin"};
            IUser premiumUser = new PremiumUser() { FullName = "Asadov Alesher" };

            normalUser.Card = FillingCard();
            premiumUser.Card = FillingCard();

            decimal normalUserFinalPrice = normalUser.Card.GetFinalPrice(normalUser.GetPriseDiscountForUser, CalculateTotalProductPrice, PrintTotalDiscountAmount);
            Console.WriteLine($">{normalUser.FullName} payment: ${normalUserFinalPrice}");
            Console.WriteLine();

            decimal premiumlUserFinalPrice = premiumUser.Card.GetFinalPrice(premiumUser.GetPriseDiscountForUser, CalculateTotalProductPrice, PrintTotalDiscountAmount);
            Console.WriteLine($">{premiumUser.FullName} payment: ${premiumlUserFinalPrice}");
        }
    }
}
