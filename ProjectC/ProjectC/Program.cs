using Confluent.Kafka;
using Shared.Database.ClickHouse;
using System.Text;
using System.Text.Json;
using System.Threading;

namespace ProjectC;

//[Table("main_messages")]
public class Program
{
    //public static List<int> ints = new List<int>() {1,2,3,4,5,8,6,7,3 };
    //public static void Main(string[] args)
    //{
    //    //Console.WriteLine("Start Main!");
    //    //Method1((a) => a <4);
    //    //Console.WriteLine("Method Main!");
    //    //Method1((a) => a >= 4);
    //    //Console.WriteLine("End Main!");
    //    //Console.WriteLine("Hello, World!");
    //    //var str = "jfhkdjfg";
    //    //Console.WriteLine(str.RemoveModTwo());

    //    //var storage = new MemoryStorage();
    //    //storage.SetValue("SERVER_ADDRESS", "localhost:8080");
    //    //Console.WriteLine(storage.GetValue("SERVER_ADDRESS"));
    //    //SellerPanel(storage);
    //    //UserPanel(storage);
    //    //AdminPanel(storage);
    //    //storage.CreateNewStorage(); //метод добавлен извне

    //    //var repository = new EntityRepository<User>();
    //    //repository.Create(new User());
    //    //repository.Create(new Admin());

    //    //var array = new List<string> { "a", "b", "c" };
    //    //var newArray = new string[array.Count + 1];
    //    //for (int i = 0; i < array.Count; i++) 
    //    //{ 
    //    //newArray[i] = array[i];

    //    //}
    //    //newArray[^1] = "d";
    //    //array = newArray;
    //    //array.Add("d");
    //    //array.Insert(1, "e");
    //    //array.Remove("e");
    //    //array.RemoveAt(0);
    //    //foreach (var item in array)
    //    //{ 
    //    //    Console.WriteLine($"{item}");
    //    //}
    //    //Method2(() => 
    //    //{
    //    //    Console.ForegroundColor = ConsoleColor.Green;
    //    //    Console.WriteLine("Error");
    //    //});

    //    //var car = new Car((mes) =>
    //    //{
    //    //    Console.WriteLine("Отправка данных_____________");
    //    //    Console.ForegroundColor = ConsoleColor.Yellow;
    //    //    Console.WriteLine(mes);
    //    //    Console.ForegroundColor = ConsoleColor.Green;
    //    //    Console.WriteLine("Отправка данных_____________");
    //    //});
    //    //car.Move(10);
    //    //car.Move(110);
    //    //car.Move(120);
    //    //car.Move(10);


    //}
    //public static void Method1(Predicate<int> func)
    //{
    //    foreach (var item in ints)
    //    {
    //        if (func(item))
    //        {
    //            Console.WriteLine(item);
    //        }        
    //    }
    //}
    //public static void Method2(Action func)
    //{
    //    Console.WriteLine("Start work!");
    //    Console.WriteLine("Error");
    //    func();
    //}

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


    //public class Car
    //{ 
    //    private Action<string> _signal;

    //    public Car(Action<string> signal)
    //    {
    //        _signal = signal;
    //    }
    //    public void Move(int distance)
    //    {
    //        Console.WriteLine($"Start move {distance}!");
    //        if (distance > 100)
    //        {
    //            _signal.Invoke("Нужна заправка");
    //        }
    //        Console.WriteLine($"End move {distance}!");
    //    }
    //}

    //public static async Task  Main(string[] args)
    //{
    //    ////Task - задача
    //    ////Thread - поток
    //    ////var thread = new Task<int>(() => Method1(1));
    //    ////thread.Start();
    //    ////Task thread1 = new Task(() => Method1(2));
    //    ////thread1.Start();
    //    //////Method1(0);
    //    //////thread.Wait();
    //    ////Console.WriteLine(thread.Result);
    //    ////thread1.Wait();
    //    //Console.WriteLine("Start");
    //    //var s1 = Method1(1);      
    //    //var s2 = Method1(2);       
    //    //var s3 = Method1(3);      
    //    //var s4 = Method1(4);

    //    //for (int i = 0; i < 10; i++)
    //    //{
    //    //   Console.WriteLine(i+1);
    //    //}
    //    //Console.WriteLine(await s1);
    //    //Console.WriteLine(await s2);
    //    //Console.WriteLine(await s3);
    //    //Console.WriteLine(await s4);
    //    //Console.WriteLine("Finish");
    //    var ts = new CancellationTokenSource(TimeSpan.FromMinutes(1));
    //    var token = ts.Token;

    //    var ar = Method1();
    //    Console.WriteLine(ar);
    //    var b = Method2Async(ar);

    //    var cr = Method3();
    //    Console.WriteLine(cr);

