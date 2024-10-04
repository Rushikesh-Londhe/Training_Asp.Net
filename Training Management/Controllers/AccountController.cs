using Microsoft.AspNetCore.Mvc;
using TrainingManagement.Common.Dto.Account;
using TrainingManagement.Common.Services;

namespace Training_Management.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AccountController : ControllerBase
    {


        private readonly ILogger<AccountController> _logger;
        private readonly IAccountSrevice _accoountService;

        public AccountController(ILogger<AccountController> logger, IAccountSrevice accountSrevice)
        {
            _logger = logger;
            _accoountService = accountSrevice;
        }

        [HttpPost(Name = "Login")]
        public async Task<LoginResponse> Login([FromBody] LoginRequest request)
        {
           var response= await _accoountService.VerifyLoginDetails(request);
            return response;
        }
    }
}
