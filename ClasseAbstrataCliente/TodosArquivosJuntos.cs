//******************** 
//***** ATENÇÃO ******
//********************

// Este arquivo contém o conteúdo de todos os arquivos do exercício "ClasseAbstrataCliente".
// Foi criado para facilitar a visualização, permitindo que o código completo seja lido em um só lugar,
// sem a necessidade de abrir vários arquivos individualmente.


// -------- Arquivo Program.cs --------

using ClasseAbstrataCliente;

//erro por não poder instanciar um objeto da classe base, pois ela é abstract
//Cliente c = new Cliente();

ClienteFisico cf = new ClienteFisico();
cf.Codigo = 1;
cf.Nome = "Ana";
cf.Rg = 1000;
cf.Idade = 35;
cf.VerificaIdade();
cf.Mostrar();

ClienteFisico cf2 = new ClienteFisico();
cf2.Cadastrar(11,"Bia", 1111);
cf2.Idade = 20;
cf2.VerificaIdade();
cf2.Mostrar();


ClienteJuridico cj = new ClienteJuridico();
cj.Codigo = 2;
cj.Nome = "Empresa SA";
cj.Cnpj = 1001;
cj.Idade = 40;
cj.VerificaIdade();
cj.Mostrar();

ClienteJuridico cj2 = new ClienteJuridico();
cj2.Cadastrar(22, "Empresa Ltda", 22222);
cj2.Idade = 54;
cj2.VerificaIdade();
cj2.Mostrar();

Console.Write("\n**Teste**");
Teste t = new Teste();

t.AvaliarIdade(cf2);
t.AvaliarIdade(cj2);


// -------- Arquivo (classe) Cliente.cs --------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataCliente
{
    public abstract class Cliente
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Mostrar() // polimorfismo | método abstrato - não tem lógica
        {
            Console.Write($"\nCódigo: {Codigo}\tNome: {Nome}\t Idade: {Idade} anos \t");
        }

        public abstract void Cadastrar(int codigo, string nome, int documento); // método abstrato - não tem lógica
        // documento representará o rg ou cnpj

        public abstract void VerificaIdade(); // método abstrato - não tem lógica
    }
}


// -------- Arquivo (classe) ClienteFisico.cs --------

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


// -------- Arquivo (classe) ClienteJuridico.cs --------

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


// -------- Arquivo (classe) Teste.cs --------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrataCliente
{
    public class Teste
    {
        // relacionamento / assossiação de dependência, por meio do parâmetro
        public void AvaliarIdade(Cliente objCliente)
        {
            objCliente.VerificaIdade(); 
        // sai da classe "Teste" e vai para a classe "Cliente", como o método "VerificaIdade" não tem lógica na classe "Cliente",
        // ele vai para "ClienteFisico" ou "ClienteJurídico".
        }
    }
}