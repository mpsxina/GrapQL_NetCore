using GraphQLNet.Repositories;
using System.ComponentModel.DataAnnotations;

namespace GraphQLNet.Models
{
    public class Opportunity
    {
        public int opportunityId { get; set; }
        [Required]
        public string? description { get; set; }
        public string? responsableName { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? contact { get; set; }
        [Required]
        public string? jobSource { get; set; }

        public int CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
