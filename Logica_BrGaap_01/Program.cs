using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_BrGaap_01
{
    class Program
    {
        private static int[] matTopo = { 4 };
        private static int[] matMeio = { 5, 3 };
        private static int[] matBase = { 7, 9, 8 };
        private static int menorSoma;
        private static int indiceMenorSoma;

        private static List<string> listStringSoma = new List<string>();
        private static List<int> listIntSoma = new List<int>();

        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while(i < matTopo.Length)
            {
                while(j < (matMeio.Length - 1))
                {
                    while(k < (matBase.Length))
                    {
                        int soma = matTopo[i] + matMeio[j] + matBase[k];

                        listIntSoma.Add(soma);
                        listStringSoma.Add("Menor Soma é: " + matTopo[i] + " + " + matMeio[j] + " + " + matBase[k] + " que é iguál a: " + soma);

                        //Console.WriteLine(listStringSoma[listStringSoma.Count - 1]);

                        k++;

                        if (k == matBase.Length & j == (matMeio.Length - 1))
                        {
                            i++;
                            break;
                        }

                        if (k == matBase.Length)
                        {
                            j++;
                            k = 0;
                        }

                    }
                }
            }

            for(int w = 0; w < listIntSoma.Count; w++)
            {
                if(w == 0)
                {
                    menorSoma = listIntSoma[w];
                    indiceMenorSoma = w;
                }
                else
                {
                    if(listIntSoma[w] < menorSoma)
                    {
                        menorSoma = listIntSoma[w];
                        indiceMenorSoma = w;
                    }
                }
            }

            //Console.WriteLine("\n\n");

            //Console.WriteLine("------------------------------------------------------\n\n");

            Console.WriteLine(listStringSoma[indiceMenorSoma]);

            Console.WriteLine("\n\n");

            Console.WriteLine("------------------------------------------------------\n\n");

            Console.WriteLine("Pressione ENTER para sair...");
            Console.Read();

        }
    }
}
