using System.Buffers.Binary;
using System.IO.Pipes;
using System.Net.WebSockets;
using sda_onsite_2_csharp_library_management.src;

internal class Program
{
    private static void Main()
    {
        var user1 = new User("Alice", new DateTime(2023, 1, 1));
        var user2 = new User("Bob");

        var book1 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));
        var book2 = new Book("1984", new DateTime(2023, 2, 1));

        Console.WriteLine(user1.ToString());
        Console.WriteLine("-------------------------------");
        Console.WriteLine(user2.ToString());
        Console.WriteLine("-------------------------------");
        Console.WriteLine(book1.ToString());
        Console.WriteLine("-------------------------------");
        Console.WriteLine(book2.ToString());
        



    }




}

