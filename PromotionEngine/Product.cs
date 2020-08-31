using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class Products
    {


        public Products(string v, List<IProductFactory> lstOfProduct)
        {
            this.ProdId = v;
            this.ProdPerUnitPrice = lstOfProduct.Find(x => x.Id == v).Price;
        }

        public string ProdId { get; set; }
        public decimal ProdPerUnitPrice { get; set; }
    }
}
