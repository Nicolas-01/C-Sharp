
//******************** 
//***** ATENÇÃO ******
//********************

// Este arquivo contém o conteúdo de todos os arquivos do exercício "HerançaCliente".
// Foi criado para facilitar a visualização, permitindo que o código completo seja lido em um só lugar,
// sem a necessidade de abrir vários arquivos individualmente.


// -------- Arquivo Program.cs --------

using HerancaCliente;

Cliente c = new Cliente();
c.Codigo = 1;
c.Nome = "Ana";
c.Mostrar();

Cliente c2 = new Cliente(10, "Lucia");
c2.Mostrar();

ClienteFisico cf = new ClienteFisico();
cf.Rg = 100;
cf.Codigo = 2;
cf.Nome = "Bia";
cf.Mostrar();

ClienteFisico cf2 = new ClienteFisico(20, "Beatriz", 2000);
cf2.Mostrar();

ClienteJuridico cj = new ClienteJuridico();
cj.Codigo = 3;
cj.Nome = "Leo SA";
cj.Cnpj = 1000;
cj.Mostrar();

ClienteJuridico cj2 = new ClienteJuridico(30, "Leonardo Ltda", 3333);
cj2.Mostrar();


// -------- Arquivo (classe) Cliente.cs --------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class Cliente
    {
        protected int codigo;
        protected string? nome;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public virtual void Mostrar()
        {
            Console.WriteLine("Código: " + Codigo +
            "\tNome: " + Nome);
        }
        public Cliente(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
        public Cliente()
        {

        }
    }
}


// -------- Arquivo (classe) ClienteFisico.cs --------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{// sublasse / Classe derivada : classe base/superclasse
    public class ClienteFisico : Cliente
    {
        public int Rg { get; set; }
        public override void Mostrar()
        {
            Console.WriteLine("Rg: " + Rg);
        }
        public ClienteFisico(int codigo, string nome, int rg) : base(codigo, nome)
        {
            Rg = rg;
        }
        public ClienteFisico()
        {
        }

    }
}

// -------- Arquivo (classe) ClienteJuridico.cs --------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class ClienteJuridico : Cliente
    {
        public int Cnpj { get; set; }
        public override void Mostrar()
        {
            base.Mostrar();//chamar o método Mostrar da classe base
            Console.WriteLine("Cnpj: " + Cnpj);
        }
        public ClienteJuridico(int codigo, string nome, int cnpj) : base(codigo, nome)
        {
            Cnpj = cnpj;
        }
        public ClienteJuridico()
        {
        }
    }
}
