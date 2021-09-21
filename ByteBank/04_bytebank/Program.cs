using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";
            Console.WriteLine(contaDoBruno.saldo);
            contaDoBruno.Sacar(50);
            bool resultadoSaque = contaDoBruno.Sacar(500);

            Console.WriteLine(resultadoSaque);
            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno:" + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela:" + contaDaGabriela.saldo);

            bool resultadodaTransferencia = contaDoBruno.Transferir(2000, contaDaGabriela);
            contaDoBruno.Transferir(200, contaDaGabriela);

            Console.WriteLine("Saldo do Bruno:" + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela:" + contaDaGabriela.saldo);
            Console.ReadLine();
        }
    }
}
