using ControleDeGastos;
using ControleDeGastos.Managers;

namespace ControleGastos.Histórico
{
    internal class Categoria
    {
        public void BuscarCategoria()
        {
            string categoria;

            Console.WriteLine("Buscar por Categoria\n");

            if (!Manager.despesas.Any() && !Manager.receitas.Any())
            {
                Console.WriteLine("Não existem despesas e receitas na lista!");
                return;
            }
            while (true)
            {
                Console.WriteLine("Digite a categoria que deseja buscar:");
                categoria = Console.ReadLine()!.Trim();
                if (string.IsNullOrEmpty(categoria))
                {
                    Console.WriteLine("A categoria não pode ser vazia!");
                }
                else
                {
                    break;
                }
            }

            Console.Clear();

            List<DespesasReceitas> despesas = Manager.despesas.Where(d => d.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase)).ToList();
            foreach (DespesasReceitas item in despesas)
            {
                Console.WriteLine($"Despesa: Id: {item.Id}, Data: {item.Date}, Valor: R$-{item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
            }

            List<DespesasReceitas> receitas = Manager.receitas.Where(d => d.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase)).ToList();
            foreach (DespesasReceitas item in receitas)
            {
                Console.WriteLine($"Receita: Id: {item.Id}, Data: {item.Date}, Valor: R${item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
            }
        }
    }
}
