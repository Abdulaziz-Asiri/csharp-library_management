using System.ComponentModel;
using System.Xml.XPath;
using Microsoft.VisualBasic;
using sda_onsite_2_csharp_library_management.src.service;

namespace sda_onsite_2_csharp_library_management.src
{
    public class Library
    {
        public List<Book> _books = [];
        private List<User> _users = [];
        private EmailNotificationService _emailNotificationService;
        public Library(EmailNotificationService emailNotificationService)
        {
            _emailNotificationService = emailNotificationService;
        }

        public void FindBook(string title)
        {
            Book? findBooks = _books.Find(book => book.GetTitle() == title);

            if (findBooks != null)
            {
                Console.WriteLine($"The Book '{findBooks.GetTitle()}' Founded");
            }
            else
            {
                Console.WriteLine("The book not found");
            }
        }

        public void AddBooks(Book newBook)
        {
            if (!_books.Contains(newBook))
            {
                _books.Add(newBook);
                _emailNotificationService.SendNotificationOnSucess(newBook.GetTitle(), "Book", "added");
                //  Console.WriteLine($"Book Add Seccessed\n{newBook} ");
            }
            else
            {
                _emailNotificationService.SendNotificationOnFailure(newBook.GetTitle(), "Book", "adding");
                // Console.WriteLine("Book already exists");
            }
        }

        public void DeleteBook(Guid bookId)
        {
            Book? findBook = _books.Find(book => book.GetId() == bookId);
            if (findBook != null)
            {
                _books.Remove(findBook);
                _emailNotificationService.SendNotificationOnSucess(findBook.GetTitle(), "Book", "Deleted");
                // Console.WriteLine($"The book {findBook.GetTitle()} has been Deleted  seccessfully \n ");
            }
            else
            {
                _emailNotificationService.SendNotificationOnFailure(findBook.GetTitle(), "Book", "Deleting");
                // Console.WriteLine("The book you want to delete is not exist");
            }
        }
        public void GetBooks(int page) //page number as parameter
        {
            var Offset = 3; // Item per page
            var itemPerPage = (page - 1) * Offset; // 


            var findBook = _books.OrderBy(book => book.GetDateCreated())
                                .Select(book => book.GetTitle())
                                .Skip(itemPerPage) // skip the
                                .Take(Offset);

            foreach (var book in findBook)
            {

                Console.WriteLine($"Book:{book}\n");
            }
        }

        public void FindUser(string username)
        {
            User? findUser = _users.Find(user => user.GetName() == username);

            if (findUser != null)
            {
                Console.WriteLine($"The User {findUser.GetName()} Founded");
            }
            else
            {
                Console.WriteLine("The user not found");
            }
        }



        public void AddUser(User newUser)
        {
            if (!_users.Contains(newUser))
            {
                
                _users.Add(newUser);
                _emailNotificationService.SendNotificationOnSucess(newUser.GetName(), "User", "added");
                // Console.WriteLine($"The User {newUser.GetName() } added successfully");
            }
            else
            {
                _emailNotificationService.SendNotificationOnFailure(newUser.GetName(), "User", "adding");
                // Console.WriteLine("User does not exist");
            }
        }

        public void DeleteUser(Guid userId)
        {

            User? findUser = _users.Find(user => user.GetId() == userId);
            if (findUser != null)
            {
                _users.Remove(findUser);
                _emailNotificationService.SendNotificationOnSucess(findUser.GetName(), "User", "deleted");
                // Console.WriteLine($"The user {findUser.GetName()} Deleteed  successfully\n ");
            }
            else
            {
                _emailNotificationService.SendNotificationOnFailure(findUser.GetName(), "User", "deleting");
                // Console.WriteLine("The user you want to delete is not exist");
            }
        }
        public void GetUesr(int page)
        {
            var Offset = 3; // Item per page
            var itemPerPage = (page - 1) * Offset; // 

            var finduser = _users.OrderBy(user => user.GetDate())
                                .Select(user => user.GetName())
                                .Skip(itemPerPage) // skip the the item depending on the itemPerPage value
                                .Take(Offset);
            foreach (var item in finduser)
            {
                Console.WriteLine($"User: {item}");
            }
        }
    }
}