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