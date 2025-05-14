using HerancaCliente;

Cliente c = new Cliente();
c.Codigo = 1;
c.Nome = "Ana";
c.Mostrar();

Cliente c2 = new Cliente(10, "Lucia");
c2.Mostrar();

ClienteFisico cf = new ClienteFisico();
cf.Rg = 100;
cf.Codigo = 2;
cf.Nome = "Bia";
cf.Mostrar();

ClienteFisico cf2 = new ClienteFisico(20, "Beatriz", 2000);
cf2.Mostrar();

ClienteJuridico cj = new ClienteJuridico();
cj.Codigo = 3;
cj.Nome = "Leo SA";
cj.Cnpj = 1000;
cj.Mostrar();

ClienteJuridico cj2 = new ClienteJuridico(30, "Leonardo Ltda", 3333);
cj2.Mostrar();