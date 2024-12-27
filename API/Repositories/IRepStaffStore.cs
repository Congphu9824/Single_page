using System.Data;
using System.Security.Cryptography.X509Certificates;
using API.ApplicationDbContext;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public interface IRepStaffStore
    {
        Task<List<T>> GetListObjectAsync<T>(string storeName);
        Task<List<T>> GetListObjectAsync<T>(string storeName, object value);

    }

    public class RepStaffStore(IConfiguration _configuration, StaffDbContext _db) : IRepStaffStore
    {
        private readonly string connStr = _configuration.GetConnectionString("DefaultConnection");

        public async Task<List<T>> GetListObjectAsync<T>(string storeName)
        {
            IEnumerable<T> arr;
            using (var conn = new SqlConnection(connStr))
            {
                if (conn.State == ConnectionState.Closed)
                { conn.Open(); }
                try
                {
                    arr = await conn.QueryAsync<T>(storeName, commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally { conn.Close(); conn.Dispose(); }
            }
            return arr.ToList();
        }

        public async Task<List<T>> GetListObjectAsync<T>(string storeName, object value)
        {
            IEnumerable<T> arr;
            using (var conn = new SqlConnection(connStr))
            {
                if (conn.State == ConnectionState.Closed)
                { conn.Open(); }
                try
                {
                    arr = await conn.QueryAsync<T>(storeName, value, commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally { conn.Close(); conn.Dispose(); }
            }
            return arr.ToList();
        }

    }
}
