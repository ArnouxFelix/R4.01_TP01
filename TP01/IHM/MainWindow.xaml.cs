using Logic;
using Storage;
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

namespace IHM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NoteBook noteBook;
        private ICourseDAO courseDAO;
        public MainWindow()
        {
            courseDAO = new CourseDAO(@"C:\Users\33633\OneDrive - Université de Bourgogne\Documents\Semestre 4\R4.01 - Architecture logicielle\TP\TP01\DataBase.db");
            noteBook = new NoteBook(courseDAO);
            InitializeComponent();
        }

        private void EditCourses(object sender, RoutedEventArgs e)
        {
            CoursesScreen coursesScreen = new CoursesScreen(noteBook);
            coursesScreen.Show();
        }
    }
}
