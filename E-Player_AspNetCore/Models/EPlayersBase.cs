using System.Collections.Generic;
using System.IO;

namespace E_Player_AspNetCore.Models
{
    public class EPlayersBase
    {
        public void CreateFolderAndFile(string _path)
        {

            //database/equipe.csv

                string folder = _path.Split("/")[0];
                string file = _path.Split("/")[1];


            if(!Directory.Exists(folder))
            {
                    Directory.CreateDirectory(folder);
            }

            if(!File.Exists(_path))
            {
                File.Create(_path);
            }

        }
            public List<string> ReadAllLinesCSV(string path)
            {

                    List<string> linhas = new List<string>();

                    //using responsavel por abrir e fechar arquivo automaticamente
                    using(StreamReader file = new StreamReader(path))
                    {
                            string linha;

                            // percorrer as linhas com um laço while

                            while( (linha = file.ReadLine() ) != null)

                            {

                                    linhas.Add(linha);

                            }
                    }


                    return linhas;

            }
    
                public void RewriteCSV(string path, List<string> linhas)

                {

                    using(StreamWriter output = new StreamWriter(path))
                    {
                                foreach (var item in linhas)
                                {
                                    output.Write(item + "\n");
                                }

                    }
                
                
                }




}

