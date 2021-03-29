using StudentsWebapiTrial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsWebapiTrial.Data
{
    public class MockStudentDetailsREPO : IStudentDetails
    {
        public void create(StudentDetails student)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StudentDetails> GetAllStudents()
        {
            var students = new List<StudentDetails>
            {
                new StudentDetails{StudID=1,StudName="samu",StudCity="CTC",StudAge=12},

                new StudentDetails{StudID=2,StudName="Ramu",StudCity="CTC",StudAge=12},

                new StudentDetails{StudID=3,StudName="TAMU",StudCity="CTC",StudAge=12},

                new StudentDetails{StudID=4,StudName="ZAMU",StudCity="CTC",StudAge=12},


            };

            return students;
        }

        public StudentDetails GetStudentByID(int ID)
        {
            return new StudentDetails { StudID = 1, StudAge = 12, StudCity = "CTC", StudName = "Samu" };
        }

        public bool savechanges()
        {
            throw new NotImplementedException();
        }
    }
}
