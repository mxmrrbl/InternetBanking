using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternetBanking.Core.Application.Interfaces.Repositories;
using InternetBanking.Core.Domain.Entities;
using InternetBanking.Infrastructure.Persistence.Context;

namespace InternetBanking.Infrastructure.Persistence.Repositories
{
   public class TransactionRepository : GenericRepository<Transactional>, ITransactionRepository
    {
        private readonly ApplicationDbContext db;

        public TransactionRepository(ApplicationDbContext db):base(db)
        {
            this.db = db;
        }
    }
}
