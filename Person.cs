using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication9F
{
    public class Person
    {
        public Person() { }
        public Person(int id, string fn, string ln, int ag)
        {
            ID = id;
            FName = fn;
            LName = ln;
            Age = ag;
        }
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
    }
}

