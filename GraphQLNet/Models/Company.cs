using System.ComponentModel.DataAnnotations;

namespace GraphQLNet.Models
{
    public class Company
    {
        public int companyId { get; set; }
        [Required]
        public string? fantasyName { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
        public string? country { get; set; }
        public string? urlSite { get; set; }

        public ICollection<Opportunity>? Opportunities { get; set; }
    }
}
