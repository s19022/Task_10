using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assigment_10.DTOs.Request
{
    public class AddStudentRequest
    {
        public string IndexNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }



    }
}
