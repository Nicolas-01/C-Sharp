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