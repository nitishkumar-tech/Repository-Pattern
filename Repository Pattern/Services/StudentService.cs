using Repository_Pattern.Interfaces;
using Repository_Pattern.Models;

public class StudentService
{
    private readonly IStudentRepository _repository;

    public StudentService(IStudentRepository repository)
    {
        _repository = repository;
    }

    public Task<List<Student>> GetStudents()
    {
        return _repository.GetStudents();
    }

    public Task<Student?> GetStudentById(int id)
    {
        return _repository.GetStudentById(id);
    }

    public Task AddStudent(Student student)
    {
        return _repository.AddStudent(student);
    }

    public Task UpdateStudent(Student student)
    {
        return _repository.UpdateStudent(student);
    }

    public Task DeleteStudent(int id)
    {
        return _repository.DeleteStudent(id);
    }
}
