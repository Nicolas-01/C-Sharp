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