using System.Collections.Generic;

namespace PhoneBook_AspCoreMVC.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public virtual IEnumerable<Phone> Phone { get; set; }
        public virtual IEnumerable<Email> Email { get; set; }
        public virtual IEnumerable<ContactTag> ContactTag { get; set; }
    }
}
