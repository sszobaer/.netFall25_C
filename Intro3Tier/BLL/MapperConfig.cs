using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;

namespace BLL
{
    public class MapperConfig
    {
        static MapperConfiguration cfg=new MapperConfiguration(c => {
            c.CreateMap<Department, DepartmentDTO>().ReverseMap();
            
        });      
        public static Mapper GetMapper() { 
            return new Mapper(cfg);
        }
    }
}
