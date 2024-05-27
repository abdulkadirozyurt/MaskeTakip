using Entities.Concrete;
using System.Collections;






//string[] students = new string[3];

//students[0] = "Engin";
//students[1] = "Abdulkadir";
//students[2] = "Hasan";

//students = new string[4];
//students[3] = "Emirhan";

//for (int i = 0; i < students.Length; i++)
//{
//    Console.WriteLine(students[i]);
//    Console.WriteLine();
//}


//string[] cities1 = new[] { "Ankara", "İstanbul", "İzmir" };
//string[] cities2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

//cities2 = cities1;
//cities1[0] = "Adana";

//foreach (var item in cities2)
//{
//    Console.WriteLine(item);
//}

//// object instantaation
//Person person = new() { FirstName = "Abdulkadir" };












List<string> cities3 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };

cities3.Add("İzmir1");








Console.WriteLine("****************");




























MyList<string> brandList = new MyList<string>();

brandList.Add("Nike");
Console.WriteLine(  );
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













