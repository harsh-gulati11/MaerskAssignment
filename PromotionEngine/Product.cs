using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class Products
    {


        public Products(string _Id, List<IProductFactory> _lstOfProduct)
        {
            this.ProdId = _Id;
            this.ProdPerUnitPrice = _lstOfProduct.Find(x => x.Id == _Id).Price;
        }

        public string ProdId { get; set; }
        public decimal ProdPerUnitPrice { get; set; }
    }
}
