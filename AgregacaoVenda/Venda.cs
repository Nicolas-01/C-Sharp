using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        public Vendedor Vend { get; set; }
        public List<Produto> VetProduto { get; set; }
        public Comprador Comp { get; set; }
        public void AdicionarProduto(Produto objetoProduto)
        {
            VetProduto.Add(objetoProduto);
            Vend.CalcularComissao(objetoProduto.Preco); // double
            Comp.DescontarVerba(objetoProduto.Preco);
        }
        public void MostrarAtributos()
        {
            Console.Write("\nVendedor");
            Vend.MostrarAtributos();
            Console.Write("Comprador verba: ");
            Comp.MostrarAtributos();
            foreach (Produto p in VetProduto)
                p.MostrarAtributos(); // classe Produto
        }
    }
}