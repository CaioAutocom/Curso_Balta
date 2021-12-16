using System;

namespace Curso
{
    public class Program
    {
        static void Main(string[] args)
        {
            //tipos diferentes de inicializar um objeto
            //tipo 1
            Animal animal1 = new Animal("Animal2", "Som2", 50, 100);
            //tipo 2
            Animal animal2 = new Animal
            {
                name = "Animal2",
                height = 15,
                weight = 12,
                sound = "Som2"
            };
            Console.WriteLine(animal1.toString());
            Console.WriteLine(animal2.toString());
            //criando um cachorro genérico que vai iniciar o primeiro construtor, já que não passei nenhum parâmetro
            Dog spike = new Dog();
            //o primeiro resultado exibirá um cachorro com os atributos padrões
            Console.WriteLine(spike.toString());
            //Sobrescrevendo os dados do cachorro passando os parâmetros para iniciar o segundo construtor que contém parâmetros, e adicionando a nova informação, que seria a comida favorita
            spike = new Dog(name: "Spike", sound: "AUUU!", 55, 10, "Carne");
            //exibindo a informação atualizada
            Console.WriteLine(spike.toString());
            //números de animais na memória
            Console.WriteLine("Número de animais presentes:" + Animal.getNumofAnimals());

        }
    }
    class Animal
    {
        //atributos da classe
        public string name { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }
        static int numOfAnimals = 0;

        //método construtor genérico, se não for passado nenhum parâmetro ao iniciar o objeto
        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.name = "No Name";
            this.sound = "No Sound";
            //count para informar a quantidade de objetos instanciados
            numOfAnimals++;
        }
        //construtor com parâmetros
        public Animal(string name, string sound, double height, double weight)
        {
            this.height = height;
            this.weight = weight;
            this.sound = sound;
            this.name = name;
            //count para informar a quantidade de objetos instanciados
            numOfAnimals++;
        }
        // método para exibir os atributos na tela
        public virtual string toString()
        {
            return String.Format("{0} tem {1} de altura, pesa {2} Kgs, e diz {3}", name, height, weight, sound);
        }
        //método para informar a quantidade de objetos na memória
        public static int getNumofAnimals()
        {
            return numOfAnimals;
        }
        
    }
    // Classe Dog que herda as informações da classe pai Animal
    class Dog : Animal
    {
        //atributo específico da classe
        public string favFood { get; set; }
        // 1° método construtor que também inicializa os atributos da classe pai utilizando o ':base()', junto com os próprios da classe
        public Dog()
        : base()
        {
            this.favFood = "Nenhuma Comida favorita";
        }
        //2 ° método construtor que inicializa a classe passando os parâmetros e atualizando os parâmetros informados na classe pai ':base(name, sound, weight, height)'
        public Dog(string name, string sound, double height, double weight, string favFood)
            : base(name, sound, weight, height)
        {
            this.favFood = favFood;
        }
        //sobrescrevendo a classe que apresenta os atributos do objeto na tela, dessa vez adicionando a comida favorita, se for informada ao instanciar o objeto
        public override string toString()
        {
            return String.Format("{0} tem {1} de altura, pesa {2} Kgs, e diz {3}, e sua comida favorita é {4}", name, height, weight, sound, favFood);
        }
    }
}
