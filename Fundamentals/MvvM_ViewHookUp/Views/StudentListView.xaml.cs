using System.Windows.Controls;
using MvvM_ViewHookUp.ViewModels;

namespace MvvM_ViewHookUp.Views
{
    /// <summary>
    ///     Interaction logic for StudentListView.xaml
    /// </summary>
    public partial class StudentListView : UserControl
    {
        public StudentListView()
        {
            InitializeComponent();
            DataContext = new StudentListViewModel();
        }
    }
}