using StudentsWebapiTrial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentsWebapiTrial.DTOS;
using AutoMapper;
using AutoMapper.Mappers;

namespace StudentsWebapiTrial.Profiles
{
    public class StudentsProfile :Profile
    {
        public StudentsProfile()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<StudentDetails, StudentReadDTOS>();
                cfg.AddProfile<StudentsProfile>();
            });
        }

    }
}
