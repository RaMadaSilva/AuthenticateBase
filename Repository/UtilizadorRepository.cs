

using AuthApi.Models;

namespace AuthApi.Repository;

public static class UtilizadorRepository
{

    public static Utilizador GetUtilizador(string userName, string password)
    {
        List<Utilizador> utilizadores = new(){
                 new(){Id = 1, UserName = "raul", Password = "raul", Role = "admin"},
                 new(){Id = 1, UserName = "jandira", Password = "jandira", Role = "funcionaria"},
                 };
        return utilizadores.FirstOrDefault(x => x.UserName == userName && x.Password == password)!;

    }

}
