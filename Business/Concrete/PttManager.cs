using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService; // field --> alt çizgi ile yazılır.

        // sırf constructor da ulaşabilmek adına global alanda bir değişken tanımladık.

        public PttManager(IApplicantService applicantService)             // constructor ---> oluşturucu.    pttmanager new'lendiğinde bu blok önce çalışır.
        {
            _applicantService = applicantService;
        }


        public void GiveMask(Person person)  // pttnin  maskeyi verebilmesi için kişiyi kontrol etmesi lazım. Yani pttmanager in personmanager e ihtiyacı var
        {
            
            

            if(_applicantService.CheckPerson(person))
            { 

                Console.WriteLine(person.FirstName + "için maske verildi.");
            }
            else
            {
                Console.WriteLine("MASKE VERİLEMEZ.");
            }

        }

    }
}




// eğer bir iş sınıfı başka bir iş sınıfını kullanırken onu new'liyorsa bu uygulama değişiklik yapılacağında direnç gösterir.
// şu anda PersonManager'a bağımlı olduk. Yabancı vatandaşlar maske istediğinde sistem patlar..

