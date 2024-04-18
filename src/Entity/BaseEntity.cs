namespace sda_onsite_2_csharp_library_management.src
{
    public class BaseEntity
    {
        public Guid id { get; }
        public DateTime dateCreated { get; }

        public BaseEntity(DateTime? dateValue = null)
        {
            id = Guid.NewGuid();
            
            dateCreated = (DateTime)(dateValue == null ? DateTime.Now : dateValue);
        }

    }
}