using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{

    // çıplak class kalmasın.


    public class PersonManager : IApplicantService

    {
        public void ApplyForMask(Person person) // maske için başvur. kim. Person class ında person kişisi.
        {
            // bu yapıya birçok programlama dilinde metot, fonksiyon, prosedür gibi isimler veririz.
            // c# ta yoğun olarak metot kullanılır.







        }


        public List<Person> GetList() // List of Person
        {






            return null;                         // null: tanımlanmamış demek
        }

        public bool CheckPerson(Person person) // person validation yapacak. Mernisten kişiyi kontrol edecek
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, Ad: person.FirstName, Soyad: person.LastName, person.DateOfBirthYear)))
              .Result.Body.TCKimlikNoDogrulaResult;
        }









    }
}
