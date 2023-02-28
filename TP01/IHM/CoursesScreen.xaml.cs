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
        public CoursesScreen(NoteBook noteBook)
        {
            this.noteBook = noteBook;
            InitializeComponent();
        }
    }
}
