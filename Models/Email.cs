using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneBook_AspCoreMVC.Models
{
    public class Email
    {
        public int Id { get; set; }
        public string String { get; set; }
        public int ContactId { get; set; }
        [ForeignKey("ContactId")]
        public Contact Contact { get; set; }
    }
}
