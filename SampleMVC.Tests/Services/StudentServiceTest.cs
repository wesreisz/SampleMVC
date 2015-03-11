using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleMVC.Services;
using SampleMVC.Models;
using System.Collections.Generic;

namespace SampleMVC.Tests.Services
{
    [TestClass]
    public class StudentServiceTest
    {
        [TestMethod]
        public void ListStudents()
        {
            StudentService service = new StudentService();
            List<Student> students = service.getStudents();
            Assert.IsNotNull(students);
            Assert.AreEqual(3, students.Count);
        }
        [TestMethod]
        public void AddStudent()
        {
            StudentService service = new StudentService();
            Student student = new Student() { 
                Address="123 Web Way",
                Age=21,
                City="Mountain View",
                Email="wannabelikemike@google.com",
                Name="Sammy Smithers",
                State="CA",
                StudentID=6,
                Zip="12345"
            };
            service.addStudent(student);
            List<Student> students = service.getStudents();
            Assert.IsNotNull(students);
            Assert.AreEqual(4, students.Count);
        }
        [TestMethod]
        public void RemoveStudent() {
            StudentService service = new StudentService();
            List<Student> students = service.getStudents();
            Student removedStudent = students[0];
            service.removeStudent(removedStudent);
            //refetch
            students = service.getStudents();
            Assert.IsNotNull(students);
            Assert.AreEqual(2, students.Count);
            foreach (Student student in students) {
                Assert.AreNotEqual(removedStudent.Email, student.Email);
            }
        }
        [TestMethod]
        public void GetStudentTest() {
            StudentService service = new StudentService();
            Student student = service.getStudent(1);
            Assert.AreEqual("Joey", student.Name);
            Assert.AreEqual(21, student.Age);
            Assert.AreEqual(1, student.StudentID);

        }
    }
}
