using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1_Aula3.Intefaces;

namespace ConsoleApp1_Aula3.Models
{
    public class Rental
    {
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }
        private readonly ITax _tax;
        private readonly ISeguro _seguro;

        public Rental(double pricePerHour, double pricePerDay, ITax tax)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _tax = tax;
        }
        public Rental(double price, ISeguro seguro)
        {
            PricePerHour = price;
            _seguro = seguro;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            // Pegou o Carro: 13/01/2023 08:00
            // Entregou o Carro: 28/01/2024 18:00
            // duration = 10.2 horas = 11.0 horas
            // PricePerHour = R$4,00 
            // PricePerDay = R$100,00
            // duration = 15 Dias

            var basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
                //basicPayment = 4.00 * 11 => 44
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
                //basicPayment = 100 * 15 => 1500
            }

            var tax = _tax.Tax(basicPayment);
            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
