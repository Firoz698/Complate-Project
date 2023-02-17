using System.ComponentModel.DataAnnotations;

namespace WebApplicationOne.Models
{
    public class User
    {



        public User()
        {
            Id = 0;
            UserName = "";
            Passwoed = "";
            FirstName = "";
            LastName = "";
            address = "";
            Email = "";
            Remarks = "";
        }

        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Passwoed { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string address { get; set; }
        public string Email { get; set; }
        public string Remarks { get; set; }


    }
}
