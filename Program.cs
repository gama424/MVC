using System;
using MVC.Controllers;
using MVC.Views;



namespace MVC_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produtos = new ProdutoController();
            produtos.Buscar("200,56");

        }
    }
}
