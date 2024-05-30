using ControleDeGastos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos.Funções
{
    internal class PegaValores
    {
        public static int idDespesas = 0;
        public static int idReceitas = 0;

        public static DespesasReceitas Valores()
        {
            string opcao = Program.RetornarOpcao();
            DateOnly dataTime;
            float valor;
            string categoria;
            string descricao;
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("\nData: (dd/MM/yyyy):");
                    string data = Console.ReadLine()!.Trim();

                    if (!DateOnly.TryParse(data, out dataTime))
                    {
                        Console.WriteLine("Formato inválido, por favor use o formato (dd/MM/yyyy)");
                    }
                    else
                    {
                        break;
                    }
                }

                while (true)
                {
                    Console.WriteLine("Valor:");
                    string valorString = Console.ReadLine()!.Trim();

                    if (string.IsNullOrEmpty(valorString) || !float.TryParse(valorString, out valor))
                    {

                        Console.WriteLine("Valor inválido!");
                        continue;
                    }
                    else if(valor <= 0)
                    {
                        Console.WriteLine("Não pode ser adicionado um valor negativo ou sem valor!");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                while (true)
                {
                    Console.WriteLine("Descrição:");
                     descricao = Console.ReadLine()!.Trim();

                    if (string.IsNullOrEmpty(descricao))
                    {

                        Console.WriteLine("Descrição não pode ser vazia!");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Categoria:");
                    categoria = Console.ReadLine()!.Trim();

                    if (string.IsNullOrEmpty(categoria))
                    {

                        Console.WriteLine("Categoria não pode ser vazia!");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                switch (opcao)
                {
                    case "1":
                        idDespesas++;
                        return new DespesasReceitas(idDespesas, dataTime, valor, descricao, categoria);
                    case "2":
                        idReceitas++;
                        return new DespesasReceitas(idReceitas, dataTime, valor, descricao, categoria);
                    default:
                        throw new InvalidOperationException("Opção inválida!");
                }

            }
        }
    }
}
