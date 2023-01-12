namespace ConsoleApp_Aula1_Exercicio
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pessoa p;
            Aluno aluno;
            Professor prof;

            // primeira parte
            p = new Pessoa("Jessica", 27);
            p.Cumprimentar();
            p.DizerIdade();
            Console.WriteLine();

            // segunda parte
            aluno = new Aluno("Richard", 21);
            aluno.IrParaEscola();
            aluno.Cumprimentar();
            aluno.DizerIdade();
            Console.WriteLine();

            // terceira parte
            prof = new Professor("Michael", 33);
            prof.Cumprimentar();
            prof.DizerIdade();
            prof.Explicar("Programação em C#");

            Console.ReadKey();
        }
    }
}