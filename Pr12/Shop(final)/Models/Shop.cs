using System.Collections.Generic;

namespace Pr9.Models
{
    class Shop
    {
        private Authorised[] _authorisedClients;
        private UnAuthorised[] _unAuthorisedClients;
        private Storage _storage;

        //public Storage Storage
        //{
        //    get => _storage;
        //    set => _storage = value;
        //}

        public Shop(Authorised[] authorisedClients, UnAuthorised[] unAuthorisedClients, Storage storage)
        {
            _authorisedClients = authorisedClients;
            _unAuthorisedClients = unAuthorisedClients;
            _storage = storage;
        }

        public void DisplayProducts(List<int> productsIDs)
        {
            //Storage.DisplayProducts(productsIDs);
        }

        public void ManagePersonalCabinets()
        {

        }

        public void RemoveProductsIDs()
        {
            // list<productID> = authorised.cart + unauthrised.cart 
            //Storage.RemoveProducts(list<productID>);
        }

        public void DeleteProduct()
        {
            // when purchase is made delete products with productsIDs that is in receipt
            // Storage.Delete(list<productID>)
        }
    }
}
