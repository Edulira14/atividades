using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Aula07Atividades
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        void atividade4()
        {
            Console.WriteLine("Digite a primeira nota:");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            double nota3 = double.Parse(Console.ReadLine());

            double maiorNota = Math.Max(nota1, Math.Max(nota2, nota3));

            Console.WriteLine("A maior nota é: " + maiorNota);
        }
    }
        void atividade3()
        {
            Console.WriteLine("Digite a primeira nota:");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            if (media > 6.0)
            {
                Console.WriteLine("Média superior à média mínima (6,0)");
            }
            else if (media == 6.0)
            {
                Console.WriteLine("Média igual à média mínima (6,0)");
            }
            else
            {
                Console.WriteLine("Média inferior à média mínima (6,0)");
            }
        }
    }
        void atividade2()
        {
            //Atividade2

            string nome;
            double media;


            Console.WriteLine("Digite o nome do aluno");
            nome = Console.ReadLine();
            Console.WriteLine($"Agora digite a media do aluno {nome}");
            media = double.Parse(Console.ReadLine());

            if (media >= 6.0)

            {
                Console.WriteLine("Parabens esse aluno foi aprovado");
            }

            Console.ReadKey();
        }

        void atividade1()
        {
            double numero;

            Console.WriteLine("Digite um número:");
            numero = double.Parse(Console.ReadLine());

            if (numero > 100)

            {
                numero = numero + 150;
            }

            Console.WriteLine("O valor de número é " + numero);

            Console.ReadKey();
        }

    }
}
