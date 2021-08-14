using APISigna.domain.Interfaces;
using APISigna.domain.Models;
using APISigna.infra.Data;
using APISigna.infra.Driver;
using APISigna.infra.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APISigna.infra.Repository
{
    public class OwnerRepository : BaseSQLServerRepository<OwnerModel>, IOwner
    {
        public OwnerRepository(Context context) : base(context) { }

        public List<OwnerModel> GetOwner()
        {
            string proc = "SP_RetornaOwner";

            var list = Db.ListProc<OwnerModel>(proc, commandTimeout: 1800).ToList();

            return list;
        }
    }
}
