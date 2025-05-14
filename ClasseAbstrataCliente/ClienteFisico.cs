using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataCliente
{
    public class ClienteFisico : Cliente
    {
        public int Rg { get; set; }

        public override void Mostrar() //Polimorfismo
        {
            base.Mostrar(); //apresentando Código e Nome
            Console.WriteLine($"RG: {Rg}");
        }

        public override void Cadastrar(int codigo, string nome, int documento)
        {
            Codigo = codigo;
            Nome = nome;
            Rg = documento;
        }

        public override void VerificaIdade()
        { // polimorfismo
            if(Idade > 0 && Idade < 40)
                Console.Write("\nCliente Físico");
        }
    }
}