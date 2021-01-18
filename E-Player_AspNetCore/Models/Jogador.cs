using System;
using System.Collections.Generic;
using Microsoft.Extensions.Primitives;

namespace E_Player_AspNetCore.Models
{
    public class Jogador
    {
        public int IdJogador { get; set; }
        
        public string Name { get; set; }

        public string IdEquipe { get; set; }
        public StringValues Nome { get; internal set; }
        public StringValues Email { get; internal set; }
        public StringValues Senha { get; internal set; }

        internal dynamic ReadAll()
        {
            throw new NotImplementedException();
        }

        internal void Create(Jogador novoJogador)
        {
            throw new NotImplementedException();
        }

        internal List<string> ReadAllLinesCSV(string v)
        {
            throw new NotImplementedException();
        }
    }
}