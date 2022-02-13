using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{

    // hem ptt maske verecek hem de eczane verecek. Sistemimiz ptt ye göre yapıldı. Eczaneye göre de uyumluluk gerekiyor. Sistem patladı. Toparlıyoruz.

    public interface ISupplierService   // Supplier ---> Dağıtıcı, tedarikçi
    {
        void GiveMask(Person person);
    }
}
