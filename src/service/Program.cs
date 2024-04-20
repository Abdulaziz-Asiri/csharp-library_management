using System.Buffers.Binary;
using System.IO.Pipes;
using System.Net.WebSockets;
using sda_onsite_2_csharp_library_management.src;
using sda_onsite_2_csharp_library_management.src.service;


internal class Program
{
    private static void Main()
    {
        var emailService = new EmailNotificationService();
        var smsService = new SMSNotificationService();
        Library library = new Library(emailService, smsService);
        var user1 = new User("Alice", new DateTime(2023, 1, 1));
        var user2 = new User("Bob");
        var user3 = new User("Charlie", new DateTime(2023, 3, 1));
        var user4 = new User("David", new DateTime(2023, 4, 1));
        var user5 = new User("Eve", new DateTime(2024, 5, 1));
        var user6 = new User("Fiona", new DateTime(2024, 6, 1));
        var user7 = new User("George", new DateTime(2024, 7, 1));
        var user8 = new User("Hannah", new DateTime(2024, 8, 1));
        var user9 = new User("Ian");
        var user10 = new User("Julia");

        var book1 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));
        var book2 = new Book("1984", new DateTime(2023, 2, 1));
        var book3 = new Book("To Kill a Mockingbird", new DateTime(2023, 3, 1));
        var book4 = new Book("The Catcher in the Rye", new DateTime(2023, 4, 1));
        var book5 = new Book("Pride and Prejudice", new DateTime(2023, 5, 1));
        var book6 = new Book("Wuthering Heights", new DateTime(2023, 6, 1));
        var book7 = new Book("Jane Eyre", new DateTime(2023, 7, 1));
        var book8 = new Book("Brave New World", new DateTime(2023, 8, 1));
        var book9 = new Book("Moby-Dick", new DateTime(2023, 9, 1));
        var book10 = new Book("War and Peace", new DateTime(2023, 10, 1));
        var book11 = new Book("Hamlet", new DateTime(2023, 11, 1));

        library.AddBooks(book1);
        library.AddBooks(book1);
        library.AddBooks(book4);
        library.AddBooks(book9);
        library.AddBooks(book2);
        library.AddBooks(book5);
        library.AddBooks(book6);
        library.AddBooks(book7);
        library.AddBooks(book8);
        library.AddBooks(book3);
        library.AddBooks(book10);
        library.AddBooks(book11);

        library.FindBook("The Great Gatsby");
        library.DeleteBook(book1.GetId());
        library.DeleteBook(book1.GetId());
        Console.WriteLine("---------------Page 1----------------");
        library.GetBooks(1);
        Console.WriteLine("---------------Page 2----------------");
        library.GetBooks(2);
        Console.WriteLine("---------------Page 3----------------");
        library.GetBooks(3);



        library.AddUser(user1);
        library.AddUser(user5);
        library.AddUser(user6);
        library.AddUser(user7);
        library.AddUser(user4);
        library.AddUser(user8);
        library.AddUser(user2);
        library.AddUser(user3);
        library.AddUser(user9);
        library.AddUser(user10);

        Console.WriteLine("---------------Page 1----------------");
        library.GetUesr(1);
        Console.WriteLine("---------------Page 2----------------");
        library.GetUesr(2);
        Console.WriteLine("---------------Page 3----------------");
        library.GetUesr(3);
        library.FindUser("Alic");
        library.DeleteUser(user1.GetId()); // deleting the user by its id
    }
}

