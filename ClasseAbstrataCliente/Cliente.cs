using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataCliente
{
    public abstract class Cliente
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Mostrar() // polimorfismo | método abstrato - não tem lógica
        {
            Console.Write($"\nCódigo: {Codigo}\tNome: {Nome}\t Idade: {Idade} anos \t");
        }

        public abstract void Cadastrar(int codigo, string nome, int documento); // método abstrato - não tem lógica
        // documento representará o rg ou cnpj

        public abstract void VerificaIdade(); // método abstrato - não tem lógica
    }
}
