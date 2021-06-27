using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;

namespace WebApp.Pages.Departamentos
{
    public class DepartamentosGridModel : PageModel
    {
        private readonly IDepartamentosService departamentosService;

        public DepartamentosGridModel(IDepartamentosService departamentosService)
        {
            this.departamentosService = departamentosService;
        }

        public IEnumerable<DepartamentosEntity> DepartamentosGridList { get; set; } = new List<DepartamentosEntity>();

        public string Mensaje { get; set; } = "";

        public async Task<IActionResult> OnGet()
        {
            try
            {
                DepartamentosGridList = await departamentosService.Get();

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
                var result = await departamentosService.Delete(new()
                {
                    Id_Departamento = id

                });

                if (result.CodeError != 0)
                {
                    throw new Exception(result.MsgError);
                }
                TempData["Msg"] = "Se eliminó correctamente";

                return Redirect("DepartamentosGrid");

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }
    }
}
