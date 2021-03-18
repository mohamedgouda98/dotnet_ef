using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using project1.models;

namespace project1.Data
{
    public class StudentRepository : IStudentRepository
    {
        private readonly testDbContext _context;
        private readonly ILogger<StudentRepository> _logger;

        public StudentRepository(testDbContext context, ILogger<StudentRepository> logger)
        {
            this._context = context;
            this._logger = logger;
        }


        public async Task<bool> SaveChangesAsync()
        {
            _logger.LogInformation($"Attempitng to save the changes in the context");

            // Only return success if at least one row was changed
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Student[]> GetAllStudentsAsync()
        {
            _logger.LogInformation($"Getting all Students");

            return await _context.Students.ToArrayAsync();
        }

  
    }
}
