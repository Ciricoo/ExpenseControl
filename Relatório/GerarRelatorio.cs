using ControleDeGastos.Managers;

namespace ControleGastos.Relatório
{
    internal class GerarRelatorio
    {
        public void GerarRelatorioFinanceiro()
        {
            DateOnly dataInicial;
            DateOnly dataFinal;

            Console.Clear();

            Console.WriteLine("Gerar Relatório\n");

            if (!Manager.despesas.Any() && !Manager.receitas.Any())
            {
                Console.WriteLine("Nenhuma despesa e receita foi adicionada!");
                return;
            }
            while (true)
            {
                Console.WriteLine("Data inicial: (dd/MM/yyyy)");
                string data1 = Console.ReadLine()!;
                Console.WriteLine("Data final: (dd/MM/yyyy)");
                string data2 = Console.ReadLine()!;

                if (!DateOnly.TryParse(data1, out dataInicial) || !DateOnly.TryParse(data2, out dataFinal))
                {
                    Console.Clear();
                    Console.WriteLine("Data inválida, use o formato: (dd/MM/yyyy)");
                }
                else if(dataInicial > dataFinal)
                {
                    Console.Clear();
                    Console.WriteLine("A data inicial não pode ser maior que a final!");
                }
                else
                {
                    break;
                }
            }
            

            var despesasFiltradas = Manager.despesas.Where(t => t.Date >= dataInicial && t.Date <= dataFinal);
            var receitaFiltradas = Manager.receitas.Where(t => t.Date >= dataInicial && t.Date <= dataFinal);

            float totalDespesas = despesasFiltradas.Sum(t => t.Valor);
            float totalReceitas = receitaFiltradas.Sum(t => t.Valor);
            float total = totalReceitas - totalDespesas;

            Console.Clear();
            Console.WriteLine("Relatório Financeiro\n");
            Console.WriteLine($"Período: {dataInicial:dd/MM/yyyy} - {dataFinal:dd/MM/yyyy}");
            Console.WriteLine($"Total de Receitas: R$ {totalReceitas}");
            Console.WriteLine($"Total de Despesas: R$-{totalDespesas}");
            Console.WriteLine($"Saldo Final: R${total}");
           
        }
    }
}
