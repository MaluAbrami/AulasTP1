using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeClasseAbstrata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto televisor = new Televisor(1, "Tv Samsung", 1099.90, 30);
            Produto dvd = new DVD(2, "DVD LG", 399.90);
            Produto guitarra = new Guitarra(3, "Guitarra Gibson", 799.90);
            Produto videogame = new Videogame(4, "Playstation 5", 3399.90);
            Produto notebook = new Notebook(5, "Notebook Gamer Dell", 4589.90);

            CestaDeCompra cestaDeCompra = new CestaDeCompra();
            cestaDeCompra.AdicionarProdutoNaCesta(televisor);
            cestaDeCompra.AdicionarProdutoNaCesta(dvd);
            cestaDeCompra.ExibirProdutosDaCesta();
            Console.WriteLine($"Valor total da compra: {cestaDeCompra.CalcularValorTotal()}");

            televisor.reajustarPreco();

            cestaDeCompra.ExibirProdutosDaCesta();
        }
    }
}
