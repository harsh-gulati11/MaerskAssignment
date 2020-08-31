using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class ProductD : IProductFactory
    {
        public string Id { get; set; }
        public decimal Price { get; set; }
        public Promotion ProductPromotion { get; set; }

        public ProductD()
        {
            this.Price = 15m;
            this.Id = "D";
            this.ProductPromotion = null;
        }

        public Promotion GetPromotionDetails()
        {
            Dictionary<String, int> d1 = new Dictionary<String, int>();
            d1.Add("D", 1);
            Promotion activePromo = new Promotion();
            return activePromo;
        }



    }
}

