using DAL.EF;
using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class StudentRepo : IRepository<Student>
    {
        UMSContext db;
        public StudentRepo(UMSContext db)
        {
            this.db = db;
        }
        public bool Create(Student s) { 
            db.Students.Add(s);
            return db.SaveChanges() > 0;
        }
        public Student Get(int id) {
            return db.Students.Find(id);
        }
        public List<Student> Get() { 
            return db.Students.ToList();
        }
        public bool Update(Student s) { 
            var ex = Get(s.Id);
            db.Entry(ex).CurrentValues.SetValues(s);
            return db.SaveChanges()>0;
        }
        public bool Delete(int id) {
            var ex = Get(id);
            db.Students.Remove(ex);  
            return db.SaveChanges() > 0;    
        }
    }
}
