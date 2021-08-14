using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;

namespace APISigna.infra.Extensions
{
    public static class DbContextExtension
    {
        public static T FindSql<T>(this DbContext db, string sql, object param = null, int? commandTimeout = null)
        {
            return db.Database.GetDbConnection().QueryFirstOrDefault<T>(sql, param, commandTimeout: commandTimeout, commandType: CommandType.StoredProcedure);
        }
        public static IEnumerable<T> ListProc<T>(this DbContext db, string proc, object param = null, int? commandTimeout = null)
        {
            return db.Database.GetDbConnection().Query<T>(proc, param, commandTimeout: commandTimeout, commandType: CommandType.StoredProcedure);
        }
        public static int ExecuteScalarProc(this DbContext db, string proc, object param = null, int? commandTimeout = null)
        {
            return db.Database.GetDbConnection().ExecuteScalar<int>(proc, param, commandTimeout: commandTimeout, commandType: CommandType.StoredProcedure);
        }
    }
}
