using System.Collections.Generic;
using MVC_CONSOLE.Models;
using MVC.Views;

namespace MVC.Controllers
{
    public class ProdutoController
    {
        Produto produtoModel = new Produto();
        ProdutoView produtoview = new ProdutoView(); 


        public void Listar()
        {
            List<Produto> lista = produtoModel.Ler();
            produtoview.MostrarNoConsole(lista);

        }  
        public void Buscar(string termo)
        {
            List<Produto> lista = produtoModel.Ler().FindAll(x => x.Preco == float.Parse(termo));
            produtoview.MostrarNoConsole(lista);
        }
    }
}