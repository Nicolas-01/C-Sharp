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