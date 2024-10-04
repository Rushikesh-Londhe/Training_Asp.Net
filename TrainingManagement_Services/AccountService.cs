using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManagement.Common.Dto.Account;
using TrainingManagement.Common.Repositories;
using TrainingManagement.Common.Services;

namespace TrainingManagement.Services
{
    
    public class AccountService: IAccountSrevice
    {
        public readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository) { 
            _accountRepository=accountRepository;
        }
        
         async Task<LoginResponse> IAccountSrevice.VerifyLoginDetails(LoginRequest request)
        {
           LoginResponse response = new LoginResponse();
            try
            {
               var dbUser= await _accountRepository.GetLoginDetails(request.Username!, request.Password!);
                if (dbUser == null)
                {
                    response.Success = false;
                    response.ErrorMessage = "Invalid data";
                }
                else { 
                response.Success= true; 

                }
                return response;
            }
            catch(Exception ex) {
                throw;
            }
        }
    }
}
