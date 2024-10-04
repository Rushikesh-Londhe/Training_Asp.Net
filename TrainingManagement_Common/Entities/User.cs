using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TrainingManagement.Common.Entities.Enumerations;

namespace TrainingManagement.Common.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName {  get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? ContactNo { get; set; }
        public Roles Roles { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get;set; }
        public int CreatedById { get; set; }
        public int UpdatedById { get; set; }
        

    }
}
