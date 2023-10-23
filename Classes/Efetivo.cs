using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GerenciarFuncionarios.Classes
{
    public class Efetivo : Funcionarios
    {
        public Efetivo(string nome, int id, string nascimento, string cargo, string telefone)
        {
            this.nome = nome;
            this.id = id;
            this.nascimento = nascimento;
            this.cargo = cargo;
            this.telefone = telefone;
            this.salario = 5000;
            this.percentualReajuste = 0.10;
            this.numppr = 2;
        }
        public override void informacoes(double valorReajuste, double valorPPR)
        {
            Console.WriteLine($"Olá, meu nome é {this.nome}, sou {this.cargo} no Senai, trabalho como funcionário Efetivo.\nReajuste Salarial: R$ {valorReajuste}.\nPPR: R$ {valorPPR}.\n");
        }
    }
}
