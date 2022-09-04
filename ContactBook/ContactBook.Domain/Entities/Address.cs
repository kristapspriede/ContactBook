using ContactBook.Domain.Entities.Abstract;

namespace ContactBook.Domain.Entities
{
    public class Address : EntityBase
    {
        public string StreetName { get; set; }
        public string City { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
