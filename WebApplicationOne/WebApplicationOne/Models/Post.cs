using System.ComponentModel.DataAnnotations;

namespace WebApplicationOne.Models
{
    public class Post
    {
        public Post()
        {
            Id = 0;
            Title = "";
            Name = "";
            Description = "";
        }

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Place Enter Title. ")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Place Enter Description. ")]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
