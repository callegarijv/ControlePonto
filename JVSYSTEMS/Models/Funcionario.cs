namespace SistemaPonto.Models
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string? NomeFuncionario { get; set; }
        public string? CpfFuncionario { get; set; }

        public Funcionario(int idFuncionario, string nomeFuncionario, string cpfFuncionario)
        {
            IdFuncionario = idFuncionario;
            NomeFuncionario = nomeFuncionario;
            CpfFuncionario = cpfFuncionario;
        }
    }
}
