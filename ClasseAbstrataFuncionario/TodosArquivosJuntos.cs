//******************** 
//***** ATENÇÃO ******
//********************

// Este arquivo contém o conteúdo de todos os arquivos do exercício "ClasseAbstrataFuncionario".
// Foi criado para facilitar a visualização, permitindo que o código completo seja lido em um só lugar,
// sem a necessidade de abrir vários arquivos individualmente.


// -------- Arquivo Program.cs --------

using ClasseAbastrataFuncionario;

Assalariado a1 = new Assalariado(1, "Ana", 1000);
Assalariado a2 = new Assalariado(2, "Bia", 1000);
Comissionado c1 = new Comissionado(3, "Bel", 1000, 20);
Comissionado c2 = new Comissionado(4, "Lia", 1000, 30);

Departamento d1 = new Departamento(10, "TI");
d1.VetF = new List<Funcionario>();
d1.Admitir(a1);
d1.Admitir(c1);
d1.ListarFuncionarios();
Console.WriteLine($"\nTotal: {d1.CalcularFolha(30):c}");


Departamento d2 = new Departamento(11, "RH");
d2.VetF = new List<Funcionario>();
d2.Admitir(a2);
d2.Admitir(c2);

d2.ListarFuncionarios();
// d2.Demitir(4);
// d2.ListarFuncionarios();
Console.WriteLine($"\nTotal: {d2.CalcularFolha(30):c}");


// -------- Arquivo (classe) Funcionario.cs --------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbastrataFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }
        public abstract double CalcularSalario(int diasUteis);
        public virtual void MostrarAtributos()
        {
            Console.WriteLine($"Código: {Codigo} \tNome: {Nome} \tSalário {Salario:c}");
        }
    }
}


// -------- Arquivo (classe) Assalariado.cs --------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbastrataFuncionario
{
    public class Assalariado : Funcionario
    {
        public Assalariado(int codigo, string nome, double salario) : base(codigo, nome, salario)
        {
            //algum novo atributo
        }
        public override double CalcularSalario(int diasUteis)
        {
            return Salario / 30 * diasUteis;
        }
    }
}


// -------- Arquivo (classe) Comissionado.cs --------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbastrataFuncionario
{
    public class Comissionado : Funcionario
    {
        public double Porcentagem { get; set; }

        public Comissionado(int codigo, string nome, double salario, double porcentagem) : base (codigo, nome, salario)
        {
            Porcentagem = porcentagem;
        }
        public override void MostrarAtributos()
        {
            base.MostrarAtributos();//apresenta codigo, nome e salário
            Console.WriteLine($"Porcentagem: {Porcentagem:n} %");
        }
        public override double CalcularSalario(int diasUteis)
        {
            return (Salario / 30 * diasUteis) * Porcentagem / 100 + Salario;
        }
    }
}


// -------- Arquivo (classe) Departamento.cs --------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbastrataFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public List<Funcionario> VetF { get; set; }

        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public void Admitir(Funcionario f)
        {
            VetF.Add(f);
        }

        public void Demitir(int codigo)
        {
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                if (f.Codigo == codigo)
                {
                    VetF.Remove(f);
                    Console.WriteLine("\nExclusão realizada com sucesso!");
                }
            }
        }

        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;

            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                folha += f.CalcularSalario(diasUteis);
            }
            return folha;
        }

        public void ListarFuncionarios()
        {
            Console.WriteLine("\nDepartamento: " + Nome);
            foreach (var f in VetF)
            {
                f.MostrarAtributos();
            }
        }
    }
}