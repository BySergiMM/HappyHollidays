using MartiSergi_HappyHollidays.Models;
using System;
using System.Linq;
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
        private string GetNombreCiudadByCif(string cif)
        {
            var hotel = hotelesBindingSource.List.OfType<hoteles>().FirstOrDefault(h => h.cif == cif);
            if (hotel != null)
            {
                return hotel.ciudades.nombre;
            }
            return string.Empty;
        }

        private void DataGridViewHoteles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0) // Verifica que se esté formateando la columna de identificador de cadena
            {
                string id = DataGridViewHoteles.Rows[e.RowIndex].Cells[5].Value.ToString();
                string nombreCadena = CadHotelORM.SelectNombreCadenaById(id); // Obtener el nombre de la cadena según el identificador
                e.Value = nombreCadena; // Asignar el nombre de la cadena al valor de la celda
            }

            if (e.ColumnIndex == 6 && e.RowIndex >= 0) // Verifica que se esté formateando la columna de cif de la cadena
            {
                string cif = DataGridViewHoteles.Rows[e.RowIndex].Cells[5].Value.ToString();
                string nombreCiudad = GetNombreCiudadByCif(cif); // Obtener el nombre de la ciudad según el cif
                e.Value = nombreCiudad; // Asignar el nombre de la ciudad al valor de la celda
            }
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