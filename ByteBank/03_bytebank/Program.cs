using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contadaGabriela = new ContaCorrente();
            contadaGabriela.titular = "Gabriela";
            contadaGabriela.agencia = 863;
            contadaGabriela.numero = 863452;


            ContaCorrente contadaGabrielaCosta = new ContaCorrente();
            contadaGabrielaCosta.titular = "Gabriela";
            contadaGabrielaCosta.agencia = 863;
            contadaGabrielaCosta.numero = 863452;

            Console.WriteLine();

            Console.WriteLine("igualdade de tipo de referência: " + (contadaGabriela == contadaGabrielaCosta));

            int idade = 27;
            int idades = 27;

            Console.WriteLine("igualdade de tipo de valor: " + (idade == idades));

            contadaGabriela = contadaGabrielaCosta;
            Console.WriteLine(contadaGabriela == contadaGabrielaCosta);

            contadaGabriela.saldo = 300;

            Console.WriteLine(contadaGabriela.saldo);
            Console.WriteLine(contadaGabrielaCosta.saldo);


            Console.ReadLine();

          


        }
    }
}
