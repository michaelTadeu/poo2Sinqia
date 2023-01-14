using System.Globalization;
using ConsoleApp1_Aula3.Models;

namespace ConsoleApp1_Aula3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel");
            Console.WriteLine("Modelo do carro: ");
            var carModel = Console.ReadLine();
            Console.WriteLine("Retirada: (dd/MM/yyyy HH:mm) ");
            var retirada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Devolução: (dd/MM/yyyy HH:mm) ");
            var devolucao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            
            var carRental = new CarRental(retirada, devolucao, new Vehicle(carModel));

            // teste com . e com ,
            Console.WriteLine("Digite o preço por hora: ");
            var precoHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o preço por dia: ");
            var precoDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var carRentalRental = new Rental(precoHora, precoDia, new BrazilTax());
            var carRentalSeguro = new Rental(precoHora, new BrazilTax());
            carRentalRental.ProcessInvoice(carRental);

            Console.WriteLine("Valor à pagar: ");
            Console.WriteLine(carRental.Invoice.TotalPayment);

            //for (int i = 0; i < args.Length; i++)
            //{
            //    Console.WriteLine(args[i]);
            //}

            //C:\...\locadora.exe abc
            //a
            //b
            //c
        }
    }
}
