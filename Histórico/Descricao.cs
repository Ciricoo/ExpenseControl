using ControleDeGastos;
using ControleDeGastos.Managers;

namespace ControleGastos.Histórico
{
    internal class Descricao
    {
        public void BuscarDescricao()
        {
            string descricao;
            Console.WriteLine("Buscar por Descrição\n");

            if (Manager.despesas.Any() is false && !Manager.receitas.Any())
            {
                Console.WriteLine("Não existem despesas e receitas na lista!");
                return;
            }

            while (true)
            {
                Console.WriteLine("Digite a descrição que deseja buscar:");
                descricao = Console.ReadLine()!.Trim();
                if (string.IsNullOrEmpty(descricao))
                {
                    Console.WriteLine("A descrição não pode ser vazia!");
                }
                else
                {
                    break;
                }
            }

            Console.Clear();

            List<DespesasReceitas> despesas = Manager.despesas.Where(d => d.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase)).ToList();
            foreach (DespesasReceitas item in despesas)
            {
                Console.WriteLine($"Despesa: Id: {item.Id}, Data: {item.Date}, Valor: R$-{item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
            }

            List<DespesasReceitas> receitas = Manager.receitas.Where(d => d.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase)).ToList();
            foreach (DespesasReceitas item in receitas)
            {
                Console.WriteLine($"Receita: Id: {item.Id}, Data: {item.Date}, Valor: R${item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
            }

        }
    }
}
