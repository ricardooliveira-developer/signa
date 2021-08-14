using APISigna.domain.Commands;
using APISigna.domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace APISigna.domain.Interfaces
{
    public interface IDogs : IBaseRepository<DogsModel>
    {
        List<DogsModel> GetDogs();
        string InsertDogs(List<DogsCommand> dogsCommand);
        string UpdateDogs(List<DogsCommand> dogsCommand);
        string DeleteDogs(List<DogsCommand> dogsCommand);
    }
}
