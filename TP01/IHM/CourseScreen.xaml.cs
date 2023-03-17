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

namespace IHM
{
    /// <summary>
    /// Logique d'interaction pour EditCourse.xaml
    /// </summary>
    public partial class CourseScreen : Window
    {
        private Course course;
        public CourseScreen(Course course = null)
        {
            this.course = course;
            InitializeComponent();
            if (course.AlreadyExist)
            {
                this.CodeTextBox.Text = this.course.Code;
                this.NameTextBox.Text = this.course.Name;
                this.WeightTextBox.Text = this.course.Weight.ToString();
            }
        }

        private void Ok(object sender, RoutedEventArgs e)
        {
            this.course.Code = this.CodeTextBox.Text;
            this.course.Name = this.NameTextBox.Text;
            this.course.Weight = Convert.ToInt32(this.WeightTextBox.Text);
            this.course.Update();
            this.Close();
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
