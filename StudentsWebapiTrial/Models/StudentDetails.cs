using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsWebapiTrial.Models
{
    public class StudentDetails
    {

        [Key]
        public int StudID { get; set; }
        public string StudName { get; set; }
        public string StudCity { get; set; }
        public int StudAge { get; set; }
    }
}
