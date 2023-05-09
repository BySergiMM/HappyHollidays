using MartiSergi_HappyHollidays.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MartiSergi_HappyHollidays
{
    public partial class Menu : Form
    {

        hoteles hot;
        cadenas cad;
        Boolean hotel = false;

        public Menu()
        {
            InitializeComponent();
            panelCadenas.Visible = false;
            panelHoteles.Visible = true;
            hotelesBindingSource.DataSource = HotelORM.SelectHoteles();
            hotel = true;
        }
        private void RefrescarTablaCadenaHoteles()
        {
            panelCadenas.Visible = true;
            panelHoteles.Visible = false;
            cadenasBindingSource.DataSource = CadHotelORM.SelectCadenaHoteles();
            hotel = false;
        }
        private void RefrescarTablaHoteles()
        {
            panelCadenas.Visible = false;
            panelHoteles.Visible = true;
            hotelesBindingSource.DataSource = HotelORM.SelectHoteles();
            hotel = true;

        }
        private void pictureBoxCadenaHoteles_Click(object sender, EventArgs e)
        {
            RefrescarTablaCadenaHoteles();
        }
    }
}
