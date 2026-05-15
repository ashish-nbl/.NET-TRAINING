using BasicApp.Models;

namespace BasicApp.Repository.Interfaces
{
    public interface IStudent
    {
        List<Student> getAllStudents();
        Student getStudentById(int id);

        List<Student> getStudentsByGender(string gender);
    }
}
