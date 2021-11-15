using System;

namespace Pr9.Models
{
    class Receipt
    {
        private int _ID;
        private DateTime _purchaseDate;

        public Receipt(int ID = 0, DateTime purchaseDate = new DateTime())
        {
            _ID = ID;
            _purchaseDate = purchaseDate;
        }
    }
}


















//    public interface ICheck
//    {
//        string ShowInfo();
//    }

//    sealed class Receipt: ICheck
//    {
//        public string ShowInfo()
//        {
//            try
//            {
//                Console.WriteLine("Enter the name of a product: ");
//                var name = Console.ReadLine();
//                Console.WriteLine("Enter the number of products: ");
//                var num = int.Parse(Console.ReadLine());
//                Console.WriteLine("Enter its price: ");
//                var price = double.Parse(Console.ReadLine());
//                Console.WriteLine("Enter its weight: ");
//                var weight = double.Parse(Console.ReadLine());

//                var productsToBuy = new Product[num];

//                for (var i = 0; i < num; i++)
//                {
//                    productsToBuy[i] = new Product(name, price, weight);
//                }

//                var buy = new Buy(productsToBuy, num, price, weight);
//                return "Your purchase contains: \nName " + name + "\nTotal price " + buy.Cost + "\nTotal weight " + buy.Weight + '\n';

//            } catch (FormatException)
//            {
//                Console.WriteLine("Incorrect format.\n");
//                return "";
//            }
//        }
//    }
//    public abstract class CheckWithFieldDecorator : ICheck
//    {
//        protected ICheck _check;

//        public abstract string ShowInfo();

//        protected CheckWithFieldDecorator(ICheck iCheck)
//        {
//            _check = iCheck;
//        }
//    }

//    public class CheckWithFields : CheckWithFieldDecorator
//    {
//        public CheckWithFields(ICheck iCheck) : base(iCheck)
//        {
//        }

//        public override string ShowInfo()
//        {
//            Console.WriteLine("Enter the name of a product: ");
//            var name = Console.ReadLine();
//            Console.WriteLine("Enter the number of products: ");
//            var num = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter its price: ");
//            var price = double.Parse(Console.ReadLine());
//            Console.WriteLine("Enter its weight: ");
//            var weight = double.Parse(Console.ReadLine());

//            var productsToBuy = new Product[num];

//            for (var i = 0; i < num; i++)
//            {
//                productsToBuy[i] = new Product(name, price, weight);
//            }

//            var buy = new Buy(productsToBuy, num, price, weight);
//            return "Your purchase contains: \nName " + name + "\nTotal price " + buy.Cost + "\nTotal weight " + buy.Weight + '\n';
//        }
//    }

////class Test : Check
////{

////}