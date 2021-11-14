using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLibrary.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public DateOnly DateOfBirth { get; set; }
       
       // public List<Classes> Class_Name { get; set; } = new List<Classes>();


    }
}
