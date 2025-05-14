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