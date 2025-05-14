using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNF { get; set; }
        public string Data { get; set; }

        //estabelecendo a composição
        //essa é a classe que tem o losango/diamante
        //a NotaFiscal é composta por VetItemNF
        public List<ItemNotaFiscal> VetItemNF { get; set; }
        public NotaFiscal(int numeroNF, string data)
        { //aqui é a representação da composição
            NumeroNF = numeroNF;
            Data = data;
            VetItemNF = new List<ItemNotaFiscal>();
        }
        public void AdicionarItens(ItemNotaFiscal item)
        {
            VetItemNF.Add(item);
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Número da Nota Fiscal: {NumeroNF}\tData: {Data}");
            Console.WriteLine("Itens:");
            foreach (var item in VetItemNF)
            {
                Console.WriteLine($"Quantidade: {item.Qtde}");
            }
        }
        ~NotaFiscal()
        {
            VetItemNF = null;
            // precisa de "null" porque tem ligação com ItemNotaFiscal.
            Console.WriteLine("Destrutor Nota Fiscal!");
        }
    }
}