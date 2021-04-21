using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Bindings2
{
        public class Data : ObservableCollection<Student>
    {
        public Student CurrentStudent { get; set; }

        public List<Student> Students { get; set; }

        public void AddStudent()
        {
            Student newStudent = new Student();
            newStudent.firstName = RandomNameGenerator.NameGenerator.GenerateFirstName(RandomNameGenerator.Gender.Male);
            newStudent.lastName = RandomNameGenerator.NameGenerator.GenerateLastName();
            Students.Add(newStudent);
        }

        public void RemoveStudent(Student std)
        {
           Students.Remove(std);
        }
    }
}
