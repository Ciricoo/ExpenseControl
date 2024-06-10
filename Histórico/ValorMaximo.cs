using ControleDeGastos.Managers;

namespace ControleGastos.Histórico
{
    internal class ValorMaximo
    {
        public void BucarValorMaximo()
        {;
            Console.WriteLine("Buscar por Valor Máximo\n");

            if (!Manager.despesas.Any() && !Manager.receitas.Any())
            {
                Console.WriteLine("Nenhuma despesa e receita foi adicionada!");
                return;
            }

            if(!Manager.despesas.Any())
            {
                Console.WriteLine("Não foi adicionado nenhuma despesa!");
            }
            else
            {
                var maiorDespesa = Manager.despesas.Max(d => d.Valor);
                Console.WriteLine("Maior Despesa:");
                var itemDespesa = Manager.despesas.First(d => d.Valor == maiorDespesa);
                Console.WriteLine($"Data: {itemDespesa.Date}, Valor: R$-{itemDespesa.Valor}, Descrição: {itemDespesa.Descricao}, Categoria: {itemDespesa.Categoria}");
            }
            if(!Manager.receitas.Any())
            {
                Console.WriteLine("Não foi adicionado nenhuma receita!");
            }
            else
            {
                var maiorReceita = Manager.receitas.Max(d => d.Valor);
                Console.WriteLine("Maior Receita:");
                var itemReceita = Manager.receitas.First(d => d.Valor == maiorReceita);
                Console.WriteLine($"Data: {itemReceita.Date}, Valor: R${itemReceita.Valor}, Descrição: {itemReceita.Descricao}, Categoria: {itemReceita.Categoria}");
            }
        }
    }
}

