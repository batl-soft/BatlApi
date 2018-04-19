using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatlApi.DataAccess.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LogoUrl { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
