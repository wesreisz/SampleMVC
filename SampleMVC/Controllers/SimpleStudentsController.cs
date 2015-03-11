using SampleMVC.Models;
using SampleMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVC.Controllers
{
    public class SimpleStudentsController : Controller
    {
        // GET: SimpleStudents
        public ActionResult Index()
        {
            StudentService service = new StudentService();
            return View(service.getStudents());
        }

        // GET: SimpleStudents/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SimpleStudents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SimpleStudents/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "StudentID,Name,Email,Age,Address,City,Zip,State")] Student student)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    StudentService service = new StudentService();
                    service.addStudent(student);
                }
                catch
                {
                    return RedirectToAction("Create");
                }
            }
            return RedirectToAction("Index");
        }

        // GET: SimpleStudents/Edit/5
        public ActionResult Edit(int id)
        {
            StudentService service = new StudentService();
            Student student = service.getStudent(id);
            return View(student);
        }

        // POST: SimpleStudents/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "StudentID,Name,Email,Age,Address,City,Zip,State")] Student student)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    StudentService service = new StudentService();
                    service.updateStudent(student);
                }
                catch
                {
                    return RedirectToAction("Create");
                }
            }
            return RedirectToAction("Index");
        }

        // GET: SimpleStudents/Delete/5
        public ActionResult Delete(int id)
        {
            StudentService service = new StudentService();
            Student student = service.getStudent(id);
            service.removeStudent(student);
            return RedirectToAction("Index");
        }

        // POST: SimpleStudents/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
