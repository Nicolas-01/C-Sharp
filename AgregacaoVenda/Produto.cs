using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public double Preco { get; set; }
        private static int Numero { get; set; }
        static Produto() // Código do produto
        {
            Numero = 500;
        }
        public Produto(string? nome, double preco)
        {
            Numero++;
            Codigo = Numero;
            Nome = nome;
            Preco = preco;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Codigo: {Codigo}\tNome: {Nome}\tPreço: {Preco:c}");
        }
    }
}