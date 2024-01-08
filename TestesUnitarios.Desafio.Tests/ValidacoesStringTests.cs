using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        // Corrigido, alterado a variavel texto e resultadoEsperado de acordo com o nome da função

        // Arrange
        var texto = "matrix";
        var resultadoEsperado = 6;

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "qualquer";

        // Corrigido, passado como parametro o texto procurado e o texto
        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        // Corrigido, feito o assert de acordo com o nome da função
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Esse é um texto qualquer";
        var textoProcurado = "teste";

        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        // Corrigido, modificado de acordo com o nome da função
        Assert.False(resultado);
    }

    // Corrigido, foi colocado a paralavra reservada Fact
    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        // Corrigido, modificado o texto procurado de acordo com o nome da função

        // Arrange
        var texto = "Começo, meio e fim do texto procurado";
        var textoProcurado = "procurado";

        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }
}
