using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula3.Models
{
    public class Vehicle
    {
        public string model { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(string model)
        {
            this.model = model;
        }
    }
}
