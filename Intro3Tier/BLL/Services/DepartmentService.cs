using AutoMapper;
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
    public class DepartmentService
    {
        DataAccessFactory factory;
        public DepartmentService(DataAccessFactory factory)
        {
            this.factory = factory;
        }
        public List<DepartmentDTO> All() {
            var data = factory.DepartmentData().Get();
            var ret = MapperConfig.GetMapper().Map<List<DepartmentDTO>>(data);
            return ret;
            
        }
        public DepartmentDTO Get(int id) { 
            Department data = factory.DepartmentData().Get(id);
            DepartmentDTO ret = MapperConfig.GetMapper().Map<DepartmentDTO>(data);
            return ret; 
        }
        public bool Create(DepartmentDTO dto) { 
            Department data = MapperConfig.GetMapper().Map<Department>(dto);
            factory.DepartmentData().Create(data);
            return true;
        }
    }
}
