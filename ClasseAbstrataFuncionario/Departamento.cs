using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbastrataFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public List<Funcionario> VetF { get; set; }

        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public void Admitir(Funcionario f)
        {
            VetF.Add(f);
        }

        public void Demitir(int codigo)
        {
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                if (f.Codigo == codigo)
                {
                    VetF.Remove(f);
                    Console.WriteLine("\nExclusão realizada com sucesso!");
                }
            }
        }

        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;

            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt<Funcionario>(i);
                folha += f.CalcularSalario(diasUteis);
            }
            return folha;
        }

        public void ListarFuncionarios()
        {
            Console.WriteLine("\nDepartamento: " + Nome);
            foreach (var f in VetF)
            {
                f.MostrarAtributos();
            }
        }
    }
}