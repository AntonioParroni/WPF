using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Bindings2
{
     public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string Color = "Red";

        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
