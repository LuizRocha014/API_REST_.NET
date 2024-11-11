using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Data.Repository.SmartStorege
{
    public class UserPermissionsRepository : BaseRepository, IUserPermissionRepository
    {
        private readonly DataContext _dataContext;
        public UserPermissionsRepository(DataContext context) : base(context)
        {
            _dataContext = context;
        }

        public List<UserPermission>? GetAllUserId(Guid userId, DateTime? ultData)
        {

            try
            {
                return _dataContext.UserPermission.Where(x => x.UsuarioId == userId && (ultData != null ? x.UpdatedAt <= ultData : x.Active == true)).ToList();

            }
            catch (Exception)
            {

                return null;
            }
        }
        public List<UserPermission>? GetAll(DateTime? ultData)
        {

            try
            {
                return _dataContext.UserPermission.Where(x => (ultData != null ? x.UpdatedAt <= ultData : x.Active == true)).ToList();

            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<UserPermission> GetAllPermission(DateTime? ultimaAtt)
        {
            try
            {
                var list = _dataContext.UserPermission.Where(x => ultimaAtt == null ? (x.Active == true) : (x.UpdatedAt >= ultimaAtt)).ToList();
                return list;
            }
            catch (Exception)
            {
                return new List<UserPermission>();
            }
        }
        public List<string> AddShopProduct(List<UserPermission> listCustomer)
        {
            List<string> listRetorno = listCustomer.Select(obj => obj.Id.ToString()).ToList();
            try
            {
                foreach (var item in listCustomer)
                {
                    var exist = _dataContext.Set<UserPermission>().AsNoTracking().FirstOrDefault(x => x.Id == item.Id) != null ? true : false;
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

