using System.ComponentModel.DataAnnotations;

namespace OnTheJob.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

        public List<WorkItem> WorkItems { get; set; }


    }
}
