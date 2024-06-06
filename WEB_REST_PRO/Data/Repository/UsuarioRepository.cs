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
            var usuario = new Usuario()
            {
                Nome = nome,
                Sobrenome = sobrenome,
                UserName = userId.ToLower(),
                Email = email,
                Senha = senha,
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

    public Usuario? login(string userName, string passWord)
    {
        try
        {

            var conta = _dataContext.Usuario.FirstOrDefault(x => x.UserName == userName && x.Senha == passWord);
            if (conta == null) throw new Exception();
                return conta;

        }
        catch (Exception)
        {

            return null;
        }
    }

}
