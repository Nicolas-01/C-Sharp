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