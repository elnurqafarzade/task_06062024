using SchoolERP.Business.Services.Interfaces;
using SchoolERP.Core.Models;
using SchoolERP.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolERP.Business.Services.Implementations
{
    public class StudentService : IStudentService
    {
        public void Create(Student student)
        {
            SchoolERPDatabase.Students.Add(student);
        }

        public Student Get(int id)
        {
            var data = SchoolERPDatabase.Students.Find(x => x.Id == id);
            if (data is null)
            {
                throw new NullReferenceException("Student not found!");
            }
            return data;
        }


        public List<Student> GetAll()
        {
            return SchoolERPDatabase.Students;

        }

        public void Remove(int id)
        {
            var data = SchoolERPDatabase.Students.Find(x => x.Id == id);
            if (data is null)
            {
                throw new NullReferenceException("Student not found");


            }


            SchoolERPDatabase.Students.Remove(data);
        }


    }
}
