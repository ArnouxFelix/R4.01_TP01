using Logic;
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
using System.Windows.Shapes;
using Logic;

namespace IHM
{
    /// <summary>
    /// Logique d'interaction pour CoursesScreen.xaml
    /// </summary>
    public partial class CoursesScreen : Window
    {
        private NoteBook noteBook;
        private IEnumerable<Course> courses;
        public CoursesScreen(NoteBook noteBook)
        {
            this.noteBook = noteBook;
            InitializeComponent();
            Draw();
        }

        private void Draw()
        {
            courses = noteBook.ListCourses();
            foreach (Course course in courses)
            {
                ListeCourses.Items.Add(course);
            }
        }

        private void CreateCourse(object sender, RoutedEventArgs e)
        {
            CourseScreen createNewCourse = new CourseScreen(noteBook);
            createNewCourse.Show();
        }

        private void EditCourse(object sender, RoutedEventArgs e)
        {
            if (ListeCourses.SelectedItem != null)
            {
                CourseScreen edit = new CourseScreen(noteBook /*ListeCourses.SelectedItem*/);
                edit.Show();
            }
        }

        private void DeleteCourse(object sender, RoutedEventArgs e)
        {
            if (ListeCourses.SelectedItem != null)
            {
                //noteBook.DeleteCourse(current);
            }
            Draw();
        }
    }
}
