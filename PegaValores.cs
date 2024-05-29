using ControleDeGastos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastos
{
    internal class PegaValores
    {
        public static int idDespesas = 0;
        public static int idReceitas = 0;

        public static DespesasReceitas Valores()
        {

            string opcao = Program.RetornarOpcao();
            DateOnly dataTime;
            bool verificaData = true;

            Console.WriteLine("---- Adicionar ----");
            while (verificaData)
            {
                Console.WriteLine("\nData: (dd/MM/yyyy):");
                string data = Console.ReadLine()!;

                if (!DateOnly.TryParse(data, out dataTime))
                {
                    Console.WriteLine("Formato inválido, por favor use o formato (dd/MM/yyyy)");
                }
                else
                {
                    verificaData = false;
                }

            }

            Console.WriteLine("Valor:");
            float valor = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Descrição:");
            string descricao = Console.ReadLine()!;
            Console.WriteLine("Categoria:");
            string categoria = Console.ReadLine()!;

            switch (opcao)
            {
                case "1":
                    idDespesas++;
                    return new DespesasReceitas(idDespesas, dataTime, valor, descricao, categoria);
                case "2":
                    idReceitas++;
                    return new DespesasReceitas(idReceitas, dataTime, valor, descricao, categoria);
                default:
                    return null!;
            }
        }
    }
}
