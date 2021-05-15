using lab02Tasks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02Tasks.Service
{
    public interface IDataService
    {
        List<Student> Students();
        Student Student(int id);
    }
}
