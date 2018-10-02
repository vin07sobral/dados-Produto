using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace dados_produto
{
    class Program
    {
        static void Main(string[] args)
        {

            int qte;
            produto p;
            p = new produto();

            Console.WriteLine("Digite o nome do produto:");
            Console.Write("Nome: ");
            p.nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em Estoque: ");
            p.quantidadeEmEstoque = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que entraram no estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.realizarEntrada(qte);

            Console.WriteLine();
            Console.Write("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que sairam no estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.realizarSaida(qte);

            Console.WriteLine();
            Console.Write("Dados atualizados: " + p);




            Console.ReadLine();
          
        }
    }
}
