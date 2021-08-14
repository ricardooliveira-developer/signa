using APISigna.domain.Commands;
using APISigna.domain.Interfaces;
using APISigna.domain.Models;
using APISigna.infra.Data;
using APISigna.infra.Driver;
using APISigna.infra.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APISigna.infra.Repository
{
    public class DogsRepository : BaseSQLServerRepository<DogsModel>, IDogs
    {
        public DogsRepository(Context context) : base(context) { }

        public string DeleteDogs(List<DogsCommand> dogsCommand)
        {
            try
            {
                string proc = "SP_DeleteDogs";

                foreach (var dogs in dogsCommand)
                {
                    var args = new
                    {
                        @Id = dogs.Id
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

        public List<DogsModel> GetDogs()
        {
            string proc = "SP_RetornaDogs";

            var list = Db.ListProc<DogsModel>(proc, commandTimeout: 1800).ToList();

            return list;
        }

        public string InsertDogs(List<DogsCommand> dogsCommand)
        {
            try
            {
                string proc = "SP_InserirDogs";

                foreach (var dogs in dogsCommand)
                {
                    var args = new
                    {
                        @Nome = dogs.Name,
                        @Age = dogs.Age,
                        @Id = dogs.OwnerId
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

        public string UpdateDogs(List<DogsCommand> dogsCommand)
        {
            try
            {
                string proc = "SP_UpdateDogs";

                foreach (var dogs in dogsCommand)
                {
                    var args = new
                    {
                        @Id = dogs.Id,
                        @Nome = dogs.Name,
                        @Age = dogs.Age,
                        @OwnerId = dogs.OwnerId
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
