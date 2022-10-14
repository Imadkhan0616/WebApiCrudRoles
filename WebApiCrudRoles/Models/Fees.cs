namespace WebApiCrudRoles.Models
{
    public class Fees : BaseEntities //interfaces
    {
        public decimal Fee { get; set; }
        public decimal FeeStatement { get; set; }
        public decimal Due { get; set; }
    }
}
