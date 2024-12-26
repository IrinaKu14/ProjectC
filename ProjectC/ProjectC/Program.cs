using System.Text;

namespace ProjectC;

//[Table("main_messages")]
public class Program
{
    public static List<int> ints = new List<int>() {1,2,3,4,5,8,6,7,3 };
    public static void Main(string[] args)
    {
        //Console.WriteLine("Start Main!");
        //Method1((a) => a <4);
        //Console.WriteLine("Method Main!");
        //Method1((a) => a >= 4);
        //Console.WriteLine("End Main!");
        //Console.WriteLine("Hello, World!");
        //var str = "jfhkdjfg";
        //Console.WriteLine(str.RemoveModTwo());

        //var storage = new MemoryStorage();
        //storage.SetValue("SERVER_ADDRESS", "localhost:8080");
        //Console.WriteLine(storage.GetValue("SERVER_ADDRESS"));
        //SellerPanel(storage);
        //UserPanel(storage);
        //AdminPanel(storage);
        //storage.CreateNewStorage(); //метод добавлен извне

        //var repository = new EntityRepository<User>();
        //repository.Create(new User());
        //repository.Create(new Admin());

        //var array = new List<string> { "a", "b", "c" };
        //var newArray = new string[array.Count + 1];
        //for (int i = 0; i < array.Count; i++) 
        //{ 
        //newArray[i] = array[i];

        //}
        //newArray[^1] = "d";
        //array = newArray;
        //array.Add("d");
        //array.Insert(1, "e");
        //array.Remove("e");
        //array.RemoveAt(0);
        //foreach (var item in array)
        //{ 
        //    Console.WriteLine($"{item}");
        //}
        //Method2(() => 
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine("Error");
        //});

        var car = new Car((mes) =>
        {
            Console.WriteLine("Отправка данных_____________");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(mes);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Отправка данных_____________");
        });
        car.Move(10);
        car.Move(110);
        car.Move(120);
        car.Move(10);

    }
    public static void Method1(Predicate<int> func)
    {
        foreach (var item in ints)
        {
            if (func(item))
            {
                Console.WriteLine(item);
            }        
        }
    }
    public static void Method2(Action func)
    {
        Console.WriteLine("Start work!");
        Console.WriteLine("Error");
        func();
    }

    //public static bool Sort1(int a)
    //{
    //    return a < 4;
    //}
    //public static bool Sort2(int a)
    //{
    //    return a >= 4;
    //}

    //    public static void UserPanel(IStorage storage)
    //    {
    //        //var stor = storage as MemoryStorage;
    //        //if (stor != null)
    //        //{
    //        //    stor.SetString();
    //        //}
    //        Console.WriteLine(storage.GetValue("PRODUCT_ID"));

    //    }
    //    public static void AdminPanel(IStorage storage)
    //    {
    //        Console.WriteLine(storage.GetValue("SERVER_ADDRESS"));
    //    }
    //    public static void SellerPanel(IStorage storage)
    //    {
    //        storage.SetValue("PRODUCT_ID", "123456");
    //        Console.WriteLine(storage.GetValue("PRODUCT_ID"));
    //    }



    //}
    //public static class StringExtension
    //{
    //    public static string RemoveModTwo(this string str)
    //    {

    //        StringBuilder res = new StringBuilder(); //использовать при частом измении строки, что бы не нагружать систему
    //        //string res = "";
    //        for (int i = 0; i < str.Length; i++)
    //        {
    //            if (i % 2 == 0)
    //            { 
    //            res.Append(str[i]); //Добавляет в строку
    //            }
    //        }
    //        return res.ToString();
    //    }

    //Размотка стека
    //public static void Method1()
    //{
    //    //Console.WriteLine("Start Method1!");
    //    //try
    //    //{
    //    //    Method2();
    //    //}
    //    //catch(DatabaseException e)
    //    //{
    //    //    Console.WriteLine($"Error: {e.Message}!");
    //    //}
    //    //catch (Exception e)
    //    //{
    //    //    Console.WriteLine($"Unknown exception!!!");
    //    //}

    //    //Console.WriteLine("End Method1!");
    //}


    //public static void Method2()
    //{
    //    //Console.WriteLine("Start Method2!");
    //    //Method3();
    //    //Console.WriteLine("End Method2!");
    //}


    /// <summary>
    /// 
    /// </summary>
    /// <exception cref="DatabaseException"></exception>
    /// <exception cref="Exception"></exception>
    //    public static void Method3()
    //    {
    //        Console.WriteLine("Start Method3!");
    //        int a = 3;
    //        if (a == 0)
    //        {
    //          throw new DatabaseException("Error connect to database");/* Error*/
    //        }
    //        if (a == 1)
    //        {
    //            throw new Exception("Unknown exception");
    //        }
    //        Console.WriteLine("End Method3!");

    //    }
    //}

    //public class DatabaseException : Exception
    //{
    //    public DatabaseException(string message) : base(message)
    //    { 

    //    }

}
public class Car
{ 
    private Action<string> _signal;

    public Car(Action<string> signal)
    {
        _signal = signal;
    }
    public void Move(int distance)
    {
        Console.WriteLine($"Start move {distance}!");
        if (distance > 100)
        {
            _signal.Invoke("Нужна заправка");
        }
        Console.WriteLine($"End move {distance}!");
    }
}
