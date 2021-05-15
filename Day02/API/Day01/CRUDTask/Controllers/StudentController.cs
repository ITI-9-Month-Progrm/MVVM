using CRUDTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUDTask.Controllers
{
    public class StudentController : ApiController
    {
        Shcool schoolDB;
        public StudentController()
        {
            schoolDB = new Shcool();
        }
        public IHttpActionResult GetAllStudents()
        {
            List<Student> students = schoolDB.Students.ToList();
            if (students.Count() > 0)
            {
                return Ok(students);
            }
            else
            {
                return NotFound();
            }
        }
        public IHttpActionResult GetStudentDetails(int id)
        {
            Student student = schoolDB.Students.ToList().FirstOrDefault(S => S.Id == id);
            if(student != null)
            {
                return Ok(student);
            }
            else
            {
                return NotFound();
            }
        }
        public IHttpActionResult GetStudentDetails(string name)
        {
            Student student = schoolDB.Students.ToList().FirstOrDefault(S => S.Name.ToLower() == name.ToLower());
            if (student != null)
            {
                return Ok(student);
            }
            else
            {
                return NotFound();
            }
        }
        public IHttpActionResult PostNewStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Object is Not Valid");

            }else 
            {
                schoolDB.Students.Add(student);
                schoolDB.SaveChanges();
                return Ok("Student Added");
            }
        }
        public IHttpActionResult PutStudent([FromUri]int id,[FromBody]Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Object is Not Valid");

            }
            else if(id != student.Id)
            {
                return BadRequest("Id is Not Found");
            }
            else 
            {
                schoolDB.Entry(student).State = System.Data.Entity.EntityState.Modified;
                schoolDB.SaveChanges();
                return Ok("Student Updated");
            }
        }
        public IHttpActionResult DeleteStudent( int id)
        {
            Student student = schoolDB.Students.ToList().FirstOrDefault(s => s.Id == id);
            if(student is null)
            {
                return BadRequest("Student is Not Found");
            }
            else
            {
                schoolDB.Students.Remove(student);
                schoolDB.SaveChanges();
                return Ok("Deleted Done");
            }
        }
    }
}
