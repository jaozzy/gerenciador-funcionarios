using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GerenciarFuncionarios.Classes
{
    public class Temporario : Funcionarios
    {
        public Temporario(string nome, int id, string nascimento, string cargo, string telefone)
        {
            this.nome = nome;
            this.id = id;
            this.nascimento = nascimento;
            this.cargo = cargo;
            this.telefone = telefone;
            this.salario = 2500;
            this.percentualReajuste = 0.07;
            this.numppr = 1;
        }
        public override void informacoes(double valorReajuste, double valorPPR)
        {
            Console.WriteLine($"Olá, meu nome é {this.nome}, sou {this.cargo} no Senai, trabalho como funcionário Temporário.\nEu quero ser efetivo nessa empresa por que ela é muito boa para trabalhar.\nReajuste Salarial: R$ {valorReajuste}.\nPPR: R$ {valorPPR}.\n");
        }
    }
}
