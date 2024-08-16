using System.ComponentModel.DataAnnotations;

namespace OnTheJob.Models
{
    public class Job
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string JobDescription { get; set; }

        public List<Location>? Locations { get; set; }


    }
}
