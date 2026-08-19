using System;

namespace enums
{
    class Program
    {
        struct Item
        {
            public Item(double Valor, string? Nome, EProdutoTipo Tipo)
            {
                Valor = valor;
                Nome = nome;
                Tipo = tipo;
            }
            public double valor;
            public string? nome;
            public EProdutoTipo tipo; // declaração de um item do tipo do enum
        }

        enum EProdutoTipo // enum declarado 
        {
            Produto = 1,
            Servico = 2
        }
        static void Main(string[] args)
        {
            var mouse = new Item(39.99, "Mouse", EProdutoTipo.Produto);
            var mecanico = new Item(300.00, "revisão de carro", EProdutoTipo.Servico);
        }
    }
}