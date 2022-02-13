using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService // iş sınıflarının interface'leri genelde böyle isimlendirilir.
        
              
        
        // interface içerisinde sadece metot imzası oluşturulabilir. başına public yazsak kızar.
    
    
    {
        void ApplyForMask(Person person);



        List<Person> GetList(); 

        

        bool CheckPerson(Person person);
        
        

    }
}
