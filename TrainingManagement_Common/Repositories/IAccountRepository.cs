using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManagement.Common.Entities;

namespace TrainingManagement.Common.Repositories
{
    public interface IAccountRepository
    {
        Task<LoginDetails> GetLoginDetails(string userName, string password);
    }
}
