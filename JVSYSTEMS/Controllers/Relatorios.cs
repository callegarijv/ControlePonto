using SistemaPonto.Models;

namespace SistemaPonto.Controllers
{
    public static class Relatorios
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("=== Relatórios de Ponto ===");

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
                .FirstOrDefault(f => f.IdFuncionario == idFuncionario);

            if (func == null)
            {
                Console.WriteLine("Funcionário não encontrado.");
                return;
            }

            var batidas = RegistroPonto.Batidas
                .Where(b => b.FuncionarioId == func.IdFuncionario)
                .OrderBy(b => b.DataHora)
                .ToList();

            if (batidas.Count == 0)
            {
                Console.WriteLine("Nenhuma batida registrada para esse funcionário.");
                return;
            }

            Console.WriteLine($"\nRelatório de {func.NomeFuncionario} (ID {func.IdFuncionario})");
            Console.WriteLine(new string('-', 45));

            void ImprimirSecao(string titulo, List<BatidaPonto> lista)
            {
                Console.WriteLine($"\n{titulo}:");
                if (lista.Count == 0)
                {
                    Console.WriteLine("  (sem registros)");
                    return;
                }

                var porDia = lista
                    .GroupBy(x => x.DataHora.Date)
                    .OrderBy(g => g.Key);

                foreach (var dia in porDia)
                {
                    Console.WriteLine($"  {dia.Key:dd/MM/yyyy}");
                    foreach (var b in dia.OrderBy(x => x.DataHora))
                    {
                        Console.WriteLine($"    - {b.DataHora:dd/MM/yyyy HH:mm:ss.fff}");
                    }
                }
            }

            ImprimirSecao("Entradas", batidas.Where(b => b.Tipo == "Entrada").ToList());
            ImprimirSecao("Saídas", batidas.Where(b => b.Tipo == "Saída").ToList());
            ImprimirSecao("Intervalos", batidas.Where(b => b.Tipo == "Intervalo").ToList());

            Console.WriteLine("\nResumo por dia:");
            var resumo = batidas
                .GroupBy(b => b.DataHora.Date)
                .Select(g => new
                {
                    Dia = g.Key,
                    Entradas = g.Count(x => x.Tipo == "Entrada"),
                    Saidas = g.Count(x => x.Tipo == "Saída"),
                    Intervalos = g.Count(x => x.Tipo == "Intervalo")
                })
                .OrderBy(r => r.Dia)
                .ToList();

            foreach (var r in resumo)
            {
                Console.WriteLine($"  {r.Dia:dd/MM/yyyy} - Entradas: {r.Entradas}, Saídas: {r.Saidas}, Intervalos: {r.Intervalos}");
            }
        }
    }
}
