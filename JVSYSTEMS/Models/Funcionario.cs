public class Funcionario
{
    public int Id { get; set; }
    public string? NomeFuncionario { get; set; }
    public string? CpfFuncionario { get; set; }

    public Funcionario() { }

    public Funcionario(int idFuncionario, string nomeFuncionario, string cpfFuncionario)
    {
        Id = idFuncionario;
        NomeFuncionario = nomeFuncionario;
        CpfFuncionario = cpfFuncionario;
    }
}
