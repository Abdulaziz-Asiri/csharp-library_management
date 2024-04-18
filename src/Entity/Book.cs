namespace sda_onsite_2_csharp_library_management.src
{

    public class Book : BaseEntity
    {

        private string _title { get; set; }

        public Book(string title, DateTime? date_Created) : base(date_Created)
        {

            this._title = title;

        }

        public string GetTitle()
        {
            return _title;
        }

        public Guid GetId()
        {
            return id;
        }

        public DateTime? GetDateCreated()
        {
            return dateCreated;
        }


        public override string ToString()
        {
            return $"Book Title: {_title}\nId: {base.id}\nDate Created: {base.dateCreated}";
        }


    }
}