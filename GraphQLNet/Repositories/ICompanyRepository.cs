using GraphQLNet.Models;

namespace GraphQLNet.Repositories
{
    public interface ICompanyRepository
    {
        List<Company> GetListCompanies();
        List<Company> GetCompaniesWithOpportunities();
        Task<Company> AddCompany(Company company);
    }
}
