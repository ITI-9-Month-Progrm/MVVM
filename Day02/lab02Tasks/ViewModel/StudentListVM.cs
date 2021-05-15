using lab02Tasks.Model;
using lab02Tasks.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02Tasks.ViewModel
{
    public class StudentListVM
    {
        List<Student> _students;
        IDataService dataService { get; set; }
        public StudentListVM(IDataService dataService)
        {
            this.dataService = dataService;
        }
        public List<Student> StudentList { get => _students ?? (_students = dataService.Students()); }
    }
}
