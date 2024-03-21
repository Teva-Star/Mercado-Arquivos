using Mercado_Arquivos.Entities;
using System.ComponentModel.Design;
string path = @"C:\Users\Fcost\OneDrive\Área de Trabalho\C#\Arquivos\Mercado-Arquivos/Historico de Compras";
string path1 = @"C:\Users\Fcost\OneDrive\Área de Trabalho\C#\Arquivos\Mercado-Arquivos/Compras";
while (true)
{
    Console.Write("Entre com o Id do Produto: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Entra com o nome do produto: ");
    string nomeProduto = Console.ReadLine();
    Console.Write("Valor do Produto " + nomeProduto + ": ");
    double priceProduto = double.Parse(Console.ReadLine());
    Produto produto = new Produto(nomeProduto, priceProduto, id);
    Console.Write("Entre com a Quantidade do produto " + nomeProduto + ": ");
    int quantidade = int.Parse(Console.ReadLine());
    Pedido pedido = new Pedido(produto, quantidade);
    try
    {
        bool ExistArquivo = File.Exists(path);

        using (StreamWriter sw = new StreamWriter(path, true))

        {
            if (ExistArquivo) { Console.WriteLine("O arquivo.txt já existe"); }
            else { Console.WriteLine("O arquivo.txt foi criado"); }
            sw.WriteLine(pedido.ToString());


        }
        Directory.CreateDirectory(path1);
        using (StreamWriter sw1 = new StreamWriter(path1+@"/compras", true))
        {

            sw1.WriteLine(pedido.ToString() + "," + (pedido.Quantidade * produto.Preco)) ;

        }


    }
    catch (Exception e) { Console.WriteLine(e.Message); }


}

















