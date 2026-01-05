using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Cgpa { get; set; }
     
        public int DId { get; set; }
    }
}
