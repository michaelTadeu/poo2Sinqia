using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula4.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student()
        {
            Id = 0;
            Name = String.Empty;
        }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void DisplayData()
        {
            Console.WriteLine("Id do Estudante: {0}", Id);
            Console.WriteLine("Nome: {0}", Name); 
        }
    }
}
