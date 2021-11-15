namespace Pr9.Models
{
    abstract class Client
    {
        protected string _address;
        protected bool _status;
        protected Cart _cart;

        public Client(string address, bool status, Cart cart)
        {
            _address = address;
            _status = status;
            _cart = cart;
        }

        public void ViewProducts(Shop shop)
        {
            //shop.DisplayProducts(shop.storage)
        }

        public void FillCart()
        {
            //shop.storage.AddProduct();
        }

        public Receipt MakePurchase()
        {
            var receipt = new Receipt();

            ChooseDeliveryMethod();
            return receipt;
        }

        public void ChooseDeliveryMethod()
        {
            
        }
    }
}