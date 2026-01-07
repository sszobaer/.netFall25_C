using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IDepartmentFeature
    {
        public Department GetByName(string name);
        public Department GetByNameWithStudent(string name);
        public Department GetWithStudents(int id);
        public Department WithHighestStudents();
        public List<Department> TopNDeparmentsStCount(int n);
    }
}
