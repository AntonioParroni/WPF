using System;
using System.Collections.Generic;
using System.ComponentModel;
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
/*
Grid на 2 столбца.
Слева - ListBox, 2 кнопки.
При нажатии на Add в список
добавляется случайный студент.
Remove - удаляет выбранный.
Справа - 2 TextBox. 
Они отображают информацию про текущий выделенный элемент в списке (Можно на форме объявить свойство CurrentStudent, в ListBox к нему прибиндиться свойством SelectedItem.
Справа - 2 кнопки.
Clear All - очищает список.
Green Color - меняет свойство Color студента на зелёный.
Модели:
Student
 - Name
 - Lastname
 - Color = "Red"
Data:
-CurrentStudent
- Students*/

namespace WPF_Bindings2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
        //, INotifyPropertyChanged
    {
        public Data students = null;
        public Student CurrentStudent = null;

        public MainWindow()
        {
            InitializeComponent();
            students = new Data();
            students.Students = new List<Student>();
            ListBox1.ItemsSource = students.Students;
            this.DataContext = students;
        }


       /* public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }*/

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            students.AddStudent();
            ListBox1.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            students.RemoveStudent((Student)ListBox1.SelectedItem);
            students.CurrentStudent = null;
            ListBox1.Items.Refresh();
        }

        private void ListBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           students.CurrentStudent = (Student)ListBox1.SelectedItem;
          /*  if (students.CurrentStudent.firstName != null)
            {
                LastNameBox.Text = students.CurrentStudent.lastName;
                FirstNameBox.Text = students.CurrentStudent.firstName;
            }
            else
                return;*/
        }
    }
}
