using APISigna.domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace APISigna.domain.Interfaces
{
    public interface IOwner : IBaseRepository<OwnerModel>
    {
        List<OwnerModel> GetOwner();
    }
}
