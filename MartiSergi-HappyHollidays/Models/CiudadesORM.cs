﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MartiSergi_HappyHollidays.Models
{
    internal class CiudadesORM
    {
        public static List<ciudades> SelectCiudades()
        {
            return ORM.entitites.ciudades.ToList();
        }
    }
}