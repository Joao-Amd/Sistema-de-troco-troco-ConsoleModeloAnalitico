using System;
namespace sistema_troco
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota, quociente, resto;
            double n;
            Console.Write("Informe o valor para saque: ");
            n = double.Parse(Console.ReadLine());

            resto = (int)(n * 100 + 0.5);

            //  NOTAS
            nota = 100;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % (nota * 100);

            nota = 50;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % (nota * 100);

            nota = 20;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % (nota * 100);

            nota = 10;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % (nota * 100);

            nota = 5;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % (nota * 100);

            nota = 2;
            quociente = resto / (nota * 100);
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % (nota * 100);

            Console.WriteLine("MOEDAS");

            //Moedas

            double moedas = 100;
            quociente = resto / (int)moedas;
            moedas = moedas / 100;
            Console.WriteLine(quociente + " moeda(s) de R$ " + moedas.ToString("F2"));
            resto = resto % 100;

            moedas = 50;
            quociente = resto / (int)moedas;
            moedas = moedas / 100;
            Console.WriteLine(quociente + " moeda(s) de R$ " + moedas.ToString("F2"));
            resto = resto % 50;

            moedas = 25;
            quociente = resto / (int)moedas;
            moedas = moedas / 100;
            Console.WriteLine(quociente + " moeda(s) de R$ " + moedas.ToString("F2"));
            resto = resto % 25;

            moedas = 10;
            quociente = resto / (int)moedas;
            moedas = moedas / 100;
            Console.WriteLine(quociente + " moeda(s) de R$ " + moedas.ToString("F2"));
            resto = resto % 10;

            moedas = 5;
            quociente = resto / (int)moedas;
            moedas = moedas / 100;
            Console.WriteLine(quociente + " moeda(s) de R$ " + moedas.ToString("F2"));
            resto = resto % 5;
        }
    }
}