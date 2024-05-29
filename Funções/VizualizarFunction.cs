using ControleDeGastos.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeGastos.Service
{
    internal class VizualizarFunction
    {
        public void Vizualizar()
        {
            
            string opcao = Program.RetornarOpcao();

            Console.WriteLine("---- Vizualizar ----");

            if (opcao == "1")
            {
                Console.WriteLine("Despesas:");
                Manager.despesas.ForEach(item => Console.WriteLine($"Id: {item.Id}, Data: {item.Date}, Valor: R$-{item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}"));
                
                if (Manager.despesas.Count == 0 ) {
                    Console.WriteLine("Não foi adicionado nenhuma despesa!");
                }
            }
            else if (opcao == "2")
            { 
                Console.WriteLine("Receitas:");
                Manager.receitas.ForEach(item => Console.WriteLine($"Id: {item.Id}, Data: {item.Date}, Valor: R${item.Valor}, Descrição: {item.Descricao}, Categoria: {item.Categoria}"));

                if (Manager.receitas.Count == 0)
                {
                    Console.WriteLine("Não foi adicionado nenhuma receita!");
                }
            }

        }
    }
}
