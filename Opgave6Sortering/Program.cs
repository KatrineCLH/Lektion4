using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave6Sortering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> personer = new List<Person>();
            Person ole = new Person(100, 100, "Ole");
            Person jens = new Person(90, 90, "Jens");
            Person yrsa = new Person(80, 80, "Yrsa");
            personer.Add(ole);
            personer.Add(jens);
            personer.Add(yrsa);
        }
    }
}
