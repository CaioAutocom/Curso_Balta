using System;

namespace Classes
{
    public class Struct
    {
        // static void Main(string[] args)
        // {
        //     var customer = new Customer();

        //     customer.name = "Caio";
        //     Console.WriteLine(customer.name);

        // }
        //se eu trocar struct por class, irá funcionar normalmente, a diferença entre os dois é que a classe é um tipo de referência, 
        //onde só é armazenado o endereço dos dados, enquanto o struct armazena os dados na memória Stack, e os de referência, ficam na memória Heap

        struct Customer

        {
            public string name;
        }

    }
}