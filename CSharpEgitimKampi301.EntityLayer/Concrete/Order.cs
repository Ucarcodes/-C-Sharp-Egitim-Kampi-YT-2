using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; } //Order sınıfı ile Product sınıfını ilişkilendirdik.
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalePrice { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; } //Order sınıfı ile Customer sınıfını ilişkilendirdik.


    }
}
