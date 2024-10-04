using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingManagement.DAO.DB;
using TrainingManagement.Common.Entities;
using TrainingManagement.Common.Repositories;


namespace TrainingManagement.DAO.Repositories
{
    public class AccountRepository: IAccountRepository
    {
        public Training_DBContext _dBContext;

        public  AccountRepository (Training_DBContext dbContext)
        {
            _dBContext = dbContext;
        }
        public async Task<LoginDetails> GetLoginDetails(string userName, string password) {

            var dbRecord=  await _dBContext.tbl_login_details.Where(p => (p.UserName!=null && p.UserName.Equals(userName)) && (p.Password != null && p.Password.Equals(password))).FirstOrDefaultAsync();

              return dbRecord;

           
           
        }
    }
}
