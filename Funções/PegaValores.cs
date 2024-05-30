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
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("\nData: (dd/MM/yyyy):");
                    string data = Console.ReadLine()!;

                    if (!DateOnly.TryParse(data, out dataTime))
                    {
                        Console.WriteLine("Formato inválido, por favor use o formato (dd/MM/yyyy)");
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine("Valor:");
                string valorString = Console.ReadLine()!;

                if (string.IsNullOrEmpty(valorString) || !float.TryParse(valorString, out valor))
                {

                    Console.WriteLine("Valor inválido!");
                    continue;
                }
                Console.WriteLine("Descrição:");
                string descricao = Console.ReadLine()!;

                if (string.IsNullOrEmpty(descricao))
                {

                    Console.WriteLine("Valor inválido!");
                    continue;
                }
                Console.WriteLine("Categoria:");
                string categoria = Console.ReadLine()!;

                if (string.IsNullOrEmpty(categoria))
                {

                    Console.WriteLine("Valor inválido!");
                    continue;
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
