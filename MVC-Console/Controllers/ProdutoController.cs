using System.Collections.Generic;
using MVC.Views;
using MVC_CONSOLE.Models;

namespace MVC.Controllers
{
    public class ProdutoController
    {
        
        Produto produto = new Produto();

        ProdutoView produtoView = new ProdutoView();

        public void MostrarProdutos()
        {
            List<Produto> todos = produto.Ler();
            produtoView.ListarTodos(todos);
        }
    }
}