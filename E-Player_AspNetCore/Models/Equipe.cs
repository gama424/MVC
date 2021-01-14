
using System.Collections.Generic;
using System.IO;
using E_Player_AspNetCore.Interfaces;

namespace E_Player_AspNetCore.Models

{
    public class Equipe : EPlayersBase , IEquipe
    {
        public int IdEquipe { get; set; }

        public string Nome { get; set; }

        public string Imagem { get; set; }


        private const string PATH = "Database/Equipe.csv";


        public Equipe(){
            CreateFolderAndFile(PATH);
        }
            

            // criamos o metodo para preparar a linha do csv

            public string Prepare(Equipe e)
            {

                return $"{e.IdEquipe};{e.Nome};{e.Imagem}";
            }



        public void Create(Equipe e)
        {
            //preparamos o array de string para o metodo AppendAllLines
            string[] linhas = { Prepare(e) };
            //acrescentamos novas linhas
            File.AppendAllLines(PATH, linhas);
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Equipe> ReadAll()
        {

            //LENDO AS LINHAS DO CSV
            List<Equipe> equipes = new List<Equipe>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach(string item in linhas)
            {
                string[] linha = item.Split(";");

                    //[0] = vivo, [1] = Vivokey, [2] = vivo.jpg
                    
                Equipe novaEquipe = new Equipe();
                novaEquipe.IdEquipe = int.Parse( linha[0] );
                novaEquipe.Nome = linha[1];
                novaEquipe.Imagem = linha[2];


                equipes.Add(novaEquipe);

            }


            return equipes;
        }

        public void Update(Equipe e)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            //

            linhas.RemoveAll(x => x.Split(";")[0] == e.IdEquipe.ToString());
            
            ////adicionamos na lista com o codigo comprado
            linhas.Add(Prepare(e) );


            //rescreve o csv com a lista alterada
            RewriteCSV(PATH, linhas);
        }
    }
}