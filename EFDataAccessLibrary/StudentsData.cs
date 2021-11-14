using EFDataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLibrary
{
    public class StudentsData : IStudentsData
    {
        private readonly ISqliteDataAccess _db;

        public StudentsData(ISqliteDataAccess db)
        {
            _db = db;
        }

        public Task<List<Student>> GetStudents()
        {
            String sqlite = "select * from dbo.Student ";

            return _db.LoudData<Student, dynamic>(sqlite, new { });
        }

        public Task InsertStudent(Student Student)
        {
            string sqlite = @"insert into dbo.Student (Name , DateOfBirth)
                              values(@Name , @DateOfBirth)";
            return _db.SaveData(sqlite, Student);




        }
    }
}
