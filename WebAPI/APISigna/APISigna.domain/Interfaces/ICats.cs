using APISigna.domain.Commands;
using APISigna.domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace APISigna.domain.Interfaces
{
    public interface ICats : IBaseRepository<CatsModel>
    {
        List<CatsModel> GetCats();
        string InsertCats(List<CatsCommand> catsCommand);
        string UpdateCats(List<CatsCommand> catsCommand);
        string DeleteCats(List<CatsCommand> catsCommand);
    }
}
