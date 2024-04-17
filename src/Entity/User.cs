using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace sda_onsite_2_csharp_library_management.src
{
    public class User : BaseEntity
    {

        private string _userName { get; set; }

        public User(string user_Name, DateTime? date_Created = null) : base(date_Created)
        {

            this._userName = user_Name;
        }

        public Guid GetId()
        {
            return id;
        }
        public string GetName()
        {
            return _userName;
        }
        public DateTime GetDate()
        {
            return dateCreated;
        }
        public override string ToString()
        {
            return $"User Name: {_userName}\nID: {base.id}\nDate Created: {base.dateCreated}";
        }




    }
}