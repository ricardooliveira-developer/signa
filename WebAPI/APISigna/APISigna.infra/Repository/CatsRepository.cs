using APISigna.domain.Commands;
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
    public class CatsRepository : BaseSQLServerRepository<CatsModel>, ICats
    {
        public CatsRepository(Context context) : base(context) { }

        public string DeleteCats(List<CatsCommand> catsCommand)
        {
            try
            {
                string proc = "SP_DeleteCats";

                foreach (var cats in catsCommand)
                {
                    var args = new
                    {
                        @Id = cats.Id,
                    };

                    Db.ExecuteScalarProc(proc, args, commandTimeout: 1800);
                }

                return "Sucesso";
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
        }

        public List<CatsModel> GetCats()
        {
            string proc = "SP_RetornaCats";

            var list = Db.ListProc<CatsModel>(proc, commandTimeout: 1800).ToList();

            return list;
        }

        public string InsertCats(List<CatsCommand> catsCommand)
        {
            try
            {
                string proc = "SP_InserirCats";

                foreach (var cat in catsCommand)
                {
                    var args = new
                    {
                        @Nome = cat.Name,
                        @Age = cat.Age,
                        @Id = cat.OwnerId
                    };

                    Db.ExecuteScalarProc(proc, args, commandTimeout: 1800);
                }

                return "Sucesso";
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
        }

        public string UpdateCats(List<CatsCommand> catsCommand)
        {
            try
            {
                string proc = "SP_UpdateCats";

                foreach (var cats in catsCommand)
                {
                    var args = new
                    {
                        @Id = cats.Id,
                        @Nome = cats.Name,
                        @Age = cats.Age,
                        @OwnerId = cats.OwnerId
                    };

                    Db.ExecuteScalarProc(proc, args, commandTimeout: 1800);
                }

                return "Sucesso";
            }
            catch (Exception e)
            {
                return e.Message.ToString();
            }
        }
    }
}
