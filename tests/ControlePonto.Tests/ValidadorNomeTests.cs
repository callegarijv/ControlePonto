using ControlePonto.Validadores;
using Xunit;

namespace ControlePonto.Tests;

public class ValidadorNomeTests
{
    [Theory]
    [InlineData("Joao Silva")]
    [InlineData("Ana Maria")]
    public void Validar_DeveAceitarNomeValido(string nome)
    {
        Assert.True(ValidadorNome.Validar(nome));
    }

    [Theory]
    [InlineData("")]
    [InlineData("   ")]
    [InlineData("Joao123")]
    [InlineData("Maria-Silva")]
    public void Validar_DeveRejeitarNomeInvalido(string nome)
    {
        Assert.False(ValidadorNome.Validar(nome));
    }
}
