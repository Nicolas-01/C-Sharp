using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataCliente
{
    public class ClienteJuridico : Cliente
    {
        public int Cnpj { get; set; }

        public override void Mostrar() //Polimorfismo
        {
            base.Mostrar(); //apresentando Código e Nome
            Console.WriteLine($"CNPJ: {Cnpj}");
        }

        public override void Cadastrar(int codigo, string nome, int documento)
        {
            Codigo = codigo;
            Nome = nome;
            Cnpj = documento;
        }
        
        public override void VerificaIdade()
        { // polimorfismo - sobrescrevendo a lógica do anterior
            if(Idade >= 40)
                Console.Write("\nCliente Jurídico");
        }
    }
}
