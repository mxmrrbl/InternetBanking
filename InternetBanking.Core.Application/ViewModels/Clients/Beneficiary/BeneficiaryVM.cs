using InternetBanking.Core.Application.ViewModels.Products;
using InternetBanking.Core.Application.ViewModels.TypeAccount;
using InternetBanking.Core.Application.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.Core.Application.ViewModels.Clients.Beneficiary
{
    public class BeneficiaryVM
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public UserVM? User { get; set; }

        public int BeneficiaryCode { get; set; }
        public ProductsVM? Beneficiary { get; set; }



    }
}
