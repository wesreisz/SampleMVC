using SampleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVC.Controllers
{
    public class ExampleController : Controller
    {
        // GET: Example
        public ActionResult Index()
        {
            ExampleViewModel evm = new ExampleViewModel(){String="my String",Bool=true,DateTime=new DateTime(),Decimal=300};
            List<String> names = new List<String>();
            names.Add("Wes");
            names.Add("Kim");
            names.Add("Tyler");
            names.Add("Justin");
            names.Add("Leanne");
            evm.Names = names;
            evm.Students = getStudents();

            return View(evm);
        }

        public ActionResult Students()
        {
            ExampleViewModel evm = new ExampleViewModel() { String = "my String", Bool = true, DateTime = new DateTime(), Decimal = 300 };
            evm.Students = getStudents();
            return View(evm);
        }

        private static List<Student> getStudents() {
            List<Student> students = new List<Student>();
            Student s1 = new Student
            {
                Address = "123 west",
                Age = 21,
                Name =" Joey",
                City = "Louisville",
                Email = "joe@momma.com",
                StudentID = 1

            };
            students.Add(s1);
            Student s2 = new Student
            {
                Address = "123 west",
                Age = 21,
                Name = " Sara",
                City = "Louisville",
                Email = "sara@momma.com",
                StudentID = 2

            };
            students.Add(s2);
            Student s3 = new Student
            {
                Address = "123 west",
                Age = 21,
                Name = " Billie",
                City = "Louisville",
                Email = "billie@momma.com",
                StudentID = 3

            };
            students.Add(s3);

            return students;
        }
    }
}