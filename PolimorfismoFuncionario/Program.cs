using PolimorfismoFuncionario;

Funcionario f = new Funcionario(1, "Ana", 1000);
Console.WriteLine($"Bonificação do Funcionário: {f.CalcularBonificacao():c}");

Secretario s = new Secretario(2, "Bia", 1000);
Console.WriteLine($"Bonificação do Secretário: {s.CalcularBonificacao():c}");

Gerente g = new Gerente(3, "Teo", 1000);
Console.WriteLine($"Bonificação do Gerente: {g.CalcularBonificacao():c}");

Diretor d = new Diretor(4, "Lia", 1000);
Console.WriteLine($"Bonificação do Diretor: {d.CalcularBonificacao():c}");

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

gerenciador.TotalizadorBonificacao(f);
gerenciador.TotalizadorBonificacao(s);
gerenciador.TotalizadorBonificacao(g);
gerenciador.TotalizadorBonificacao(d);
Console.WriteLine($"\nTotal de Bonificação: {gerenciador.MostrarTotalBonificacao():c}");