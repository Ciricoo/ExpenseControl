using ControleDeGastos.Managers;

namespace ControleDeGastos.Service
{
    internal class VizualizarFunction
    {
        public void Vizualizar()
        {

            string opcao = Program.RetornarOpcao();

            Console.WriteLine("Vizualizar\n");

            if (opcao == "1")
            {
                if (Manager.despesas.Count == 0)
                {
                    Console.WriteLine("Não foi adicionado nenhuma despesa!");
                }
                else
                {
                    Console.WriteLine("Despesas:");
                    Manager.despesas.ForEach(item => Console.WriteLine($"Id: {item.Id}, Data: {item.Date}, Valor: R$-{item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}"));
                }
                
            }
            else if (opcao == "2")
            {
                if (Manager.receitas.Count == 0)
                {
                    Console.WriteLine("Não foi adicionado nenhuma receita!");
                }
                else
                {
                    Console.WriteLine("Receitas:");
                    Manager.receitas.ForEach(item => Console.WriteLine($"Id: {item.Id}, Data: {item.Date}, Valor: R${item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}"));
                }
            }
        }
    }
}
