
using SchoolERP.Core.Model;

namespace SchoolERP.Core.Models
{
    public class Student:BaseModel
    {
        private static int _counter;
        public string Fullname { get; set; }
        public double Grade { get; set; }
        public Teacher Teacher { get; set; }

        public Student()
        {
            Id = ++_counter;
        }
        public override string ToString()
        {
            return $"{Id} - {Fullname} - {Grade} - {Teacher.Fullname}";
        }
    }
}
