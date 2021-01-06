using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

namespace MVC_CONSOLE.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        private const string PATH = "Database/Produto.csv";


        public Produto()
        {
            string pasta = PATH.Split("/")[0];


            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }


            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }

        }

        public List<Produto> Ler()
        {

            List<Produto> produtos = new List<Produto>();

            string[] linhas  = File.ReadAllLines(PATH);

            foreach (string item in linhas)
                
            {

                string[] atributos = item.Split(";");

                Produto prod = new Produto();
                prod.Codigo = Int32.Parse( SepararDado(atributos[0]) );
                prod.Nome = SepararDado(atributos[1]);
                prod.Preco = float.Parse( SepararDado(atributos[2] ));

                produtos.Add(prod);
                
            }

          
            return produtos;
        }

        private string SepararDado(string txt)
        {
            return txt.Split("=")[1];

        }
        
    }
}