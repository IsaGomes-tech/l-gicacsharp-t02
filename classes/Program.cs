using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica13
{   //Definição da classe Carro
    internal class Carro
    {
        //Propriedade pública: Pode seer acessada e modificada fora da classe
        public string Marca { get; set; } // Publica a propriedade marca

        //Propriedade provada: Não pode ser acessada ou modificada fora da classe
        private string Modelo { get; set; } // Privada, acessível apenas dentro da classe

        //Propriedade privada com um campo e um método getter e setter personalizados
        private int _ano; //Campo privado

        public int Ano
        {
            get { return _ano; } // Getter, para acessar o valor do campo privado
            set
            {
                if(value > 1900 && value <= DateTime.Now.Year) // Verificação para garantir um valor válido{
                {
                    _ano = value;
                }
                else
                {
                    Console.WriteLine("Ano inválido.");
                }
            }
        }
        // Método público para exibir informações do carro
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}"); // Acesso ao modelo é restrito por ser privado
            Console.WriteLine($"Ano: {Ano}");
        }
        //Método para calcular a idade do carro
        public int CalcularIdade()
        {
            int anoAtual = DateTime.Now.Year;
            return anoAtual - Ano;
        }

        // Método para definir o modelo do carro ( com exemplo de uso de propriedade privada )
        public void DefinirModelo(string modelo)
        {
            Modelo = modelo; // Acessando a propriedade privada dentro da classe
        }
    }

    internal class Program
    {
        static void Main(string[]args)
        {
            //Criando um objeto da classe Carro
            Carro meuCarro = new Carro();

            //Atribuindo valores às propriedades públicas e privadas
            meuCarro.Marca = "Toyota";
            meuCarro.DefinirModelo("Corolla");//Usando método para definir modelo pois é privado
            meuCarro.Ano = 2020; // A propriedade Ano é pública mas com uma validação interna

            //Exibindo informações do carro
            meuCarro.ExibirInformacoes();

            //Calculando e exibindo a idade do carro
            int idadeCarro = meuCarro.CalcularIdade();
            Console.WriteLine($"Idade do carro: {idadeCarro} anos.");

            //Mantendo o console aberto
            Console.ReadLine();
        }
    }
}