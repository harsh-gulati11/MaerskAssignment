using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductFactory factory = new ConcreteProductFactory();

            IProductFactory Product = factory.GetProductDetail("A");
            List<IProductFactory> lstOfProduct = new List<IProductFactory>();

            lstOfProduct.Add(Product);

            Product = factory.GetProductDetail("B");
            lstOfProduct.Add(Product);

            Product = factory.GetProductDetail("C");
            lstOfProduct.Add(Product);

            Product = factory.GetProductDetail("D");
            lstOfProduct.Add(Product);


            Order obj = new Order();
            obj.CreateOrders(lstOfProduct);

            Console.Read();






        }


    }
}
