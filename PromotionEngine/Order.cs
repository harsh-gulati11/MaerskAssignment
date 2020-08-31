using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class Order
    {
        private int OrderID { get; set; }
        public List<Products> LstProducts { get; set; }

        public Order() { }
        public Order(int _oid, List<Products> _prods)
        {
            this.OrderID = _oid;
            this.LstProducts = _prods;
        }


        public void CreateOrders(List<IProductFactory> lstOfProduct)
        {
            List<Order> lstOrders = new List<Order>();
            if (lstOfProduct != null)
            {
                Order order1 = new Order(1, new List<Products>() { new Products("A", lstOfProduct), new Products("B", lstOfProduct), new Products("C", lstOfProduct) }); //Scenario 1

                //Scenario 2-  5 A, 5 b , 1 C
                Order order2 = new Order(2, new List<Products>() { new Products("A",lstOfProduct),
                                                               new Products("A",lstOfProduct),
                                                               new Products("A",lstOfProduct),
                                                               new Products("A",lstOfProduct),
                                                               new Products("A",lstOfProduct),
                                                               new Products("B",lstOfProduct),
                                                               new Products("B",lstOfProduct),
                                                               new Products("B",lstOfProduct),
                                                               new Products("B",lstOfProduct),
                                                               new Products("B",lstOfProduct),
                                                               new Products("C",lstOfProduct)});

                //Scenario 3- 3 A , 5 B , 1 C, 1 D

                Order order3 = new Order(3, new List<Products>() { new Products("A",lstOfProduct),
                                                               new Products("A",lstOfProduct),
                                                               new Products("A",lstOfProduct),

                                                               new Products("B",lstOfProduct),
                                                               new Products("B",lstOfProduct),
                                                               new Products("B",lstOfProduct),
                                                               new Products("B",lstOfProduct),
                                                               new Products("B",lstOfProduct),
                                                               new Products("C",lstOfProduct) , new Products("D",lstOfProduct)});


                lstOrders.AddRange(new Order[] { order1, order2, order3 });


                List<Promotion> lstActivePromos = lstOfProduct.Select(x => x.ProductPromotion).ToList().Where(item => item != null).ToList();

                CalculatiPricing(lstOrders, lstActivePromos);

            }

        }

        private void CalculatiPricing(List<Order> lstOrders, List<Promotion> lstActivePromos)
        {
            decimal finalPrice;
            decimal totalOfFinalPrice = 0;
            decimal totalOfRebate = 0;
            decimal totalOrigPrice = 0;



            foreach (Order ord in lstOrders)
            {
                List<decimal> promoprices = lstActivePromos
                   .Select(promo => CalculateRebates.GetTotalPrice(ord, promo))
                   .ToList();
                decimal origprice = ord.LstProducts.Sum(x => x.ProdPerUnitPrice);
                decimal promoprice = promoprices.Sum();
                finalPrice = origprice - promoprice;
                totalOfFinalPrice += finalPrice;
                totalOrigPrice += Convert.ToDecimal(origprice.ToString("0.00"));
                totalOfRebate += promoprice;
                Console.WriteLine($"OrderID: {ord.OrderID} => Original price: {origprice.ToString("0.00")} | Rebate: {promoprice.ToString("0.00")} | Final price for Order {ord.OrderID}: {(finalPrice).ToString("0.00")}");

            }
            Console.WriteLine("========================================");
            Console.WriteLine($"Total Price Before Rebate:- {totalOrigPrice.ToString("0.00")}");
            Console.WriteLine($"Total Rebate :- {totalOfRebate.ToString("0.00")}");
            Console.WriteLine($"Total Final Price:- {totalOfFinalPrice.ToString("0.00")}");
        }
    }
}
