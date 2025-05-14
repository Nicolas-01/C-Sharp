using System.Security.Cryptography.X509Certificates;
using AgregacaoVenda;

Comprador comprador = new Comprador(1000);
Vendedor vendedor = new Vendedor();
Produto p1 = new Produto("Mouse", 50);
Produto p2 = new Produto("Teclado", 100);

Venda venda = new Venda();
venda.Vend = vendedor; // agregação
venda.Comp = comprador;
venda.VetProduto = new List<Produto>();
venda.AdicionarProduto(p1);
venda.AdicionarProduto(p2);

venda.MostrarAtributos();