    //    var br = await b;
    //    Console.WriteLine(br);
    //    var dr = Method4(br, cr);
    //    Console.WriteLine(dr);


    //}
    //public static string Method1()
    //{
    //    //for (int i = 0; i < 10; i++)
    //    //{ 
    //    //    Thread.Sleep(1000);
    //    //    Console.WriteLine($"{number} - {i+1}");
    //    //}
    //    //Thread.Sleep(1000);
    //    Thread.Sleep(2000);
    //    return  $"Неготовое тесто.";

    //}
    //public static async Task<string> Method2Async(string str)
    //{        
    //    await Task.Delay(1000);
    //    return $"Тесто из {str}";

    //}
    //public static string Method3()
    //{
    //    Thread.Sleep(2000);
    //    return $"Фарш";

    //}
    //public static string Method4(string str, string str2)
    //{
    //    Thread.Sleep(2000);
    //    return $"Пельмени = {str} + {str2}";

    //}
    //    public static void Main(string[] args)
    //    {
    //        //var producerConfig = new ProducerConfig()
    //        //{
    //        //    BootstrapServers = "localhost:9092",
    //        //    ClientId = "Main-Client",

    //        //};

    //        //var producer = new ProducerBuilder<string, MyMessage>(producerConfig)
    //        //    .SetValueSerializer(new MyJsonSerializer())
    //        //    .Build();

    //        //var kafkaMessage = new Message<string, MyMessage>()
    //        //{
    //        //    Key = Guid.NewGuid().ToString(),
    //        //    Value = new MyMessage()
    //        //    {
    //        //        Id = 1,
    //        //        Name = "aaaa",
    //        //        Value = "11111"
    //        //    }
    //        //};

    //        //producer.Produce("first_topic", kafkaMessage);
    //        //Console.WriteLine("producer.ToString()");
    //        //Console.ReadLine();
    //        var consumerConfig = new ConsumerConfig()
    //        {
    //            BootstrapServers = "localhost:9092",
    //            GroupId = "main-consumer",
    //            AutoOffsetReset = AutoOffsetReset.Earliest,
    //        };

    //        var consumer = new ConsumerBuilder<string, MyMessage>(consumerConfig)
    //            .SetValueDeserializer(new MyJsonSerializer())
    //            .Build();

    //        consumer.Subscribe("first_topic");

    //        while (true)
    //        {
    //            try
    //            {
    //                var mes = consumer.Consume();
    //                Console.WriteLine($"{mes.Message.Key} {mes.Message.Value.Id} {mes.Message.Value.Name}");
    //            }

    //            catch(Exception e)
    //            {
    //                Console.WriteLine(e);
    //            }
    //        }
    //    }
    //    public class MyMessage
    //    {
    //        public int Id { get; set; }
    //        public string Name { get; set; }
    //        public string Value { get; set; }
    //    }

    //    public class MyJsonSerializer : ISerializer<MyMessage>, IDeserializer<MyMessage>
    //    {
    //        public MyMessage Deserialize(ReadOnlySpan<byte> data, bool isNull, SerializationContext context)
    //        {
    //            return (MyMessage)JsonSerializer.Deserialize(data, typeof (MyMessage));
    //        }

    //        public byte[] Serialize(MyMessage data, SerializationContext context)
    //        {
    //            return JsonSerializer.SerializeToUtf8Bytes(data);
    //        }

    //    }

    public static async Task Main(string[] args)
    {
        var connector = new ClickHouseConnector();
        var res = await connector.ReadData(1);

        foreach (var item in res)
        {
            Console.WriteLine($"{item.UserId} - {item.KeyName} - {item.KeyCode}");

            //await connector.WriteData(new UserClicksClickHouseData[] 
            //{
            //    new UserClicksClickHouseData() { UserId = 1, KeyName = "first_login_key", KeyCode = null },
            //    new UserClicksClickHouseData() { UserId = 2, KeyName = "first_login_key", KeyCode = 5 },
            //    new UserClicksClickHouseData() { UserId = 1, KeyName = "second_login_key", KeyCode = 2 },
            //    new UserClicksClickHouseData() { UserId = 2, KeyName = "first_login_key", KeyCode = null },
            //    new UserClicksClickHouseData() { UserId = 1, KeyName = "logout", KeyCode = 5 },
            //    new UserClicksClickHouseData() { UserId = 2, KeyName = "first_login_key", KeyCode = null },
            //    new UserClicksClickHouseData() { UserId = 1, KeyName = "second_login_key", KeyCode = 5 },
            //    new UserClicksClickHouseData() { UserId = 2, KeyName = "first_login_key", KeyCode = null },
            //    new UserClicksClickHouseData() { UserId = 1, KeyName = "first_login_key", KeyCode = null },
            //    new UserClicksClickHouseData() { UserId = 1, KeyName = "get_version", KeyCode = null },

            //});
        }
    }
}