using MartiSergi_HappyHollidays.Models;
using System;
using System.Windows.Forms;

namespace MartiSergi_HappyHollidays
{
    public partial class Menu : Form
    {

        hoteles ValHotel;
        cadenas ValCadena;
        Boolean hotel = false;

        public Menu()
        {
            InitializeComponent();
            PanelCadena.Visible = false;
            PanelHotels.Visible = true;
            hotelesBindingSource.DataSource = HotelORM.SelectHoteles();
            hotel = true;
        }

        private void RecargarCadenas()
        {
            PanelCadena.Visible = true;
            PanelHotels.Visible = false;
            cadenasBindingSource.DataSource = CadHotelORM.SelectCadenaHoteles();
            hotel = false;
        }

        private void RecargarHoteles()
        {
            PanelCadena.Visible = false;
            PanelHotels.Visible = true;
            hotelesBindingSource.DataSource = HotelORM.SelectHoteles();
            hotel = true;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (hotel)
            {
                RecargarHoteles();
            }
            else
            {
                RecargarCadenas();
            }
        }

        private void ButtonCadena_Click(object sender, EventArgs e)
        {
            RecargarCadenas();
        }

        private void ButtonHoteles_Click(object sender, EventArgs e)
        {
            RecargarHoteles();
        }

        private void ButtonAnadir_Click(object sender, EventArgs e)
        {
            if (hotel)
            {
                FormHotels hoteles = new FormHotels();
                hoteles.ShowDialog();
                RecargarHoteles();
            }
            else
            {
                FormCadenas cadenas = new FormCadenas();
                cadenas.ShowDialog();
                RecargarCadenas();
            }
        }

        private void DataGridViewHoteles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string id = DataGridViewHoteles.Rows[e.RowIndex].Cells[5].Value.ToString();
            string result = CadORM.SelectByCif(id);
        }

        private void DataGridViewHoteles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (hotel)
                {
                    ValHotel = (hoteles)DataGridViewHoteles.CurrentRow.DataBoundItem;
                    FormHotels Hotels = new FormHotels(ValHotel);
                    Hotels.ShowDialog();
                    RecargarHoteles();
                }
            }
        }

        private void DataGridViewCadena_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (!hotel)
                {
                    ValCadena = (cadenas)DataGridViewCadena.CurrentRow.DataBoundItem;
                    FormCadenas Cadena = new FormCadenas(ValCadena);
                    Cadena.ShowDialog();
                    RecargarCadenas();
                }
            }
        }
    }
}