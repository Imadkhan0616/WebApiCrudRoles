using System.ComponentModel.DataAnnotations;

namespace WebApiCrudRoles.Models
{
    public class Faculty : BaseEntities
    {
        [Required]
        public decimal Salary { get; set; }
    }
}
