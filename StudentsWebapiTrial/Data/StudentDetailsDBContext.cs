using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using StudentsWebapiTrial.Models;

namespace StudentsWebapiTrial.Data
{
    public class StudentDetailsDBContext:DbContext
    {
        public StudentDetailsDBContext(DbContextOptions<StudentDetailsDBContext> opt) : base(opt)
        {

        }


        public DbSet<StudentDetails> dbStudentDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

    }

}
