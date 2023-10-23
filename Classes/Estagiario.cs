using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GerenciarFuncionarios.Classes
{
    public class Estagiario : Funcionarios
    {
        public Estagiario(string nome, int id, string nascimento, string cargo, string telefone)
        {
            this.nome = nome;
            this.id = id;
            this.nascimento = nascimento;
            this.cargo = cargo;
            this.telefone = telefone;
            this.salario = 1000;
            this.percentualReajuste = 0.05;
            this.numppr = 0.5;
        }
        public override void informacoes(double valorReajuste, double valorPPR)
        {
            Console.WriteLine($"Olá, meu nome é {this.nome}, sou {this.cargo} no Senai, trabalho como Estagiário.\nEu espero logo ser contratado como efetivo.\nReajuste Salarial: R$ {valorReajuste}.\nPPR: R$ {valorPPR}.\n");
        }
    }
}
