using APISigna.domain.Commands;
using APISigna.domain.Interfaces;
using APISigna.domain.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APISigna.domain.Handles
{
    public class DogsHandler : BaseHandler
    {
        private readonly IDogs _repository;

        public DogsHandler(IDogs dogs) => _repository = dogs;

        public List<DogsResult> GetDogs()
        {
            var dogs = _repository.GetDogs();

            var dogsList = dogs.Select(x => new DogsResult
            {
                Id = x.Id,
                Name = x.Name,
                Age = x.Age,
                OwnerId = x.OwnerId
            }).ToList();

            return dogsList;
        }

        public PadraoResult InsertDogs(List<DogsCommand> dogsCommand)
        {
            string result = _repository.InsertDogs(dogsCommand);

            var retorno = new PadraoResult
            {
                FeedBack = result
            };

            return retorno;
        }

        public PadraoResult UpdateDogs(List<DogsCommand> dogsCommand)
        {
            string result = _repository.UpdateDogs(dogsCommand);

            var retorno = new PadraoResult
            {
                FeedBack = result
            };

            return retorno;
        }

        public PadraoResult DeleteDogs(List<DogsCommand> dogsCommand)
        {
            string result = _repository.DeleteDogs(dogsCommand);

            var retorno = new PadraoResult
            {
                FeedBack = result
            };

            return retorno;
        }
    }
}
