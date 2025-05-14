//******************** 
//***** ATENÇÃO ******
//********************

// Este arquivo contém o conteúdo de todos os arquivos do exercício "ComposicaoNotaFiscal".
// Foi criado para facilitar a visualização, permitindo que o código completo seja lido em um só lugar,
// sem a necessidade de abrir vários arquivos individualmente.


// -------- Arquivo Program.cs --------

using ComposicaoNotaFiscal;


NotaFiscal nf = new NotaFiscal(1, "01/04/2025");

ItemNotaFiscal it1 = new ItemNotaFiscal(10);
ItemNotaFiscal it2 = new ItemNotaFiscal(21);

nf.AdicionarItens(it1);
nf.AdicionarItens(it2);

nf.MostrarAtributos();
nf = null;
//para excluir o OBJETO da nota fiscal com o destrutor.
// retirar a referência de memória.
GC.Collect(); // força a chamada do destrutor.


// -------- Arquivo (classe) NotaFiscal.cs --------

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


// -------- Arquivo (classe) ItemNotaFiscal.cs --------

using System;
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