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
        public DepartmentDTO GetByName(string name) { 
            var data = factory.DepartmentFeature().GetByName(name);
            return MapperConfig.GetMapper().Map<DepartmentDTO> (data);
        
        }
        public DepartmentStudentDTO GetWithStudents(int id) { 
            var data = factory.DepartmentFeature().GetWithStudents(id); 
            return MapperConfig.GetMapper().Map<DepartmentStudentDTO> (data);   
        }
        public List<DepartmentCountDTO> TopNDeparmentsStCount(int n) {
            var data = factory.DepartmentFeature().TopNDeparmentsStCount(n);
            return MapperConfig.GetMapper ().Map<List<DepartmentCountDTO>> (data);

        }
    }
}
