namespace sda_onsite_2_csharp_library_management.src.abstraction
{
    public interface INotificationService
    {
        public void SendNotificationOnSucess(string title , string bookOrUser ,string addOrdelete); // build contract
        public void SendNotificationOnFailure(string titlem ,string bookOrUser, string addOrdelete); //build contract
    }
}