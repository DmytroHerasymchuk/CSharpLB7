using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CSharpLB7.Data;
using CSharpLB7.Models;

namespace CSharpLB7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DBContext _context;
        private List<Teacher> _teachers = new List<Teacher>();
        private List<Lesson> _lessons = new List<Lesson>();
        public MainWindow()
        {
            InitializeComponent();
            _context = new DBContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(teacherNameTb.Text))
            {
                Teacher teacher = new Teacher()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = teacherNameTb.Text,
                    Salary = Convert.ToDouble(teacherSalaryTb.Text)
                };
                _teachers.Add(teacher);
                teachersList.ItemsSource = _teachers;
                _context.Teachers.Add(teacher);
                _context.SaveChanges();
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
