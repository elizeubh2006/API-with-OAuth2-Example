using API_WITH_OAUTH2.Models;

namespace API_WITH_OAUTH2.Repositories
{
    public class UserRepository
    {
        public User Get(string username, string password)  
        {
            var users = new List<User>
            {
                new User { Id = 1, UserName = "Jose.Fernandes", Password = "SenhaForte", Role = "Gerente" },
                new User { Id = 2, UserName = "Carlo.Alberto", Password = "SenhaOk", Role = "Comprador" }
            };

            var result = users.Where(x => x.UserName.Equals(username, StringComparison.CurrentCultureIgnoreCase) 
                                        && x.Password == password).FirstOrDefault();

            if(result == null)
            {
                throw new Exception("Usuário não encontrado ou senha inválida.");
            }

            return result;
        }
    }
}