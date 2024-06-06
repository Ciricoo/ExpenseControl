using ControleDeGastos.Managers;

namespace ControleGastos.Histórico
{
    internal class ValorMaximo
    {
        public void BucarValorMaximo()
        {;
            Console.WriteLine("Buscar por Valor Máximo");

            if (!Manager.despesas.Any() && !Manager.receitas.Any())
            {
                Console.WriteLine("Nenhuma despesa e receita foi adicionada!");
                return;
            }

            Console.Clear();

            if( Manager.despesas.Count == 0 )
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
            if( Manager.receitas.Count == 0 )
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

