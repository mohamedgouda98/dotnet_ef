using System;
using System.Threading.Tasks;
using project1.models;

namespace project1.Data
{
   public interface IStudentRepository
    {
        // General 
        //void Add<T>(T entity) where T : class;
        //void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        // Students
        Task<Student[]> GetAllStudentsAsync();
        //Task<Student> GetStudentAsync(string moniker, bool includeTalks = false);
    }
}
