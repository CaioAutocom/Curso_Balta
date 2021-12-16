using System;

namespace Delegate
{
    class Program
    {
        //o método a ser utilizado precisa ter a mesma assinatura que a função
        //delegada na classe
        static void PagamentoBoleto(double valor)
        {
            Console.WriteLine($"Pago o valor de: {valor}");
        }
        // static void Main(string[] args)
        // {
        //     // uso do delegate 
        //     var pagar = new Pagamento.Pagar(PagamentoBoleto);
        //     pagar(30);
        // }

    }

    public class Pagamento
    {
        //delegate eu declaro o metodo que vou usar em outro lugar
        public delegate void Pagar(double valor);
    }





}
