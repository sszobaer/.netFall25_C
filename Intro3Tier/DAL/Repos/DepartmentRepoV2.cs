using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class DepartmentRepoV2 : IRepository<Department>
    {
        public void CreateDepartment() { }
        public void UpdateDepartment() { }
        public void DeleteDepartment() { }

        public bool Create(Department s)
        {
            throw new NotImplementedException();
        }

        public Department Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Department> Get()
        {
            throw new NotImplementedException();
        }

        public bool Update(Department s)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
