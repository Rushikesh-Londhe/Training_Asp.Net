using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TrainingManagement.Common.Entities;

namespace TrainingManagement.DAO.DB
{
    public class Training_DBContext : DbContext
    {
        public DbSet<User> tbl_user { get; set; } 
        public DbSet<LoginDetails> tbl_login_details { get; set; }
        public Training_DBContext(DbContextOptions<Training_DBContext> options) : base(options)
        {

        }
    }
}
