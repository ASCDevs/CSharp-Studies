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

public class TesteEstruturaCategoria
{
    
    //[Benchmark]
    //[Arguments("ELETRONICOS_CAT0")]
    //[Arguments("MOVEIS_CAT273")]
    //[Arguments("ALIMENTOS_412")]
    //[Arguments("ROUPAS_CAT499")]
    public void ChecarSeCategoriaExiste(string categoria)
    {
        EstruturaCategorias.ChecarSeCategoriaExiste(categoria);
    }

    //[Benchmark]
    //[Arguments(2)]
    //[Arguments(782)]
    //[Arguments(1200)]
    //[Arguments(1998)]
    public bool ChecarSeIdCategoriaExiste(int IdCategoria)
    {
        return EstruturaCategorias.ChecarSeIdCategoriaExiste(IdCategoria);
    }

    //[Benchmark]
    //[Arguments(2)]
    //[Arguments(782)]
    //[Arguments(1200)]
    //[Arguments(1998)]
    public bool ChecarSeIdCategoriaExisteFromDictionary(int idCategoria)
    {
        return EstruturaCategorias.ChecarSeIdCategoriaExisteFromDictionary(idCategoria);
    }

    [Benchmark]
    [Arguments(TipoDepartamento.Roupas, 1998)]
    [Arguments(TipoDepartamento.Moveis, 782)]
    [Arguments(TipoDepartamento.Alimentos,1200)]
    [Arguments(TipoDepartamento.Eletronicos,2)]
    [Arguments(TipoDepartamento.NaoDefinido,1998)]
    [Arguments(TipoDepartamento.NaoDefinido,782)]
    [Arguments(TipoDepartamento.NaoDefinido,1200)]
    [Arguments(TipoDepartamento.NaoDefinido,2)]
    public bool IdCategoriaPertenceAoDepartamento(TipoDepartamento departamento, int idCategoria)
    {
        return EstruturaCategorias.IdCategoriaPertenceAoDepartamento(departamento, idCategoria);
    }

    [Benchmark]
    [Arguments(TipoDepartamento.Roupas, 1998)]
    [Arguments(TipoDepartamento.Moveis, 782)]
    [Arguments(TipoDepartamento.Alimentos, 1200)]
    [Arguments(TipoDepartamento.Eletronicos, 2)]
    [Arguments(TipoDepartamento.NaoDefinido, 1998)]
    [Arguments(TipoDepartamento.NaoDefinido, 782)]
    [Arguments(TipoDepartamento.NaoDefinido, 1200)]
    [Arguments(TipoDepartamento.NaoDefinido, 2)]
    public bool IdCategoriaPertenceAoDepartamentoFromDictionary(TipoDepartamento departamento, int idCategoria)
    {
        return EstruturaCategorias.IdCategoriaPertenceAoDepartamentoFromDictionary(departamento, idCategoria);
    }

}









