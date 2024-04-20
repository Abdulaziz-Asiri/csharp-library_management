using sda_onsite_2_csharp_library_management.src.abstraction;

namespace sda_onsite_2_csharp_library_management.src.service
{
    public class SMSNotificationService : INotificationService
    {
        public void SendNotificationOnFailure(string titlem, string bookOrUser, string addOrdelete)
        {
            Console.WriteLine($"SMS: We encountered an issue {addOrdelete} '{titlem}' to {bookOrUser} array.");
        }
        public void SendNotificationOnSucess(string title, string bookOrUser, string addOrdelete)
        {
            Console.WriteLine($"SMS:A new {bookOrUser}  '{title}' has been successfully {addOrdelete} to the Library.");
        }
    }
}