using InternetBanking.Core.Application.ViewModels.Clients.Paids;
using InternetBanking.Core.Application.ViewModels.Express_Paid;
using InternetBanking.Core.Application.ViewModels.Products;
using InternetBanking.Core.Application.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.Core.Application.helper
{
    public sealed class SingletonRepository
    {
        public static SingletonRepository Instance { get; } = new SingletonRepository();

        public SaveUserVM client = new();
        public SaveProductVM Product = new();
        public BeneficaryPaid Beneficary { get; set; }
        public ExpressPaid Express { get; set; }

        public string origin = string.Empty;

        private SingletonRepository()
        { }

    }
}
