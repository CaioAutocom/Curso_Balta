using System;

namespace Generic
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     var person = new Person();
        //     var payment = new Payment();
        //     var subscription = new Subscription();
        //     //instancio a classe informando quais classes eu posos trabalhar
        //     //dentro de <>
        //     var context = new DataContext<Person, Payment, Subscription>();
        //     context.Save(person);
        //     context.Save(payment);
        //     context.Save(subscription);

        // }

    }
    //eu defino na classe o tipo de classes que ela pode receber
    //declaração feita com <>
    //o uso dos métodos é separado pelo tipo como parâmetro
    public class DataContext<T, U, V>
    {
        public void Save(T entity)
        {
            Console.WriteLine("Primeiro tipo");
        }
        public void Save(U entity)
        {
            Console.WriteLine("Segundo tipo");
        }
        public void Save(V entity)
        {
            Console.WriteLine("Terceiro tipo");
        }
    }
    public class Person { }
    public class Payment { }
    public class Subscription { }
}