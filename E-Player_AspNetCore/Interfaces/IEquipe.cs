using System.Collections.Generic;
using E_Player_AspNetCore.Models;

namespace E_Player_AspNetCore.Interfaces
{
    public interface IEquipe
    {
         void Create(Equipe e);


         List<Equipe> ReadAll();

         void Update(Equipe e);
        void Delete(int id);

    }
}