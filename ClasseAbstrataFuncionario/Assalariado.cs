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