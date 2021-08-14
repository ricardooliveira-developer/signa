
using APISigna.domain.Commands;
using APISigna.domain.Interfaces;
using APISigna.domain.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APISigna.domain.Handles
{
    public class CatsHandler : BaseHandler
    {
        private readonly ICats _repository;

        public CatsHandler(ICats cats) => _repository = cats;

        public List<CatsResults> GetCats()
        {
            var cats = _repository.GetCats();

            var catsList = cats.Select(x => new CatsResults
            {
                Id = x.Id,
                Name = x.Name,
                Age = x.Age,
                OwnerId = x.OwnerId
            }).ToList();

            return catsList;
        }

        public PadraoResult InsertCats(List<CatsCommand> catsCommand)
        {
            string result = _repository.InsertCats(catsCommand);

            var retorno = new PadraoResult
            {
                FeedBack = result
            };

            return retorno;
        }

        public PadraoResult UpdateCats(List<CatsCommand> catsCommand)
        {
            string result = _repository.UpdateCats(catsCommand);

            var retorno = new PadraoResult
            {
                FeedBack = result
            };

            return retorno;
        }

        public PadraoResult DeleteCats(List<CatsCommand> catsCommand)
        {
            string result = _repository.DeleteCats(catsCommand);

            var retorno = new PadraoResult
            {
                FeedBack = result
            };

            return retorno;
        }
    }
}
