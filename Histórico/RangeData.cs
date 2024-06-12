using ControleDeGastos;
using ControleDeGastos.Managers;

namespace ControleGastos.Histórico
{
    internal class RangeData
    {
        public void BuscarDatas()
        {
            DateOnly dataInicial;
            DateOnly dataFinal;

            Console.WriteLine("Buscar por Range de Datas\n");

            if (!Manager.despesas.Any() && !Manager.receitas.Any())
            {
                Console.WriteLine("Não existem despesas e receitas na lista!");
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
                    Console.WriteLine("Data inválida, use o formato: (dd/MM/yyyy)");
                }
                else if (dataInicial > dataFinal)
                {
                    Console.Clear();
                    Console.WriteLine("A data inicial não pode ser maior que a final!");
                }
                else
                {
                    break;
                }
            }

            Console.Clear();

            Manager.despesas.Where(d => d.Date >= dataInicial && d.Date <= dataFinal).ToList().
                ForEach(item => Console.WriteLine($"Despesa: Id: {item.Id}, Data: {item.Date}, Valor: R$-{item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}"));

            Manager.receitas.Where(d => d.Date >= dataInicial && d.Date <= dataFinal).ToList().
                ForEach(item => Console.WriteLine($"Receita: Id: {item.Id}, Data: {item.Date}, Valor: R${item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}"));
        }
    }
}
