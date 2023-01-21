using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula6.Models
{
    public class DataStore3<T> where T : Diretor
    {
        public T Data { get; set; }
    }
}
