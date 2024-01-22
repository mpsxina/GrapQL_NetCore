
using GraphQLNet.DataContext;
using GraphQLNet.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLNet.Repositories
{
    public class CompanyRepository: ICompanyRepository
    {
        private readonly AppDbContext _context;
        public CompanyRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<Company> GetListCompanies()
        {
            var companies = _context.Companies.ToList();
            return companies;
        }
        public List<Company> GetCompaniesWithOpportunities()
        {
            return _context.Companies
                   .Include(d => d.Opportunities)
                   .ToList();
        }
        public async Task<Company> AddCompany(Company company)
        {
            await _context.Companies.AddAsync(company);
            await _context.SaveChangesAsync();
            return company;
        }


    }
}
