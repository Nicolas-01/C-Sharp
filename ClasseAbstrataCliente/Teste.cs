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
