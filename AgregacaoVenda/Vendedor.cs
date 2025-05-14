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