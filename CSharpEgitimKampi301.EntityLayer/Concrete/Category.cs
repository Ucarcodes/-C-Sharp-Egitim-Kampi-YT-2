using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        //Code First yaklaşımı

        public int CategoryId { get; set; } //Id'nin otomatik artan olması için, ClassAdi+Id şeklinde tanımlanmalıdır. Büyük küçük karakter uyumu önemlidir.
        public string CategoryName { get; set; }

        public bool CategoryStatus { get; set; }

        public List<Product> Products { get; set; } //Category sınıfını, Product sınıfından haberdar ettik.


    }
}
