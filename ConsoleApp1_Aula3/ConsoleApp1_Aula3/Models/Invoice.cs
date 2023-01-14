﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_Aula3.Models
{
    public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }
        
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        //public override string ToString()
        //{
        //    retu
        //}
    }
}
