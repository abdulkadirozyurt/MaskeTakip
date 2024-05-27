using Business.Concrete;
using Entities.Concrete;
using System.Collections;






Person person1 = new Person();
person1.FirstName = "Abdulkadir";
person1.LastName = "Özyurt";
person1.NationalIdentity = 1111111111;
person1.DateOfBirthYear = 2001;


PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);





















Console.WriteLine("**************************************************************************************");
Console.WriteLine();
Console.WriteLine();



MyList<string> brandList = new MyList<string>();

brandList.Add("Nike");
Console.WriteLine();
brandList.Add("adidas");

foreach (var brand in brandList)
{
    Console.WriteLine(brand);
}


public class MyList<T> : IEnumerable<T>
{
    private T[] _items;
    private int _count;

    public MyList()
    {
        _items = new T[0];
        _count = 0; // collection içindeki eleman sayısı
    }

    // property
    public int Count => _count;

    // method
    public int Count2()
    {
        return _count;
    }

    public void Add(T item)
    {
        Console.WriteLine("Önceki count: " + _count);
        if (_count == _items.Length)
        {
            // resizing
            int newSize = _items.Length == 0 ? 4 : _items.Length * 2; // Başlangıç kapasitesini artırıyoruz
            T[] newArray = new T[newSize];
            Array.Copy(_items, newArray, _items.Length);
            _items = newArray;
        }

        _items[_count++] = item;
        Console.WriteLine("Sonraki count: " + _count);
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < _count; i++)
        {
            yield return _items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}













