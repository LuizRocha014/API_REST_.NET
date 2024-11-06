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

        public List<User> GetAllPermission(DateTime? ultimaAtt)
        {
            try
            {
                var list = _dataContext.User.Where(x => ultimaAtt == null ? (x.Active == true) : (x.UpdatedAt >= ultimaAtt)).ToList();
                return list;
            }
            catch (Exception)
            {
                return new List<User>();
            }
        }
        public List<string> AddShopProduct(List<User> listCustomer)
        {
            List<string> listRetorno = listCustomer.Select(obj => obj.Id.ToString()).ToList();
            try
            {
                foreach (var item in listCustomer)
                {
                    var exist = _dataContext.Set<User>().AsNoTracking().FirstOrDefault(x => x.Id == item.Id) != null ? true : false;
                    if (exist)
                    {
                        try
                        {
                            item.UpdatedAt = DateTime.Now;
                            _dataContext.Update(item);
                            _dataContext.SaveChanges();
                            listRetorno.Remove(item.Id.ToString());
                        }
                        catch (Exception)
                        {


                        }

                    }
                    else
                    {
                        item.UpdatedAt = DateTime.Now;
                        _dataContext.Add(item);
                        _dataContext.SaveChanges();
                        listRetorno.Remove(item.Id.ToString());
                    }
                }

                return listRetorno;
            }
            catch (Exception)
            {

                return listRetorno;
            }
        }

    }
}

