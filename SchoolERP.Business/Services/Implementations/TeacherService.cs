using SchoolERP.Business.Services.Interfaces;
using SchoolERP.Core.Models;
using SchoolERP.Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SchoolERP.Business.Services.Implementations
{
    public class TeacherService : ITeacherService
    {
        public void Create(Teacher teacher)
        {
            SchoolERPDatabase.Teachers.Add(teacher);
        }

        public List<Teacher> GetAll()
        {
            return SchoolERPDatabase.Teachers;
        }

        public Teacher GetTeacher(int id)
        {
            Teacher? wantedTeacher = SchoolERPDatabase.Teachers.Find(x => x.Id == id);
            if (wantedTeacher is not null)
            {
                return wantedTeacher;
            }
            throw new NullReferenceException("Teacher not found");

        }

        public void Remove(int id)
        {
            Teacher? wantedTeacher = SchoolERPDatabase.Teachers.Find(x => x.Id == id);
            IStudentService studentService = new StudentService();

            if (wantedTeacher is not null)
            {
                //studentService.GetAll().ForEach((item) =>
                //{
                //    if (item.Teacher.Id == id)
                //        item.Teacher = null;
                //}
                //);

                SchoolERPDatabase.Teachers.Remove(wantedTeacher);
            }
            else
            {
                throw new NullReferenceException("Teacher not found");

            }
        }


    }
}
