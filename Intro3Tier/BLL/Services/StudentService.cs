using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentService
    {
        DataAccessFactory factory;
        public StudentService(DataAccessFactory factory)
        {
            this.factory = factory;
        }
        public List<StudentDTO> All()
        {
            var data = factory.StudentData().Get();
            var ret = MapperConfig.GetMapper().Map<List<StudentDTO>>(data);
            return ret;

        }
        public StudentDTO Get(int id)
        {
            Student data = factory.StudentData().Get(id);
            StudentDTO ret = MapperConfig.GetMapper().Map<StudentDTO>(data);
            return ret;
        }
        public bool Create(StudentDTO dto)
        {
            Student data = MapperConfig.GetMapper().Map<Student>(dto);
            return factory.StudentData().Create(data);
        }
    }
}
