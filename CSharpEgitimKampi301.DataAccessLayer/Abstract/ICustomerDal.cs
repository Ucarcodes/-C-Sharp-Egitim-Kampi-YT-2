using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface ICustomerDal: IGenericDal<Customer>
    //IGenericDal'dan, Customer Classı için miras alındı.
    //Customer sınıfı için, IGenericDal'daki, Eklleme, Güncelleme, Silme, ID'ye göre getirme gibi özellikler aktif oldu.
    {

    }
}
