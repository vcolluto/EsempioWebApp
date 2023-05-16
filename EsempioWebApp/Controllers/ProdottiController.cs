using Microsoft.AspNetCore.Mvc;

namespace EsempioWebApp.Controllers
{
    public class ProdottiController : Controller    //gestisce /Prodotti/*
    {
        public IActionResult Index()        //gestisce /Prodotti/Index  oppure /Prodotti
        {
            return View();
        }
    }
}
