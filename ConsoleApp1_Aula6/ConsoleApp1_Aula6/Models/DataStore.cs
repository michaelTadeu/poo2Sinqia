﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula6.Models
{
    public class DataStore<T> where T : class
    {
        public T Data { get; set; }
    }
}
