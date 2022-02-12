using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;

namespace Business.Concrete
{
    public class PttManager
    {

        private IApplicantService _applicantService;

        public PttManager()   // constructor ---> oluşturucu    pttmanager new'lendiğinde bu blok önce çalışır.
        {

        }


        public void GiveMask(Person person)  // pttnin  maskeyi verebilmesi için kişiyi kontrol etmesi lazım. Yani pttmanager in personmanager e ihtiyacı var
        {
            
            


            if(personManager.CheckPerson(person)) // if bloğu şart bloğudur. şart  doğruysa o bloğa girer.
            {
                Console.WriteLine(person.FirstName + "için maske verildi.");
            }

        }

    }
}




// şu anda PersonManager'a bağımlı olduk. Yabancı vatandaşlar maske istediğinde sistem patlar.

