using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public static class CalculateRebates
    {
        public static decimal GetTotalPrice(Order ord, Promotion prom)
        {
            decimal d = 0M;
            //get count of promoted products in order
            //Grouping by ID ( A, B, C, D) if id found , Then comparing the number of quantity in where clause
            //If quantity (Value) is more then count, applying sum on the rule

            var copp = ord.LstProducts
                .GroupBy(x => x.ProdId)
                .Where(grp => prom.ProductInfo.Any(y => grp.Key == y.Key && grp.Count() >= y.Value))
                .Select(grp => grp.Count())
                .Sum();
            //get count of promoted products from promotion
            int ppc = prom.ProductInfo.Sum(kvp => kvp.Value);
            while (copp >= ppc)
            {
                d += prom.PromoPrice;
                copp -= ppc;
            }
            return d;
        }
    }
}
