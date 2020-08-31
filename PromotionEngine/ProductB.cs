using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class ProductB : IProductFactory
    {
        public string Id { get; set; }
        public decimal Price { get; set; }
        public Promotion ProductPromotion { get; set; }
        public ProductB()
        {
            this.Price = 30m;
            this.Id = "B";
            this.ProductPromotion = GetPromotionDetails();
        }
    

        public Promotion GetPromotionDetails()
        {
            Dictionary<String, int> d1 = new Dictionary<String, int>();
            d1.Add("B", 2);
            Promotion activePromo = new Promotion(1, d1, 45);
            return activePromo;
        }
    }
}
