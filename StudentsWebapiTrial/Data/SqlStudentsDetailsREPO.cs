using StudentsWebapiTrial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsWebapiTrial.Data
{
    public class SqlStudentsDetailsREPO : IStudentDetails
    {
        private readonly StudentDetailsDBContext _Context;

        public SqlStudentsDetailsREPO(StudentDetailsDBContext studentDetailsDBContext)
        {
            _Context = studentDetailsDBContext;
        }

        public void create(StudentDetails student)
        {
            if(student == null)
            {
                throw new ArgumentNullException(nameof(student));
            }
            _Context.dbStudentDetails.Add(student);
        }

        public IEnumerable<StudentDetails> GetAllStudents()
        {
            return _Context.dbStudentDetails.ToList();
        }

        public StudentDetails GetStudentByID(int ID)
        {
            return _Context.dbStudentDetails.FirstOrDefault(stud => stud.StudID == ID);
        }

        public bool savechanges()
        {
           return( _Context.SaveChanges()>=0);
        }
    }
}
