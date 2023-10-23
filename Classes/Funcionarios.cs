using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciarFuncionarios.Interfaces;
namespace GerenciarFuncionarios.Classes
{
    public abstract class Funcionarios : IMetodos
    {
        public string nome;
        public int id;
        public string nascimento;
        public string cargo;
        public double salario;
        public string telefone;
        public double percentualReajuste;
        public double numppr;
        public double reajusteSalarial()
        {
            return this.salario + (this.salario * this.percentualReajuste);
        }
        public double resultadoPPR()
        {
            return this.numppr * this.salario;
        }
        public abstract void informacoes(double valorReajuste, double valorPPR);
    }
}
