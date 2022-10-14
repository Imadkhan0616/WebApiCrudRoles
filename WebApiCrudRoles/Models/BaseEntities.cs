using System.ComponentModel.DataAnnotations;

namespace WebApiCrudRoles.Models
{
    public class BaseEntities
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public DateTime ClassSchedule { get; set; }
        [Required]
        public string Courses { get; set; }
    }
}
