namespace ProjectC;

//[Table("main_messages")]
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var storage = new DatabaseStorage();
        storage.SetValue("SERVER_ADDRESS", "localhost:8080");
        Console.WriteLine(storage.GetValue("SERVER_ADDRESS"));
        SellerPanel(storage);
        UserPanel(storage);
        AdminPanel(storage);
    }

    public static void UserPanel(DatabaseStorage storage)
    {
        Console.WriteLine(storage.GetValue("PRODUCT_ID"));

    }
    public static void AdminPanel(DatabaseStorage storage)
    {
        Console.WriteLine(storage.GetValue("SERVER_ADDRESS"));
    }
    public static void SellerPanel(DatabaseStorage storage)
    {
        storage.SetValue("PRODUCT_ID", "123456");
        Console.WriteLine(storage.GetValue("PRODUCT_ID"));
    }

}
