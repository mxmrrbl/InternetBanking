using InternetBanking.Core.Application.ViewModels.Transational;
using InternetBanking.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.Core.Application.Interfaces.Services
{
    public interface ITrasantionalService : IGenericServices<SaveTransationalVM, TransationalVM, Transactional>
    {
        Task<SaveTransationalVM> GetByDateTrasations();
        Task<TransationalVM> GetTransationalToday();
    }
}
