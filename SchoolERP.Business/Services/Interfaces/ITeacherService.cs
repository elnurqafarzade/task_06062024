using SchoolERP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolERP.Business.Services.Interfaces
{
    public interface ITeacherService
    {
        void Create(Teacher tacher);
        List<Teacher> GetAll();
        Teacher GetTeacher(int id);
        void Remove(int id);        
    }
}
