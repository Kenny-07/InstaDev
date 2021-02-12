using System.IO;
using InstaDev.Interfaces;

namespace InstaDev.Models
{
    public class Usuario : IUsuario
    {
        public int IdUsuario { get; set; }
        
        public string Nome { get; set; }
        
        public string Foto { get; set; }
        
        public string DataNascimento { get; set; }
        
        public string Email { get; set; }
        
        public string UserName { get; set; }
        
        public string Senha { get; set; }

        public const string PATH = "Database/Usuario.csv";

        public string PrepararLinha(Usuario u)
        {
            return $"{u.IdUsuario};{u.Nome};{u.Foto};{u.DataNascimento};{u.Email};{u.UserName};{u.Senha}";
        }
        
        public void Cadastrar(Usuario user)
        {
            string[] linha = { PrepararLinha(user) };
            File.AppendAllLines(PATH, linha);
        }
    }
}