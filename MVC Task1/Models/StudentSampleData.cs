using System.Reflection.Metadata.Ecma335;

namespace MVC_Task1.Models
{
    public class StudentSampleData
    {
        List<Student> students;

        public StudentSampleData()
        {
            students = new List<Student>()
            {
                new Student(){Id = 1, Name = "Ahmed Mohamed", Address = "Dokki",ImagePath="1.jpg"},
                new Student(){Id = 2, Name = "Omar Elsayed", Address = "Giza",ImagePath="2.jpg"},
                new Student(){Id = 3, Name = "Khaled ali", Address = "Nasr City",ImagePath="3.jpg"},
                new Student(){Id = 4, Name = "Ali Ibrahem", Address = "maadi",ImagePath="4.jpg"}
            };
        }

        public List<Student> GetAllStudents() => students;

        public Student GetById(int id) => students.FirstOrDefault(x => x.Id == id);

        public bool isExists(int id) => students.Any(x => x.Id == id);

        public bool AddStudent(Student student)
        {
            if (isExists(student.Id))
                return false;

            students.Add(student);
            return true;
        }
    }
}
