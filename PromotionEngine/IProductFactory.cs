using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public interface IProductFactory
    {
        string Id { get; set; }
        decimal Price { get; set; }
        Promotion ProductPromotion { get; set; }

    }
}
