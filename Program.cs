using System;
using System.Globalization;
using System.Numerics;
using System.Linq;

namespace POO_TarefaMediaAltura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número de pessoas a serem medidas: ");
            //Criando e recebendo a variável de entrada. Usar ponto, ao invés de vírgula ao informar a altura em metros.
            double n = double.Parse(Console.ReadLine());
            //Criando o vetor com o número da variável de entrada (n)
            double[] vect = new double[(int)n];

            //Criação do laço para criar um vetor conforme o tamanho indicado pelo usuário
            for (int i = 0; i < n; i++)
            {
                Console.Write("Informe a altura da pessoa "+(i+1)+ " :");   //(i+1) informa a sequência das pessoas
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            //Calcula a média
            double media = vect.Average();

            Console.WriteLine("A média de altura das pessoas informadas é: "+(media).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
