using ConsoleApp1;

internal class Program

{
    static void Main(string[] args)
    {
        string nome = "Teste";
        int id = 15;

        Produto produto = new Produto(); 
        Cliente novoCliente = new Cliente("Michael", 25);

        int novosProdutosAdquiridos = 3;
        int produtosExistentes = buscaTodosProdutosPorCliente(idCliente);

        //produtosExistentes = 5


        novoCliente.produtosAdquiridos = novosProdutosAdquiridos + produtosExistentes;
        //novoCliente.produtosAdquiridos = 3 + 5;
        //novoCliente.produtosAdquiridos = 8;

        novoCliente.Cadastrar();
        novoCliente.Comprar(100);

        int produtos = 255;
        novoCliente.DefinirProdutosAdquiridos(200);
        novoCliente.DefinirProdutosAdquiridos(produtos);
    }
}

