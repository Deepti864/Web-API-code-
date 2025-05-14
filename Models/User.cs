using System.ComponentModel.DataAnnotations;

namespace UserDetails.Models
{
    public class User
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime DateofBrith { get; set; }
        public string PhoneNumber { get; set; }

    }
}
