using LinqKit;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Cryptography;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;
using WEB_REST_PRO.Models.SmartStorege;

namespace WEB_REST_PRO.Data.Repository.SmartStorege
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        private readonly DataContext _dataContext;
        public UserRepository(DataContext context) : base(context)
        {
            _dataContext = context;
        }


        public User? login(string username, string password)
        {
            try
            {
                var hash = passWordHash(password);
                var retorno = _dataContext.User.FirstOrDefault(x => x.UserName == username && x.Password == hash);

                if (retorno != null)
                {
                  var listAcessos =  _dataContext.UserPermission.Include(x => x.Permission).Where(e => e.UsuarioId == retorno.Id);
                    if (listAcessos.Any(x => x.Permission.Name.Contains("AppPermission")))
                        return retorno;
                    else
                        return null;

                }
                return retorno ?? null;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public bool addLogin(User? user)
        {
            try
            {
                if (user != null)
                {
                    var userExist = _dataContext.User.FirstOrDefault(x => x.UserName == user!.UserName);
                    if (userExist == null)
                    {
                        user.Password = passWordHash(user.Password);
                        _dataContext.Add(user);
                        _dataContext.SaveChanges();
                        var retorno = _dataContext.User.FirstOrDefault(x => x.Id == user.Id);
                        return retorno != null ? true : false;
                    }
                }
                return false;
            }
            catch (Exception e)
            {

                return false;
            }
        }



    }
}

