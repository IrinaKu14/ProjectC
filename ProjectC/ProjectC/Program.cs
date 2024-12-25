using System.Text;

namespace ProjectC;

//[Table("main_messages")]
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var str = "jfhkdjfg";
        Console.WriteLine(str.RemoveModTwo());

        var storage = new MemoryStorage();
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


    }

    public static void UserPanel(IStorage storage)
    {
        //var stor = storage as MemoryStorage;
        //if (stor != null)
        //{
        //    stor.SetString();
        //}
        Console.WriteLine(storage.GetValue("PRODUCT_ID"));

    }
    public static void AdminPanel(IStorage storage)
    {
        Console.WriteLine(storage.GetValue("SERVER_ADDRESS"));
    }
    public static void SellerPanel(IStorage storage)
    {
        storage.SetValue("PRODUCT_ID", "123456");
        Console.WriteLine(storage.GetValue("PRODUCT_ID"));
    }

    

}
public static class StringExtension
{
    public static string RemoveModTwo(this string str)
    {
        
        StringBuilder res = new StringBuilder(); //использовать при частом измении строки, что бы не нагружать систему
        //string res = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (i % 2 == 0)
            { 
            res.Append(str[i]); //Добавляет в строку
            }
        }
        return res.ToString();
    }
}
