using ControleDeGastos.Managers;

namespace ControleGastos.Relatório
{
    internal class PerguntasRelatorio
    {
        public static void PerguntaRelatorio()
        {
            Manager Manager = new Manager();
            while (true)
            {
                Console.WriteLine("================================================");
                Console.WriteLine("Relatórios");
                Console.WriteLine("\n[1] - Relatório Financeiro");
                Console.WriteLine("[2] - Sair");
                Console.WriteLine("================================================");
                Console.Write("Opção: ");
                string opcao = Console.ReadLine()!.Trim();

                switch(opcao)
                {
                    case "1":
                        Manager.GerarRelatorioFinanceiro();
                        break;
                    case "2":
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        break;
                }
            }
        }
    }
}
