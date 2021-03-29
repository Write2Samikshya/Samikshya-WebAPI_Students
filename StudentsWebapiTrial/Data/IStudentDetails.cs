using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentsWebapiTrial.Models;

namespace StudentsWebapiTrial.Data
{
    public interface IStudentDetails
    {
         IEnumerable<StudentDetails> GetAllStudents();

          StudentDetails GetStudentByID(int ID);

        bool savechanges();

        void create(StudentDetails student);




    }
}
