namespace Pr9.Models
{
    class Administrator: User
    {
        private string _password;

        //public string Password
        //{
        //    get => _password;
        //    set => _password = value;
        //}

        public Administrator(string password)
        {
            _password = password;
        }

        public void LogIn()
        {

        }

        public void LogOut()
        {

        }

        public void AddProduct(Storage storage, Product product)
        {
            storage.Add(product);
        }

        public void RemoveProduct(Storage storage, Product product)
        {
            //storage.Remove(product); override this in storage
        }

        public void RemoveProductByName(Storage storage, string name)
        {
            //storage.Remove(name);
        }

        public void RemoveProductByPrice(Storage storage, double price)
        {
            //storage.RemoveByPrice(price); override this in storage
        }

        public void RemoveProductByWeight(Storage storage, double weight)
        {
            //storage.RemoveByWeight(weight); override this in storage
        }

        public void RemoveExpiredProducts(Storage storage)
        {
            storage.RemoveExpiredProducts();
        }

        public void SetStatus(Shop shop)
        {

        }

    }
}
