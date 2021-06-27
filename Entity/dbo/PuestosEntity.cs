using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PuestosEntity
    {
        public int? Id_Puesto { get; set; }
        public string Nombre { get; set; }
        public int Salario { get; set; }
        public bool Estado { get; set; }
    }
}
