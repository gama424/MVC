using System;
using System.Collections.Generic;
using MVC_CONSOLE.Models;

namespace MVC.Views
{
    public class ProdutoView
    {
        public void MostrarNoConsole(List<Produto> lista)
        
        {

                foreach(Produto item in lista){
                    Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
                    
                }
        }
    }
}