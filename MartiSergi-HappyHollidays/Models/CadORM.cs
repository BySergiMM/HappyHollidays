using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MartiSergi_HappyHollidays.Models
{
    internal class CadORM
    {
        public static string SelectByCif(string cif)
        {
            cadenas hoteles = ORM.entitites.cadenas.FirstOrDefault(t => t.cif == cif);


            return hoteles.nombre;
        }
    }
}
