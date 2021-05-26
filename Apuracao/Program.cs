using System;
using System.IO;
using System.Collections.Generic;

namespace Apuracao
{
    class Program
    {
        static void Main(string[] args)
        {
            //                          Caminho do Arquivo
            //C:\Users\rubem\Documents\Arquivo.txt

            //                          Conteúdo do arquivo
            //        Alex Blue,15
            //        Maria Green,22
            //        Bob Brown,21
            //        Alex Blue,30
            //        Bob Brown,15
            //        Maria Green,27
            //        Maria Green,22
            //        Bob Brown,25
            //        Alex Blue,31

            
            Dictionary<string, int> lista = new Dictionary<string, int>();
            string nome = null;
            int valor = 0;

            Console.Write("Entre com o caminho do arquivo : ");
            string caminho = Console.ReadLine();

            using (StreamReader arquivo = File.OpenText(caminho))
            {
                while(!arquivo.EndOfStream)
                {
                    string[] vetor = arquivo.ReadLine().Split(',');
                    nome = vetor[0];

                    if (lista.ContainsKey(nome))
                    {
                        valor = int.Parse(vetor[1]);
                        lista[nome] += valor;
                    }
                    else
                    {
                        valor = int.Parse(vetor[1]);
                        lista[nome] = valor;
                    }

                }
            }

            foreach (KeyValuePair<string, int> linhas in lista)
            {
                Console.WriteLine(linhas.Key+" : "+linhas.Value);
            }
        }
    }
}
