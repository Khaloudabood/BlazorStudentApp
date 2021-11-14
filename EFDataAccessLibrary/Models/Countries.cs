using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLibrary.Models
{
    public class Countries
    {
        public int Id { get; set; }

        public String CountryName { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();
    }
}
