using GerenciarFuncionarios.Classes;
namespace GerenciarFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionarios efetivo1 = new Efetivo("Antoni", 189, "18 de Setembro de 1998", "Professor", "+55 (47) 99812-4561");
            double valorReajuste = efetivo1.reajusteSalarial();
            double valorPPR = efetivo1.resultadoPPR();
            efetivo1.informacoes(valorReajuste, valorPPR);
            Funcionarios temporario1 = new Temporario("Silvana", 712, "2 de Janeiro de 2000", "Auxiliar Administrativo", "+55 (47) 91290-9072");
            valorReajuste = temporario1.reajusteSalarial();
            valorPPR = temporario1.resultadoPPR();
            temporario1.informacoes(valorReajuste, valorPPR);
            Funcionarios estagiario1 = new Estagiario("Henrique", 330, "24 de Abril de 2003", "Auxiliar de Gerente de Recursos Humanos", "+55 (47) 98813-5712");
            valorReajuste = estagiario1.reajusteSalarial();
            valorPPR = estagiario1.resultadoPPR();
            estagiario1.informacoes(valorReajuste, valorPPR);
        }
    }
}