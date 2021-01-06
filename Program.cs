using System;
using MVC.Controllers;
using MVC_CONSOLE.Models;

namespace MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ProdutoController produtoController = new ProdutoController();
            produtoController.MostrarProdutos();

        }
    }
}