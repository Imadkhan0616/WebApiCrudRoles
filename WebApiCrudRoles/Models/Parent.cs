using System.ComponentModel.DataAnnotations;

namespace WebApiCrudRoles.Models
{
    public class Parent: BaseEntities //interfaces
    {
        public int Id { get; set; }
        [Required]
        public int StudentId { get; set; }

        public decimal Fees { get; set; }

    }
}
