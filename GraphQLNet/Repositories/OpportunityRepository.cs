
using GraphQLNet.DataContext;
using GraphQLNet.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLNet.Repositories
{
    public class OpportunityRepository: IOpportunityRepository
    {
        private readonly AppDbContext _context;
        public OpportunityRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<Opportunity> GetOpportunities()
        {
            return _context.Opportunities.ToList();
        }
        public Opportunity GetOpportunityPorId(int id)
        {
            var employee = _context.Opportunities
                .Include(e => e.Company)
                .Where(e => e.opportunityId == id)
                .FirstOrDefault();
            if (employee != null)
                return employee;
            return null;
        }
        public List<Opportunity> GetOpportunitiesWithCompany()
        {
            return _context.Opportunities
                .Include(e => e.Company)
                .ToList();
        }
        public async Task<Opportunity> AddOpportunity(Opportunity Opportunity)
        {
            await _context.Opportunities.AddAsync(Opportunity);
            await _context.SaveChangesAsync();
            return Opportunity;
        }
    }

}

