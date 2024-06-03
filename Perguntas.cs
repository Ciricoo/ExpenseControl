using ControleDeGastos.Managers;
using ControleGastos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeGastos
{
    internal class Perguntas
    {
        public static void Despesas()
        {
            PerguntasCadastro("Despesas");
        }
        public static void Receitas()
        {
            PerguntasCadastro("Receitas");
        }


        public static void PerguntasCadastro(string type)
        {
            Manager Manager = new Manager();

            while (true)
            {
                Console.WriteLine("================================================");
                Console.WriteLine(type);
                Console.WriteLine($"\n[1] - Adicionar {type}");
                Console.WriteLine($"[2] - Vizualizar {type}");
                Console.WriteLine($"[3] - Editar {type}");
                Console.WriteLine($"[4] - Excluir {type}");
                Console.WriteLine("[5] - Sair");
                Console.WriteLine("================================================");
                Console.Write("Opção: ");
                string opcao = Console.ReadLine()!.Trim();

                switch (opcao)
                {
                    case "1":
                        Manager.Adicionar();
                        break;
                    case "2":
                        Manager.Vizualizar();
                        break;
                    case "3":
                        Manager.Editar();
                        break;
                    case "4":
                        Manager.Excluir();
                        break;
                    case "5":
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
