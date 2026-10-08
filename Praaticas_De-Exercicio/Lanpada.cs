using System;
using System.Collections.Generic;
using System.Text;

namespace Praaticas_De_Exercicio
{
    public class Lampada
    {
        public bool ligada;


        public void Ligar()
        {
            ligada = true;
        }

        public void Desligar()
        {
            ligada = false;
        }

        public void Alternar()
        {
            ligada = !ligada;
        }

        public void ExibirEstado()
        {
            if (ligada)
            {
                Console.WriteLine("Lampada Ligada");
            }
            else
            {
                Console.WriteLine("Lampada Desligada");
            }
        }
    }
}

