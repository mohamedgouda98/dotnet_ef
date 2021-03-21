using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project1.Data;
using project1.models;

namespace project1.Controllers
{
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly testDbContext _context;

        public StudentsController(testDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<Student[]> GetStudents()
        {
            return await _context.Students.ToArrayAsync();
        }

        [HttpGet("{id}")]
        public async Task<Student> GetStudent(int id)
        {
            var student =  await _context.Students.FindAsync(id);

            if(student == null)
            {
                return null;
            }

            return student;
        }

        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudent", new { id = student.ID }, student);
            //return student;


        }

    }
}
