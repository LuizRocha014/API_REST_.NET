using System;
using System.Security.Cryptography;
using System.Text;
using WEB_REST_PRO.Data.Context;

public class BaseRepository : IBaseRepository
{
    private readonly DataContext _context;
    private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

    public BaseRepository(DataContext context)
    {
        _context = context;
    }
    public void Add<T>(T entity) where T : class
    {
        _context.Add(entity);
    }

    public void Delete<T>(T entity) where T : class
    {
        _context.Remove(entity);
    }

    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public void Update<T>(T entity) where T : class
    {
        _context.Update(entity);
    }

    public string passWordHash(string input)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder builder = new StringBuilder();
            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2")); // Converte o byte em uma string hexadecimal
            }
            return builder.ToString();
        }
    }


}

