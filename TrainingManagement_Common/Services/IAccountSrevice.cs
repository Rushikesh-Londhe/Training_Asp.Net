using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManagement.Common.Dto.Account;

namespace TrainingManagement.Common.Services
{
    public interface IAccountSrevice
    {
        Task<LoginResponse> VerifyLoginDetails(LoginRequest request);
    }
}
