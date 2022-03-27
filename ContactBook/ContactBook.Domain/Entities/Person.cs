using ContactBook.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace ContactBook.Domain.Entities
{
    public class Person : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Notes { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }
        public virtual ICollection<Email> Emails { get; set; }
    }
}
