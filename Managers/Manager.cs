using ControleDeGastos.Service;
using ControleGastos.Histórico;
using ControleGastos.Relatório;
using ControleGastos.Service;

namespace ControleDeGastos.Managers
{
    public class Manager
    {
        AddFunction AddFunction = new AddFunction();
        VisualizarFunction VizualizarFunction = new VisualizarFunction();
        EditarFunction EditarFunction = new EditarFunction();
        ExcluirFunction ExcluirFunction = new ExcluirFunction();
        RangeData RangeData = new RangeData();
        ValorMinimo ValorMinimo = new ValorMinimo();
        ValorMaximo ValorMaximo = new ValorMaximo();
        Descricao Descricao = new Descricao();
        Categoria Categoria = new Categoria();
        VizualizarTodos VizualizarTodos = new VizualizarTodos();
        GerarRelatorio GerarRelatorio = new GerarRelatorio();  

        public static List<DespesasReceitas> despesas = new List<DespesasReceitas>();
        public static List<DespesasReceitas> receitas = new List<DespesasReceitas>();

        public void Adicionar()
        {
            Console.Clear();
            AddFunction.Adicionar();
        }

        public void Vizualizar()
        {
            Console.Clear();
            VizualizarFunction.Vizualizar();
        }

        public void Editar()
        {
            Console.Clear();
            EditarFunction.Editar();
        }

        public void Excluir()
        {
            Console.Clear();
            ExcluirFunction.Excluir();
        }

        public void BuscarRangeData()
        {
            Console.Clear();
            RangeData.BuscarDatas();
        }

        public void BuscarValorMinimo()
        {
            Console.Clear();
            ValorMinimo.BuscarValorMinimo();
        }

        public void BuscarValorMaximo()
        {
            Console.Clear();
            ValorMaximo.BucarValorMaximo();
        }

        public void BuscarDescricao()
        {
            Console.Clear();
            Descricao.BuscarDescricao();
        }

        public void BuscarCategoria()
        {
            Console.Clear();
            Categoria.BuscarCategoria();
        }

        public void BuscarTodos()
        {
            Console.Clear();
            VizualizarTodos.BuscarTodos();
        }

        public void GerarRelatorioFinanceiro()
        {
            Console.Clear();
            GerarRelatorio.GerarRelatorioFinanceiro();
        }
    }
}
