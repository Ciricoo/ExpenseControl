using ControleDeGastos;
using ControleDeGastos.Managers;

namespace ControleGastos.Histórico
{
    internal class Descricao
    {
        public void BuscarDescricao()
        {
            bool encontrado = false;
            string descricao;
            Console.WriteLine("Buscar por Descrição\n");

            if (!Manager.despesas.Any() && !Manager.receitas.Any())
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

            foreach (DespesasReceitas item in Manager.despesas)
            {
                if(item.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Despesa: Data: {item.Date}, Valor: R$-{item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
                    encontrado = true;
                }
            }
            foreach (DespesasReceitas item in Manager.receitas)
            {
                if (item.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Receita: Data: {item.Date}, Valor: R${item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
                    encontrado = true;
                }
            }

            if (!encontrado) {
                Console.WriteLine("Não foi possível encontrar despesas e receitas com essa descrição!");
            }

        }
    }
}
