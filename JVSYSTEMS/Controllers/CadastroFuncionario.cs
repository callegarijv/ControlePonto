using SistemaPonto.Models;
using SistemaPonto.Validadores;

namespace SistemaPonto.Controllers
{
    public static class CadastroFuncionario
    {
        public static List<Funcionario> funcionarios = new();
        private static int _nextId = 1;

        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("=== Cadastro de Funcionário ===");

            Console.Write("Digite o nome do Funcionário: ");
            string? nomeFuncionario = Console.ReadLine();

            Console.Write("Digite o CPF do Funcionário: ");
            string? cpfFuncionario = Console.ReadLine();

            if (!ValidadorNome.Validar(nomeFuncionario!))
            {
                Console.WriteLine("Nome inválido. Apenas letras e espaços são permitidos.");
                return;
            }

            if (!ValidadorCPF.Validar(cpfFuncionario!))
            {
                Console.WriteLine("CPF inválido. Verifique se digitou corretamente os 11 dígitos.");
                return;
            }

            if (funcionarios.Any(f => f.CpfFuncionario == cpfFuncionario))
            {
                Console.WriteLine("Já existe um funcionário com esse CPF.");
                return;
            }

            var novoFuncionario = new Funcionario(
                idFuncionario: _nextId++,
                nomeFuncionario: nomeFuncionario!,
                cpfFuncionario: cpfFuncionario!
            );

            funcionarios.Add(novoFuncionario);

            Console.WriteLine($"Funcionário cadastrado com sucesso! ID gerado: {novoFuncionario.IdFuncionario}");
        }

        public static void Listar()
        {
            Console.Clear();
            Console.WriteLine("=== Lista de Funcionários ===");

            if (funcionarios.Count == 0)
            {
                Console.WriteLine("Nenhum funcionário cadastrado.");
                return;
            }

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine($"ID: {funcionario.IdFuncionario}, Nome: {funcionario.NomeFuncionario}, CPF: {funcionario.CpfFuncionario}");
            }
        }
    }
}
