using System.Collections.Generic;

namespace PhoneBook_AspCoreMVC.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public virtual IEnumerable<ContactTag> ContactTag { get; set; }
    }
}
