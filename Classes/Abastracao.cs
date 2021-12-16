using System;

namespace Classes
{
    public class Abstracao
    {

        class Program
        {
            static void Main(string[] args)
            {
                var pagamentoBoleto = new PagamentoBoleto();

            }
        }
        // se eu não coloco o modificador, automaticamente é reconhecido como private

        class Pagamento
        {

            //Propriedades
            public DateTime Venvimento;
            //Métodos
            public void Pagar()
            {
                ConsultarSaldoDoCartao("212312");
            }
            private void ConsultarSaldoDoCartao(string numcartao)
            {

            }
        }
        //ao herdar a classe pai, o filho tem acesso a todas a propriedades e métodos que são públicos
        //não temos heranças múltiplas no c#
        class PagamentoBoleto : Pagamento
        {

        }


    }
}