using System;
using project1.models;

namespace project1
{
    public class sqlStudentData
    {
        private readonly testDbContext db;

        public sqlStudentData(testDbContext db)
        {
            this.db = db;
        }

       public Student Add(Student newStudent)
        {
            db.Add(newStudent);
            return newStudent;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Student Delete(int id)
        {
            var student = GetById(id);
            if(student != null)
            {
                db.Students.Remove(student);
            }
            return student;
        }

        public Student GetById(int id)
        {
            return db.Students.Find(id);
        }


    }
}
