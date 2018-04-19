using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatlApi.DataAccess.Models
{
    public class Match
    {
        public Guid ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
