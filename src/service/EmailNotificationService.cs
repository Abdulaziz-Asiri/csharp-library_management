using sda_onsite_2_csharp_library_management.src.abstraction;

namespace sda_onsite_2_csharp_library_management.src.service
{
    public class EmailNotificationService : INotificationService
    {
        
        public void SendNotificationOnFailure(string title, string bookOrUser, string addOrdelete)
        {
            Console.WriteLine($"We encountered an issue {addOrdelete} '{title}' to {bookOrUser} array.");
        }

        public void SendNotificationOnSucess(string title, string bookOrUser , string addOrdelete)
        {
            Console.WriteLine($"A new {bookOrUser}  '{title}' has been successfully {addOrdelete} to the Library.");
        }
        

    }
}