using GerenciamentoIdentidade2.Models;


namespace GerenciamentoIdentidade2.Models.Login
{
    public class LoginVD
    {
        public string Senha { get; set; }
        public string Email { get; set; }
        public LoginVD(string Senha, string Email)
        {
            this.Senha = Senha;
            this.Email = Email;
        }
        public LoginVD()
        {

        }
    }
}