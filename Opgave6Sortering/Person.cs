using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave6Sortering
{
    internal class Person
    {
        public Person(int age, double weight, string name) 
        {
            Age = age;
            Weight = weight;
            Name = name;
        }
        int Age { get; set; }
        double Weight {  get; set; }
        string Name { get; set; }
    }
}
