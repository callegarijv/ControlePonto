using ControlePonto.Data;
using ControlePonto.Models;
using ControlePonto.Validadores;

namespace ControlePonto.Controllers
{
    public static class CadastroFuncionario
    {
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

            var novoFuncionario = new Funcionario
            {
                NomeFuncionario = nomeFuncionario!,
                CpfFuncionario = cpfFuncionario!
            };

            using (var context = new AppDbContext())
            {
                if (context.Funcionarios.Any(f => f.CpfFuncionario == cpfFuncionario))
                {
                    Console.WriteLine("Já existe um funcionário com esse CPF.");
                    return;
                }

                context.Funcionarios.Add(novoFuncionario);
                context.SaveChanges();
            }

            Console.WriteLine($"Funcionário cadastrado com sucesso! ID gerado: {novoFuncionario.Id}");
        }

        public static void Listar()
        {
            Console.Clear();
            Console.WriteLine("=== Lista de Funcionários ===");

            using (var context = new AppDbContext())
            {
                var funcionarios = context.Funcionarios.ToList();
                if (funcionarios.Count == 0)
                {
                    Console.WriteLine("Nenhum funcionário cadastrado.");
                    return;
                }

                foreach (var funcionario in funcionarios)
                {
                    Console.WriteLine($"ID: {funcionario.Id}, Nome: {funcionario.NomeFuncionario}, CPF: {funcionario.CpfFuncionario}");
                }
            }
        }
    }
}
