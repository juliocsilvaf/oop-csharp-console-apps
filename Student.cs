using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Student : Person
    {
        private string[] _subjects;

        //TODO: 2, add constructor

        public Student(string name, string[] subjects): base(name)
        {
            this._subjects = subjects;
        }

        public override void PrintDetails()
        {
            //TODO: 3, print details to console
            String subjects = String.Join(",", _subjects);
            Console.WriteLine($"Hi my name is {this._name} and I am studying {subjects}");
           
        }
    }
}
