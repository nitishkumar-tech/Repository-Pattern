using Repository_Pattern.Models;

namespace Repository_Pattern.Interfaces
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudents();

        Task<Student?> GetStudentById(int id);

        Task AddStudent(Student student);

        Task UpdateStudent(Student student);

        Task DeleteStudent(int id);

    }
}
