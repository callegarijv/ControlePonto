using System;
using ControlePonto.Data;
using ControlePonto.Models;
using ControlePonto.Helpers;

namespace ControlePonto.Controllers
{
    public class CadastroUsuario
    {
        public static void Executar()
        {
            Console.WriteLine("Cadastro de Usuário:");
            Console.Write("Usuário: ");
            string user = Console.ReadLine() ?? "";

            Console.Write("Senha: ");
            string password = Console.ReadLine() ?? "";

            // Cria hash da senha
            string passwordHash = HashHelper.GerarHash(password);

            // Cria o objeto
            var novoUsuario = new Usuario(user, passwordHash);

            // Salva no banco de dados
            using (var context = new AppDbContext())
            {
                context.Usuarios.Add(novoUsuario);
                context.SaveChanges();
            }

            Console.WriteLine("Usuário cadastrado com sucesso!");
        }
    }
}
