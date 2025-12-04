using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace logica14
{
    //Classe base (superclasse)
    internal class Animal
    {
        //Propriedades da classe Animal
        public string Nome {  get; set; }

        //Método que será sobrecarregado nas classes derivadas
        public virtual void EmitirSom()
        {
            Console.WriteLine($"O animal {Nome} emite um som");
        }
    }
    // Classe derivada (subclasse)
    internal class  Cachorro : Animal 
    {
        // Sobrescrevendo o método EitirSom
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} late: Au Au!");
        }
    }
    // Outra classe derivada
    internal class Gato: Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} mia: Miau!");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            // Criando instâncias das classes derivadas
            Animal meuCachorro = new Cachorro() { Nome ="Rex"};
            Animal meuGato = new Gato() { Nome = "Félix" };
            Animal meuCoelho = new Animal() { Nome = "Lulu" };

            //Chamando o método EmitirSom para cada animal
            meuCachorro.EmitirSom(); // Rex late : Au au!
            meuGato.EmitirSom(); // Félix mia: Miau!
            meuCoelho.EmitirSom();
            //Utilizando Polimorfismo: Array de animais
            Animal[] animais = {meuCachorro, meuGato, meuCoelho};
            foreach (var animal in animais)
            {
                animal.EmitirSom(); // Cada objeto chama o método adequado da sua classe
            }
        }
    }
}