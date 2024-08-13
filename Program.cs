using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vez;
            int li;
            int ls;
            int oculto;
            int palpite;
            int i;
            int nj;
            Random r = new Random();

            vez = 1;
            li = 1;
            ls = 100;

            oculto = r.Next(98) + 2;

            do
            {
                Console.Write("Quantos jogadores?");
                nj = int.Parse(Console.ReadLine());

            }
            while (nj < 2 || nj > 5);

            string[] nomes;
            nomes = new string[nj];

            for(i=0; i<nj; i++)
            {
                Console.Write("Digite o nome do {0} jogador:", i + 1);
                nomes[i] = Console.ReadLine();
            }

            do
            {
                do
                {
                    Console.Write("Jogado {0}, digite nº entre {1} e {2}: ", vez, li, ls);
                    palpite = int.Parse(Console.ReadLine());
                }
                while (palpite <= li || palpite >= ls);
                if (palpite == oculto)
                {
                    Console.WriteLine("Parabéns jogador {0}, você perdeu", vez);
                }
                else
                    if (palpite < oculto)
                {
                    li = palpite;
                }
                else
                {
                    ls = palpite;
                }
                vez = vez + 1;
                if (vez > 2)
                {
                    vez = 1;
                }

            }
            while (palpite != oculto);

        }
    }
}

        
    

