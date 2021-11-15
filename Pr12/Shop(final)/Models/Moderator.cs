namespace Pr9.Models
{
    class Moderator: User
    {
        private string _password;

        public Moderator(string password)
        {
            _password = password;
        }

        public void LogIn()
        {

        }

        public void LogOut()
        {

        }

        public void SetSale(Product product)
        {
            //product.ChangePrice()
        }

        public void SetSale(Shop shop)
        {
            //shop.authorised
        }

        public void ViewPurchasesMade(Shop shop)
        {
            // loop: shop.authorised.makePurchase + shop.unauthorised.makePurchase
        }

        public void RemoveSale(Product product)
        {

        }

        public void RemoveSale(Shop shop)
        {
            //shop.authorised
        }

        public void RemoveAllSales()
        {

        }
    }
}
