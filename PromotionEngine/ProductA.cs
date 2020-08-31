using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class ProductA : IProductFactory
    {
        public string Id { get; set; }
        public decimal Price { get; set; }
        public Promotion ProductPromotion { get; set; }

        public ProductA()
        {
            this.Price = 50m;
            this.Id = "A";
            this.ProductPromotion = GetPromotionDetails();
        }

        public Promotion GetPromotionDetails()
        {
            Dictionary<String, int> d1 = new Dictionary<String, int>();
            d1.Add("A", 3);
            Promotion activePromo = new Promotion(1, d1, 130);
            return activePromo;
        }

        //public void GetProductsDetails(string Id)
        //{
        //    this.Price = 50m;
        //    this.Id = "A";
        //    this.ProductPromotion = GetPromotionDetails();
        //}
    }

}

