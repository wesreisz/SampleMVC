using SampleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMVC.Services
{
    public class StudentService
    {
        private static List<Student> students;

        static StudentService() {
            students = new List<Student>();
            Student s1 = new Student
            {
                Address = "123 west",
                Age = 21,
                Name = "Joey",
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
        }

        public void addStudent(Student s) {
            students.Add(s);
        }

        public Student getStudent(int id) {
            Student selectedStudent = new Student();
            foreach (Student student in students) {
                if (student.StudentID == id) {
                    selectedStudent = student;
                }
            }
            return selectedStudent;
        }

        public void removeStudent(Student s) {
            Student student = getStudent(s.StudentID);
            students.Remove(student);
        }

        public List<Student> getStudents() {
            return students;
        }
        public void updateStudent(Student student) {
            removeStudent(student);
            addStudent(student);
        }
    }
}