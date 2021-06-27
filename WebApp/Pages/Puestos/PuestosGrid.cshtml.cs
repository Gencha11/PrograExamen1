using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;

namespace WebApp.Pages.Puestos
{
    public class PuestosGridModel : PageModel
    {
        private readonly IPuestosService puestosService;

        public PuestosGridModel(IPuestosService puestosService)
        {
            this.puestosService = puestosService;
        }

        public IEnumerable<PuestosEntity> PuestosGridList { get; set; } = new List<PuestosEntity>();

        public string Mensaje { get; set; } = "";

        public async Task<IActionResult> OnGet()
        {
            try
            {
                PuestosGridList = await puestosService.Get();

                if (TempData.ContainsKey("Msg"))
                {
                    Mensaje = TempData["Msg"] as string;
                }

                TempData.Clear();

                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }

        public async Task<IActionResult> OnGetEliminar(int id)
        {
            try
            {
                var result = await puestosService.Delete(new()
                {
                    Id_Puesto = id

                });

                if (result.CodeError != 0)
                {
                    throw new Exception(result.MsgError);
                }
                TempData["Msg"] = "Se eliminó correctamente";

                return Redirect("PuestosGrid");

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }
    }
}
