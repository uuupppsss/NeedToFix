using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp13.Model;

namespace WpfApp13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        void Signal([CallerMemberName] string prop = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            new DB();

            var db = DBManager.Instance;
            {
                Students=db.Students.Include(s=>s.Tasks).ToList();
            }

        }

        private List<Student> students;
        
        public List<Student> Students
        {
            get => students;
            set
            {
                students = value;
                Signal();
            }
        }

        private Student _selectedStudent;

        public Student SelectedStudent
        {
            get => _selectedStudent;
            set 
            {
                _selectedStudent = value;
                Signal();
            }
        }

    }
}