using BasicApp.Models;
using BasicApp.Repository.Interfaces;

namespace BasicApp.Repository.Implementation
{
    public class StudentImplementation : IStudent
    {
        public List<Student> getAllStudents()
        {
            return allStudents();
        }

        public Student getStudentById(int id)
        {

            return allStudents().FirstOrDefault(x => x.Id == id);
        }

        public  List<Student> getStudentsByGender(string gender)
        {
            return allStudents().Where(x=>x.Gender == gender).ToList();
        }

        private List<Student> allStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student{Id=101,Name="Ashish",Gender="Male",Standard=12,State="Gujarat"},
                new Student{Id=101,Name="Anisha",Gender="Female",Standard=10,State="Gujarat"},
                new Student{Id=101,Name="Rahul",Gender="Male",Standard=9,State="M.P"},
                new Student{Id=101,Name="Ritu",Gender="Female",Standard=12,State="Rajashthan"},
                new Student{Id=101,Name="Mangesh",Gender="Male",Standard=8,State="U.P"}

            };

            return students;
        }
    }
}
