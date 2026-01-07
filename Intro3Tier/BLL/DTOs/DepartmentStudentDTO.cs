using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DepartmentStudentDTO : DepartmentDTO
    {
        public virtual List<StudentDTO> Students { get; set; }
        public DepartmentStudentDTO() { 
            Students = new List<StudentDTO>();
        }
    }
}
