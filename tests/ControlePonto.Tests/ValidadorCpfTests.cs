using ControlePonto.Validadores;
using Xunit;

namespace ControlePonto.Tests;

public class ValidadorCpfTests
{
    [Theory]
    [InlineData("529.982.247-25")]
    [InlineData("39053344705")]
    public void Validar_DeveAceitarCpfValido(string cpf)
    {
        Assert.True(ValidadorCPF.Validar(cpf));
    }

    [Theory]
    [InlineData("")]
    [InlineData("   ")]
    [InlineData("111.111.111-11")]
    [InlineData("12345678900")]
    [InlineData("123")]
    public void Validar_DeveRejeitarCpfInvalido(string cpf)
    {
        Assert.False(ValidadorCPF.Validar(cpf));
    }
}
