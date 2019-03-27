using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using DataService;

namespace MvvM_ViewModelLocatorDemo.ViewModels
{
    public class StudentListViewModel
    {
        private readonly IStudentDataRepository _dataRepository = new StudentDataRespository();

        public StudentListViewModel()
        {
            if (DesignerProperties.GetIsInDesignMode(new DependencyObject())) return;
            Students = new ObservableCollection<Student>(_dataRepository.GetAllStudents());
        }

        public ObservableCollection<Student> Students { get; set; }
    }
}