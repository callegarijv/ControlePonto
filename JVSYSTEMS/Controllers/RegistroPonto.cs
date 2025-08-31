using SistemaPonto.Models;

namespace SistemaPonto.Controllers
{
    public static class RegistroPonto
    {
        public static List<BatidaPonto> Batidas = new();

        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("=== Registro de Ponto ===");

            if (CadastroFuncionario.funcionarios.Count == 0)
            {
                Console.WriteLine("Nenhum funcionário cadastrado.");
                return;
            }

            Console.Write("Digite o ID do funcionário: ");
            if (!int.TryParse(Console.ReadLine(), out int idFuncionario))
            {
                Console.WriteLine("ID inválido.");
                return;
            }

            var func = CadastroFuncionario.funcionarios
                .FirstOrDefault(f => f.Id == idFuncionario);

            if (func == null)
            {
                Console.WriteLine("Funcionário não encontrado.");
                return;
            }

            Console.WriteLine("Selecione o tipo de registro:");
            Console.WriteLine("1. Entrada");
            Console.WriteLine("2. Saída");
            Console.WriteLine("3. Intervalo");
            string tipo = Console.ReadLine() switch
            {
                "1" => "Entrada",
                "2" => "Saída",
                "3" => "Intervalo",
                _ => ""
            };

            if (string.IsNullOrEmpty(tipo))
            {
                Console.WriteLine("Tipo inválido.");
                return;
            }

            var batida = new BatidaPonto(func.Id, tipo);
            Batidas.Add(batida);

            Console.WriteLine($"Batida registrada: {tipo} às {batida.DataHora:dd/MM/yyyy HH:mm:ss.fff} para {func.NomeFuncionario}");
        }
    }
}
