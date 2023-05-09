using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MartiSergi_HappyHollidays.Models
{
    internal class ActHotelORM
    {
        public static List<string> SelectAct_Hotel(hoteles hotel)
        {
            List<string> _act_hotel = ORM.entitites.act_hotel
                .Where(c => c.id_ciudad == hotel.id_ciudad && c.nombre == hotel.nombre)
                .Select(c => c.actividades.descripcion)
                .ToList();

            return _act_hotel;
        }

        public static List<actividades> SelectActividades()
        {
            List<actividades> _act_hotel = ORM.entitites.actividades
                .ToList();

            return _act_hotel;
        }

        public static int SelectGradoDificultad(actividades actividades)
        {
            int grado = ORM.entitites.act_hotel
                .Where(c => c.id_act == actividades.id_act)
                .Select(c => c.grado)
                .FirstOrDefault();

            return grado;
        }


    }
}
