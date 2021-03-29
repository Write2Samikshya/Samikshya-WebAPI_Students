using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsWebapiTrial.Models
{
    public  static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)

        {
            modelBuilder.Entity<StudentDetails>().HasData(
                
                new StudentDetails
                {
                    StudID=1,
                    StudAge=12,
                    StudName="Samu",
                    StudCity="CTC"
                },
                  new StudentDetails
                  {
                      StudID = 2,
                      StudAge = 19,
                      StudName = "Dhamu",
                      StudCity = "ZAQ"
                  },
                    new StudentDetails
                    {
                        StudID = 3,
                        StudAge = 13,
                        StudName = "Ramu",
                        StudCity = "TWQ"
                    },
                      new StudentDetails
                      {
                          StudID = 4,
                          StudAge = 15,
                          StudName = "Pamu",
                          StudCity = "BBSR"
                      }

                );



        }

    }
}
