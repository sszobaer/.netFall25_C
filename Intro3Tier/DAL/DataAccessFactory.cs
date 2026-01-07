using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System.Reflection.Emit;

namespace DAL
{
    public class DataAccessFactory
    {
        UMSContext db;
        public DataAccessFactory(UMSContext db) { 
            this.db = db;
        }
        public IRepository<Department> DepartmentData() { 
            return new DepartmentRepo(db);
        }
        public IDepartmentFeature DepartmentFeature() {
            return new DepartmentRepo(db);
        }
        public IRepository<Student> StudentData() {
            return new StudentRepo(db);
        }

    }
}
