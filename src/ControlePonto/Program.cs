using System;
using Microsoft.EntityFrameworkCore;
using ControlePonto.Controllers;
using ControlePonto.Data;

namespace ControlePonto
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                context.Database.Migrate();
            }

            while (true)
            {
                Console.WriteLine("=== Menu Principal ===");
                Console.WriteLine("1. Cadastrar Usuário");
                Console.WriteLine("2. Cadastrar Funcionário");
                Console.WriteLine("3. Listar Funcionários");
                Console.WriteLine("4. Registrar Ponto");
                Console.WriteLine("5. Relatórios");
                Console.WriteLine("6. Sair");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out int option))
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        CadastroUsuario.Executar();
                        break;
                    case 2:
                        CadastroFuncionario.Executar();
                        break;
                    case 3:
                        CadastroFuncionario.Listar();
                        break;
                    case 4:
                        RegistroPonto.Executar();
                        break;
                    case 5:
                        Relatorios.Executar();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Opção não reconhecida.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
