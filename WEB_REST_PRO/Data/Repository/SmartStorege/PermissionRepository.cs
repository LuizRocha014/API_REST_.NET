using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using WEB_REST_PRO.Data.Context;
using WEB_REST_PRO.Data.Interface.SmartStorege;

namespace WEB_REST_PRO.Data.Repository.SmartStorege
{
	public class PermissionRepository : BaseRepository, IPermissionRepository
    {
        private readonly DataContext _dataContext;
        public PermissionRepository(DataContext dataContext) : base(dataContext)
		{
            _dataContext = dataContext;
        }
        public List<Permission> GetAllPermission(DateTime? ultimaAtt)
        {
            try
            {
                var list = _dataContext.Permission.Where(x => ultimaAtt == null ? (x.Active == true) : (x.UpdatedAt >= ultimaAtt)).ToList();
                return list;
            }
            catch (Exception)
            {
                return new List<Permission>();
            }
        }
        public List<string> AddShopProduct(List<Permission> listCustomer)
        {
            List<string> listRetorno = listCustomer.Select(obj => obj.Id.ToString()).ToList();
            try
            {
                foreach (var item in listCustomer)
                {
                    var exist = _dataContext.Set<Permission>().AsNoTracking().FirstOrDefault(x => x.Id == item.Id) != null ? true : false;
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

