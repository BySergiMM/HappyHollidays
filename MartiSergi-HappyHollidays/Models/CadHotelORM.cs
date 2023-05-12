using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MartiSergi_HappyHollidays.Models
{
    internal class CadHotelORM
    {
        public static List<cadenas> SelectCadenaHoteles()
        {
            return ORM.entitites.cadenas.ToList();
        }

        public static void AddCadena(cadenas cadena)
        {
            ORM.entitites.cadenas.Add(cadena);

            ORM.MySaveChanges();
        }


        public static void UpdateCadena(cadenas cadena, cadenas update)
        {
            var cadenaToUpdate = ORM.entitites.cadenas.FirstOrDefault(h => h.cif == cadena.cif);

            if (cadenaToUpdate != null)
            {
                cadenaToUpdate.cif = update.cif;
                cadenaToUpdate.dir_fis = update.dir_fis;
                cadenaToUpdate.nombre = update.nombre;

                ORM.MySaveChanges();
            }
        }

        public static void DeleteCadena(cadenas cadena)
        {
            var cadenaToDelete = ORM.entitites.cadenas.FirstOrDefault(h => h.cif == cadena.cif);

            if (cadenaToDelete != null)
            {
                ORM.entitites.cadenas.Remove(cadenaToDelete);

                ORM.MySaveChanges();
            }
        }
    }
}
