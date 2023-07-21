using LinqKit;
using System;
using System.Linq;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Models;

public class UsuarioRepository : BaseRepository, IUsuarioRepository
{
    private readonly DataContext _dataContext;
    public UsuarioRepository(DataContext dataContext) : base(dataContext)
    {
        _dataContext = dataContext;
    }



    public bool AddUsuario(string nome, string sobrenome, string userId, string email, string senha)
    {
        try
        {
            var senhaHash = senha.GetHashCode();
            var usuario = new Usuario()
            {
                Nome = nome,
                Sobrenome = sobrenome,
                UserName = userId.ToLower(),
                Email = email,
                Senha = senhaHash.ToString(),
                Inclusao = DateTime.Now,
                Alteracao = DateTime.Now,
                
            };
            _dataContext.Add<Usuario>(usuario);
            _dataContext.SaveChanges();
            return true;
        }
        catch (Exception)
        {

            return false;
        }
    }

    public List<Usuario> GetAllUsuarios()
    {
        try
        {

            var listRetorno = _dataContext.Usuario.ToList();
            return listRetorno;
        }
        catch (Exception)
        {

            return new List<Usuario>();
        }
    }

}
