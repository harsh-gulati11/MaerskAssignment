using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public abstract class ProductFactory
    {
        public abstract IProductFactory GetProductDetail(string ProdID);
    }
}
