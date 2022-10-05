using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
class Program
{
    public void gira(List<int> vet, int d)
    {
        int aux, quant = 1;
        for (int i = 0; i < vet.Count; i++)
        {
            aux = vet[i];
            if (i != vet.Count - 1)
            {
                vet[i] = vet[i + 1];

                vet[i + 1] = aux;

            }
            else
            {

                vet[vet.Count - 1] = aux;

                Console.WriteLine("quantidade de rotação: " + quant);
                if (quant < d)
                {
                    i = -1;
                    quant++;
                }
                else
                {
                    break;
                }
            }
            for (int j = 0; j < vet.Count; j++)
            {
                Console.Write(vet[j] + " ");
            }
            Console.WriteLine();

        }
    }
    static void Main(string[] args)
    {
        Program p = new Program();
        int d;
        List<int>vet = new List<int> { 1, 2, 3, 4, 5 };
        Console.Write("Digite a quantidade de rotações desejadas: ");
        d = Int32.Parse(Console.ReadLine());
        p.gira(vet, d);  
    }
}

