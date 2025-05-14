//******************** 
//***** ATENÇÃO ******
//********************

// Este arquivo contém o conteúdo de todos os arquivos do exercício "PolimorfismoFuncionario".
// Foi criado para facilitar a visualização, permitindo que o código completo seja lido em um só lugar,
// sem a necessidade de abrir vários arquivos individualmente.


// -------- Arquivo Program.cs --------

using PolimorfismoFuncionario;

Funcionario f = new Funcionario(1, "Ana", 1000);
Console.WriteLine($"Bonificação do Funcionário: {f.CalcularBonificacao():c}");

Secretario s = new Secretario(2, "Bia", 1000);
Console.WriteLine($"Bonificação do Secretário: {s.CalcularBonificacao():c}");

Gerente g = new Gerente(3, "Teo", 1000);
Console.WriteLine($"Bonificação do Gerente: {g.CalcularBonificacao():c}");

Diretor d = new Diretor(4, "Lia", 1000);
Console.WriteLine($"Bonificação do Diretor: {d.CalcularBonificacao():c}");

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

gerenciador.TotalizadorBonificacao(f);
gerenciador.TotalizadorBonificacao(s);
gerenciador.TotalizadorBonificacao(g);
gerenciador.TotalizadorBonificacao(d);
Console.WriteLine($"\nTotal de Bonificação: {gerenciador.MostrarTotalBonificacao():c}");


// -------- Arquivo (classe) Funcionario.cs --------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class Funcionario
    {
        protected int codigo;
        protected string? nome;
        protected double salario;

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

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public virtual double CalcularBonificacao()
        {
            return Salario * 10 / 100;
        }
    }
}

// -------- Arquivo (classe) Secretario.cs --------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class Secretario : Funcionario
    {
        public Secretario(int codigo, string nome, double salario) : base(codigo, nome, salario)
        {

        }
    }
}


// -------- Arquivo (classe) Gerente.cs --------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class Gerente : Funcionario
    {
        public Gerente(int codigo, string nome, double salario) : base(codigo, nome, salario)
        {

        }
        public override double CalcularBonificacao()
        {
            return Salario * 15 / 100;
        }
    }
}


// -------- Arquivo (classe) Diretor.cs --------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class Diretor : Funcionario
    {
        public Diretor(int codigo, string nome, double salario) : base(codigo, nome, salario)
        {

        }
        public override double CalcularBonificacao()
        {        //traz o cálculo  da base aplicando 10% 
            return base.CalcularBonificacao() + 1000;
        }
    }
}


// -------- Arquivo (classe) GerenciadorBonificacao.cs --------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoFuncionario
{
    public class GerenciadorBonificacao
    {
        private double totalBonificacao;
        public double TotalBonificacao
        {
            get { return totalBonificacao; }
            set { totalBonificacao = value; }
        }

        public GerenciadorBonificacao()
        {
            TotalBonificacao = 0;
        }

        public void TotalizadorBonificacao(Funcionario funcionario)
        {
            TotalBonificacao += funcionario.CalcularBonificacao();
        }
        public void TotalizadorBonificacao(Secretario secretario)
        {
            TotalBonificacao += secretario.CalcularBonificacao();
        }
        public void TotalizadorBonificacao(Gerente gerente)
        {
            TotalBonificacao += gerente.CalcularBonificacao();
        }
        public void TotalizadorBonificacao(Diretor diretor)
        {
            TotalBonificacao += diretor.CalcularBonificacao();
        }
        public double MostrarTotalBonificacao()
        {
            return TotalBonificacao;
        }
    }
}