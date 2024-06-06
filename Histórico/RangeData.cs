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
            bool encontrou = false;

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

            foreach (DespesasReceitas item in Manager.despesas)
            {
                if (item.Date >= dataInicial && item.Date <= dataFinal)
                {
                    encontrou = true;
                    Console.WriteLine($"Despesa: Data: {item.Date}, Valor: R$-{item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
                }
            }

            foreach (DespesasReceitas item in Manager.receitas)
            {
                if (item.Date >= dataInicial && item.Date <= dataFinal)
                {
                    encontrou = true;
                    Console.WriteLine($"Receita: Data: {item.Date}, Valor: R${item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
                }
            }
      
            if (!encontrou)
            {
                Console.WriteLine("Não foi encontrado Despesas e Receitas nas Datas estipuladas!");
            }
        }
    }
}
