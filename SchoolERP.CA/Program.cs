using SchoolERP.Business.Services.Implementations;
using SchoolERP.Business.Services.Interfaces;
using SchoolERP.Core.Models;
using SchoolERP.Data.DAL;
using System.Drawing;
using System.Threading.Channels;

namespace SchoolERP.CA
{
    public class Program
    {
        static void Main(string[] args)
        {
            ITeacherService teacherService = new TeacherService();
            IStudentService studentService = new StudentService();
            teacherService.Create(new Teacher() { Id = 1, Fullname = "Eli ELiyev", Salary = 2600 });


            Teacher teacher = null;
            try
            {
                teacher = teacherService.GetTeacher(1);
                Console.WriteLine(teacher);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)

            {

                Console.WriteLine(ex.Message);
            }

            //try
            //{
            //    teacherService.Remove(1);
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}
            //catch (Exception ex)

            //{

            //    Console.WriteLine(ex.Message);

            //}

            Student student = new Student()
            {
                Fullname = "Abbas",
                Grade = 13,
                Teacher = teacher
            };

            studentService.Create(student);


            studentService.GetAll().ForEach(x => Console.WriteLine(x));

            //try
            //{
            //    studentService.Remove(12);

            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}
            //catch (Exception ex)

            //{

            //    Console.WriteLine(ex.Message);
            //}

            teacher.Students.Add(student);
            Console.WriteLine(
                student.Teacher);
            teacherService.Remove(1);


            Console.WriteLine("Teacherin studentleri:");
            //teacher.Students.ForEach(student => Console.Writeline(student));
            Console.WriteLine("===========================================");
            Console.WriteLine(student.Teacher);

        }
    }
}


