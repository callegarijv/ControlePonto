using SistemaPonto.Models;
using SistemaPonto.Helpers;

namespace SistemaPonto.Controllers
{
    public static class CadastroUsuario
    {
        public static List<Usuario> usuarios = new();

        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("=== Cadastro de Usuário ===");

            Console.Write("Digite o nome de usuário: ");
            string? user = Console.ReadLine();

            Console.Write("Digite a senha: ");
            string? password = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Usuário e senha não podem estar vazios.");
                return;
            }

            string senhaHash = HashHelper.GerarHash(password);

            Usuario novoUsuario = new Usuario(user, senhaHash);
            usuarios.Add(novoUsuario);

            Console.WriteLine("Usuário cadastrado com sucesso!");
        }
    }
}
