using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_0._1
{
    internal class Person
    {
        private string _name;
        private int _age;  // variabili private hanno underscore '_' davanti //

        //public Person()
        //{
        //    _name = "nothing";
        //    _age = 0;
        //}

        public Person (string name, int age)
        {
            _name = name;
            _age = age;
        }

        public int Age
        { 
            get { return _age; }
            /*set { _age = value; }*/ // assunzione del valore age //
        } 

        public string Name { 
            get { return _name; }
            //set { _name = value; }
        }

        public void Display()
        {
            Console.WriteLine($"NAME: {_name} AGE: {_age}");
        }
    }
}
