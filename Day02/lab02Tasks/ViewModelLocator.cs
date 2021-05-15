using lab02Tasks.Service;
using lab02Tasks.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02Tasks
{
    public class ViewModelLocator
    {
        StudentListVM _StudentVM;
        public StudentListVM MainVM { get => _StudentVM ?? (new StudentListVM(new DataService())); }
    }
}
