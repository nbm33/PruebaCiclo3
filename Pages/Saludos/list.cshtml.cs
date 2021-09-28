using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using HolaWeb.App.Dominio;
using HolaWeb.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolaWeb.App.Frontend.Pages
{
    public class listModel : PageModel
    {
        //private string[] saludos = {"Buenos Días", "Buenas Tardes", "Buenas Noches", "Hasta Mañana"};
        //public List<string> ListaSaludos { get; set; }
        private readonly IRepositorioSaludos repositorioSaludos;

        public IEnumerable<Saludo> Saludos { get; set; }

        public listModel(IRepositorioSaludos repositorioSaludos)
        {
            this.repositorioSaludos=repositorioSaludos;
        }

        public void OnGet()
        {
            //ListaSaludos = new List<string>();
            //ListaSaludos.AddRange(ListaSaludos);
            Saludos=repositorioSaludos.GetAll();
        }
    }
}
