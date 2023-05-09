using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MartiSergi_HappyHollidays.Models
{
    internal class HotelORM
    {
        public static List<hoteles> SelectHoteles()
        {
            return ORM.entitites.hoteles.ToList();
        }

        public static void AddHotel(hoteles hotel)
        {
            ORM.entitites.hoteles.Add(hotel);

            ORM.MySaveChanges();
        }


        public static void UpdateHotel(hoteles hotel, hoteles update)
        {
            var hotelToUpdate = ORM.entitites.hoteles.FirstOrDefault(h => h.id_ciudad == hotel.id_ciudad && h.nombre == hotel.nombre);

            if (hotelToUpdate != null)
            {
                hotelToUpdate.tipo = update.tipo;
                hotelToUpdate.telefono = update.telefono;
                hotelToUpdate.categoria = update.categoria;
                hotelToUpdate.direccion = update.direccion;
                hotelToUpdate.act_hotel = update.act_hotel;

                ORM.MySaveChanges();
            }
        }

        public static void DeleteHotel(hoteles hotel)
        {
            var hotelToDelete = ORM.entitites.hoteles.FirstOrDefault(h => h.id_ciudad == hotel.id_ciudad && h.nombre == hotel.nombre);

            if (hotelToDelete != null)
            {
                ORM.entitites.hoteles.Remove(hotelToDelete);

                ORM.MySaveChanges();
            }
        }




    }
}
