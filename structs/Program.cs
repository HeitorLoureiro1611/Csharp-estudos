using System;

namespace structs
{
    class Program
    {
        struct Pessoa // igual em c porém é necessário usar public pra declarações
        {
            // overload de construtor
            public Pessoa(int idade, double altura, string nome) // metodo construtor, mesma forma de um objeto
            {
                Idade = idade;
                Altura = altura;
                this.nome = nome; // forma alternativa de chamar a informação do construtor
            }
            public int Idade;
            public double Altura;
            public string nome;

            public int AnoNascimento() // metodo do struct
            {
                return 2026 - Idade;
            }
        }
        static void Main(String[] args)
        {
            var joao = new Pessoa(); // chamar uma pessoa na main é necessário usar o new pra construi-lo 
            joao.Idade = 19;
            joao.Altura = 1.78;
            joao.nome = "João da Silva";
            int idadejoao = joao.AnoNascimento();

            var maria = new Pessoa(30, 1.60, "Maria Pereira"); // declaração seguindo o construtor
            
            Console.WriteLine(idadejoao);
            Console.WriteLine(maria.AnoNascimento());
        }
    }
}