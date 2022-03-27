using ContactBook.Domain.Entities.Abstract;
using ContactBook.Domain.Enums;

namespace ContactBook.Domain.Entities
{
    public class PhoneNumber : EntityBase
    {
        public string Number { get; set; }
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public ContactType ContactType { get; set; }
    }
}
