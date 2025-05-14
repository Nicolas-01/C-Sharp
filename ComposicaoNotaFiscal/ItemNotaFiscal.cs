zusing System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class ItemNotaFiscal
    {
        public int Qtde { get; set; }
        public ItemNotaFiscal(int qtde)
        {
            Qtde = qtde;
        }
        ~ItemNotaFiscal()
        {
            Console.WriteLine("Destrutor Item Nota Fiscal!");
            //não precisa de "null" porque essa classe não tem ligação com outra.   
        }
    }
}
