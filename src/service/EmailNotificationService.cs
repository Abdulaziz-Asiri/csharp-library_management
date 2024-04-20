using sda_onsite_2_csharp_library_management.src.abstraction;

namespace sda_onsite_2_csharp_library_management.src.service
{
    public class EmailNotificationService : INotificationService
    {

        public void SendNotificationOnFailure(string title, string bookOrUser, string addOrdelete)
        {
            Console.WriteLine($"Email: We encountered an issue {addOrdelete} '{title}' to {bookOrUser} List.");
        }

        public void SendNotificationOnSucess(string title, string bookOrUser, string addOrdelete)
        {
            Console.WriteLine($"Email: A new {bookOrUser}  '{title}' has been successfully {addOrdelete} to the Library.");
        }


    }
}