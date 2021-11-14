using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLibrary.Models
{
    public class Classes
    {

        public int Id { get; set; }

        public string Class_Name { get; set; }

       // public List<Student> Name { get; set; } = new List<Student>();
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
