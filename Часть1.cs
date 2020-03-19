using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Person
    {
        public string fam
        {
            set { if (fam == "") fam = value; }
            get { return (fam); }
        }
        public string status
        {
            set { }
            get { return (status); }
        }
        private int salary;
        public int age;
        protected string health;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
        }
    }
}
