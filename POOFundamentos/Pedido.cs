using System;
using System.Collections.Generic;
using System.Text;

namespace POOFundamentos
{
    internal class Pedido
    {
        public string Nome;
        public string Item;
        public int Quantidade;
        public double Preco;

        public void ExibirPedido()
        {
            Console.WriteLine($"Olá {Nome}, COnferindo seu pedido!");
            Console.WriteLine($"Produto: {Item}");
            Console.WriteLine($"Quantidade: {Quantidade}");
            Console.WriteLine($"Preço: {Preco}");
        }
    }
}
