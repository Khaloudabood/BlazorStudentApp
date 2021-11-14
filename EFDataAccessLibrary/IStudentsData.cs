using EFDataAccessLibrary.Models;

namespace EFDataAccessLibrary
{
    public interface IStudentsData
    {
        Task<List<Student>> GetStudents();
        Task InsertStudent(Student Student);
    }
}