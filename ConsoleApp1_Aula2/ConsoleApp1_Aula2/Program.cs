using ConsoleApp1_Aula2.Models;

namespace ConsoleApp1_Aula2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //List<int> listaInteiros = new List<int>();

            //listaInteiros.Add(1);
            //listaInteiros.Add(8);
            //listaInteiros.Add(5);
            //listaInteiros.Remove(8);

            //foreach(int num in listaInteiros)
            //{
            //    Console.WriteLine(num);
            //}

            //OperacaoMatematica operacaoMatematica = new OperacaoMatematica();
            //Console.WriteLine(operacaoMatematica.Exponencial(2));

            FuncionarioPadrao funcPadrao = new FuncionarioPadrao("João", 6000f);
            Console.WriteLine("O {0} recebe: R$ {1} de salário.", funcPadrao.GetNome(), funcPadrao.GetSalario());

            FuncionarioComissionado funcComiss = new FuncionarioComissionado("Joana", 6000f, 5000f, 10f);
            Console.WriteLine("A {0} recebe: R$ {1} de salário.", funcComiss.GetNome(), funcComiss.CalcularProventos());

            Console.ReadKey();
        }
    }
}