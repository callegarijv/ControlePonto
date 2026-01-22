namespace ControlePonto.Models
{
    public class BatidaPonto
    {
        public int Id { get; set; }
        public int FuncionarioId { get; set; }
        public DateTime DataHora { get; set; }
        public string? Tipo { get; set; }

        public BatidaPonto() { }

        public BatidaPonto(int funcionarioId, string tipo)
        {
            FuncionarioId = funcionarioId;
            Tipo = tipo;
            DataHora = DateTime.Now;
        }
    }
}
