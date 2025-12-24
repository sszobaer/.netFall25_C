using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class DepartmentRepo
    {
        public List<Department> GetAll() {
            var list = new List<Department>();
            for (int i = 1; i <= 10; i++) { 
                list.Add(new Department() { 
                    Id = i,
                    Name = "D"+i
                });
            }
            return list;
        }
    }
}
