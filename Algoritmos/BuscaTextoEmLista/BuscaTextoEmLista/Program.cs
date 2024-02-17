using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BuscaTextoEmLista;

var app = new Aplicacao();
app.Start();

public class Aplicacao()
{
    public void Start()
    {

        var resumo = BenchmarkRunner.Run<TesteEstruturaCategoria>();
        Console.WriteLine("Finalizado");
    }
}

public class TesteEstruturaCategoria : TestesCategoriaGeral
{
    
    

    [Benchmark]
    [Arguments("ELETRONICOS_CAT12")]
    [Arguments("MOVEIS_CAT10")]
    [Arguments("ALIMENTOS_CAT5")]
    [Arguments("ROUPAS_CAT98")]
    public override void BuscarCategoriaPorTexto(string categoria)
    {
        Thread.Sleep(200);
    }

    [Benchmark]
    [Arguments("ELETRONICOS_CAT12")]
    [Arguments("MOVEIS_CAT10")]
    [Arguments("ALIMENTOS_CAT5")]
    [Arguments("ROUPAS_CAT98")]
    public override int BuscarIdCategoriaPorTexto(string categoria)
    {
        Thread.Sleep(300);
        return 0;
    }

    public override bool CategoriaPetenceAoDepartamento(TipoDepartamento departamento, string categoria)
    {
        throw new NotImplementedException();
    }

    public override bool ChecarSeCategoriaExiste(string categoria)
    {
        throw new NotImplementedException();
    }

    public override bool ChecarSeIdCategoriaExiste(int idCategoria)
    {
        throw new NotImplementedException();
    }

    public override bool IdCategoriaPertenceAoDepartamento(TipoDepartamento departamento, int idCategoria)
    {
        throw new NotImplementedException();
    }
}

public abstract class TestesCategoriaGeral
{
    public abstract bool ChecarSeCategoriaExiste(string categoria);
    public abstract bool ChecarSeIdCategoriaExiste(int idCategoria);
    public abstract void BuscarCategoriaPorTexto(string categoria);
    public abstract int BuscarIdCategoriaPorTexto(string categoria);
    public abstract bool CategoriaPetenceAoDepartamento(TipoDepartamento departamento, string categoria);
    public abstract bool IdCategoriaPertenceAoDepartamento(TipoDepartamento departamento, int idCategoria);
}







