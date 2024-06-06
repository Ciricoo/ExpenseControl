using ControleDeGastos.Managers;

namespace ControleGastos.Histórico
{
    internal class Categoria
    {
        public void BuscarCategoria()
        {
            bool encontrado = false;
            string categoria;

            Console.WriteLine("Buscar por Categoria");

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

            foreach (var item in Manager.despesas)
            {
                if (item.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Despesa: Data: {item.Date}, Valor: R$-{item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
                    encontrado = true;
                }
            }
            foreach (var item in Manager.receitas)
            {
                if (item.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Receita: Data: {item.Date}, Valor: R${item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Não foi possível encontrar despesas e receitas com essa descrição!");
            }
        }
    }
}
