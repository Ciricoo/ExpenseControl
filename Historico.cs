using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos
{
    public class Historico
    {
        public static void PerguntasHistorico()
        {
            while (true)
            {
                Console.WriteLine("---- Histórico ----");
                Console.WriteLine("\nEscolha um método de filtragem:");
                Console.WriteLine("[1] - Por data (ex: 01/01/2022 à 01/01/2023)");
                Console.WriteLine("[2] - Valor mínimo");
                Console.WriteLine("[3] - Valor máximo");
                Console.WriteLine("[4] - Descrição");
                Console.WriteLine("[5] - Categoria");
                Console.WriteLine("[6] - Sair");
                string opcao = Console.ReadLine()!;

                switch (opcao)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break; 
                    case "5":
                        break;
                    case "6":
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        break;

                }

            }

        }
    }
}
