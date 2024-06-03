using ControleDeGastos;
using ControleDeGastos.Managers;
using ControleGastos.Funções;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos.Service
{
    internal class EditarFunction
    {
        string opcao = Program.RetornarOpcao();
        public void Editar() {
            Console.WriteLine("Editar");

            Console.WriteLine("Digite o Id que deseja editar:");
            if(!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Id inválido!");
                return;
            }

            DespesasReceitas? item;

            if(opcao == "1")
            {
                item = Manager.despesas.FirstOrDefault(d => d.Id == id);
            }
            else if(opcao == "2")
            {
                item = Manager.receitas.FirstOrDefault(d => d.Id == id);
            }
            else
            {
                Console.WriteLine("Opção inválida!");
                return;
            }

            if( item == null)
            {
                Console.WriteLine($"{(opcao == "1" ? "Despesa" : "Receita")} não encontrada!");
                return;
            }

            Console.WriteLine("Digite os novos valores");

            var Valores = PegaValores.Valores();

            item.Date = Valores.Date;
            item.Valor = Valores.Valor;
            item.Descricao = Valores.Descricao;
            item.Categoria = Valores.Categoria;

            Console.Clear();
            Console.WriteLine($"Data: {item.Date}, {(opcao == "1" ? $"Valor: R$-{item.Valor}": $"Valor: R${item.Valor}")}, Descrição: {item.Descricao}, Categoria: {item.Categoria}");
            Console.WriteLine($"{(opcao == "1" ? "Despesa" : "Receita")} atualizada com sucesso!");
        }
    }
}
