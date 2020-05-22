using Assigment_10.DTOs.Request;
using Assigment_10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assigment_10
{
    public interface IStudentService
    {
        public ICollection<Student> GetStudents();

        public void AddStudent(AddStudentRequest request);

        public void ModifyStudent()
    }
}
