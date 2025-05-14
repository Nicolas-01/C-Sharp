//******************** 
//***** ATENÇÃO ******
//********************

// Este arquivo contém o conteúdo de todos os arquivos do exercício "AgregacaoVenda".
// Foi criado para facilitar a visualização, permitindo que o código completo seja lido em um só lugar,
// sem a necessidade de abrir vários arquivos individualmente.


// -------- Arquivo Program.cs --------

using System.Security.Cryptography.X509Certificates;
using AgregacaoVenda;

Comprador comprador = new Comprador(1000);
Vendedor vendedor = new Vendedor();
Produto p1 = new Produto("Mouse", 50);
Produto p2 = new Produto("Teclado", 100);

Venda venda = new Venda();
venda.Vend = vendedor; // agregação
venda.Comp = comprador;
venda.VetProduto = new List<Produto>();
venda.AdicionarProduto(p1);
venda.AdicionarProduto(p2);

venda.MostrarAtributos();


// -------- Arquivo (classe) Venda.cs --------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        public Vendedor Vend { get; set; }
        public List<Produto> VetProduto { get; set; }
        public Comprador Comp { get; set; }
        public void AdicionarProduto(Produto objetoProduto)
        {
            VetProduto.Add(objetoProduto);
            Vend.CalcularComissao(objetoProduto.Preco); // double
            Comp.DescontarVerba(objetoProduto.Preco);
        }
        public void MostrarAtributos()
        {
            Console.Write("\nVendedor");
            Vend.MostrarAtributos();
            Console.Write("Comprador verba: ");
            Comp.MostrarAtributos();
            foreach (Produto p in VetProduto)
                p.MostrarAtributos(); // classe Produto
        }
    }
}


// -------- Arquivo (classe) Produto.cs --------

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


// -------- Arquivo (classe) Comprador.cs --------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Comprador
    {
        public double Verba { get; set; }
        public Comprador(double verba)
        {
            Verba = verba;
        }
        public void DescontarVerba(double preco)
        {
            Verba -= preco;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"{Verba:c}\n");
        }
    }
}


// -------- Arquivo (classe) Vendedor.cs --------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Vendedor
    {
        public double Comissao { get; set; }
        public void CalcularComissao(double preco)
        {
            Comissao += preco * 2 / 100;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"\tComissão: {Comissao:c}");
        }
    }
}