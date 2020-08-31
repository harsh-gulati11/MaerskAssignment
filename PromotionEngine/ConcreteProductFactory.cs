using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class ConcreteProductFactory : ProductFactory
    {
        public override IProductFactory GetProductDetail(string ProdID)
        {
            switch (ProdID)
            {
                case "A":
                    {
                        return new ProductA();

                    }
                case "B":
                    {
                        return new ProductB();

                    }
                case "C":
                    {
                        return new ProductC();

                    }
                case "D":
                    {
                        return new ProductD();

                    }
                default:
                    throw new ApplicationException(string.Format("Product '{0}' cannot be created", ProdID));
            }

        }
    }
}
