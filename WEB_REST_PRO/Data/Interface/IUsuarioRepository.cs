using System;
using WEB_REST_PRO.Models;

public interface IUsuarioRepository
{
    bool AddUsuario(string nome, string sobrenome, string userId, string email, string senha);
    List<Usuario> GetAllUsuarios();

    public Usuario? login(string userName, string passWord);
}
