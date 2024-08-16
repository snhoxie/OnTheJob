using System.ComponentModel.DataAnnotations;

namespace OnTheJob.Models
{
    public class WorkItem
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Hours {  get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;

        public DateTime WorkDate { get; set; } = DateTime.Now;



    }
}
