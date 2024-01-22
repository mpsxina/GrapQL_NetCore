using GraphQLNet.Models;

namespace GraphQLNet.Repositories
{
    public interface IOpportunityRepository
    {
        List<Opportunity> GetOpportunities();
        Opportunity GetOpportunityPorId(int id);
        List<Opportunity> GetOpportunitiesWithCompany();
        Task<Opportunity> AddOpportunity(Opportunity Opportunity);
    }
}
