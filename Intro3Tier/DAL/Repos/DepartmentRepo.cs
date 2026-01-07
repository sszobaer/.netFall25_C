using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class DepartmentRepo : IRepository<Department>, IDepartmentFeature
    {
        UMSContext db;
        public DepartmentRepo(UMSContext db )
        {
            this.db = db;
        }
        public Department Get(int id) {
            return db.Departments.Find(id);
        }
        public bool Create(Department s) { 
            db.Departments.Add(s);
            return db.SaveChanges() > 0;
        }
        public bool Update(Department d) {
            var exobj = Get(d.Id);
            db.Entry(exobj).CurrentValues.SetValues(d);
            return db.SaveChanges()>0;
        }
        public bool Delete(int id) {
            var exobj = Get(id);
            db.Departments.Remove(exobj);   
            return db.SaveChanges() > 0;    
        }
        public List<Department> Get() {
            return db.Departments.ToList();
            /*var list = new List<Department>();
            for (int i = 1; i <= 10; i++) { 
                list.Add(new Department() { 
                    Id = i,
                    Name = "D"+i
                });
            }
            return list;*/
        }
        public Department GetByName(string name) { 
            var dept = (from d in db.Departments 
                       where d.Name.Contains(name)
                       select d).SingleOrDefault();
            return dept;
        }

        public Department GetByNameWithStudent(string name)
        {
            var dept = (from d in db.Departments.Include(dep=> dep.Students)
                        where d.Name.Contains(name)
                        select d).SingleOrDefault();
            return dept;
        }

        public Department GetWithStudents(int id)
        {
            var dept = from d in db.Departments.Include(dep=>dep.Students)   
                       where d.Id == id select d;
            return dept.SingleOrDefault();

        }

        public Department WithHighestStudents()
        {
            var dept = (from d in db.Departments.Include(dep=>dep.Students)
                       orderby d.Students.Count() descending
                       select d).First();
            return dept;
        }

        public List<Department> TopNDeparmentsStCount(int n)
        {
            var dept = (from d in db.Departments.Include(dep => dep.Students)
                        orderby d.Students.Count() descending
                        select d).Take(n).ToList();
            return dept;
        }
    }
}
