using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class ProductC : IProductFactory
    {
        public string Id { get; set; }
        public decimal Price { get; set; }
        public Promotion ProductPromotion { get; set; }

        public ProductC()
        {
            this.Price = 20m;
            this.Id = "C";
            this.ProductPromotion = GetPromotionDetails();
        }

        public Promotion GetPromotionDetails()
        {
            Dictionary<String, int> d1 = new Dictionary<String, int>();
            d1.Add("C", 1);
            Promotion activePromo = new Promotion(3, d1, 30);
            return activePromo;
        }

       
    }

}

