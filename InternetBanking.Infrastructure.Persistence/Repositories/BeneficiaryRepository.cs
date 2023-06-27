using InternetBanking.Core.Application.Interfaces.Repositories;
using InternetBanking.Core.Domain.Entities;
using InternetBanking.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.Infrastructure.Persistence.Repositories
{
    public class BeneficiaryRepository : GenericRepository<Beneficiary>, IBeneficiaryRepository
    {
        private readonly ApplicationDbContext db;

        public BeneficiaryRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public async Task<Beneficiary> GetByIdAsync(string id)
        {
            return await db.Set<Beneficiary>().FindAsync(id);
        }


    }
}
