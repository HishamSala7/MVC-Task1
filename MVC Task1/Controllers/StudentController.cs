using Microsoft.AspNetCore.Mvc;
using MVC_Task1.Models;

namespace MVC_Task1.Controllers
{
    public class StudentController : Controller
    {
        StudentSampleData _studentSampleData = new StudentSampleData();

        public IActionResult GetAllStudents()
        {
            List<Student> studentList = _studentSampleData.GetAllStudents();
            return View("ShowAllStudents", studentList);
        }

        public IActionResult Details(int id)
        {
            Student student = _studentSampleData.GetById(id);
            return View("Details", student);
        }

        public IActionResult ShowAddStudentScreen()
        {
            return View("ShowAddStudentScreen");
        }

    }
}
