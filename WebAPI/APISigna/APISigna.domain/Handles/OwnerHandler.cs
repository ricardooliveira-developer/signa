using APISigna.domain.Interfaces;
using APISigna.domain.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APISigna.domain.Handles
{
    public class OwnerHandler : BaseHandler
    {
        private readonly IOwner _repository;
        public OwnerHandler(IOwner owner) => _repository = owner;

        public List<OwnerResult> GetOwner()
        {
            var owner = _repository.GetOwner();

            var ownerList = owner.Select(x => new OwnerResult
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();

            return ownerList;
        }
    }
}
