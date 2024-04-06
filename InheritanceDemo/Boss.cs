using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Boss : Employee
    {
        public string CompanyCar { get; set; }

        public Boss(string companyCar, string name, string firstName, int salary):base(name,firstName, salary)
        {
            this.CompanyCar = companyCar;
        }
        public void Lead()
        {
            Console.WriteLine("I'm the boss!! My Name is {0} {1}", FirstName, Name);
        }
    }
}
