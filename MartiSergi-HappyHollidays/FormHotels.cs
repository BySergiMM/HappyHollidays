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
    public partial class FormHotels : Form
    {

        private hoteles HotelSelected;

        public FormHotels()
        {
            InitializeComponent();
            if (HotelSelected == null)
            {
                ButtonEliminar.Visible = false;
                actividadesBindingSource.DataSource = ActHotelORM.SelectActividades();
                cadenasBindingSource.DataSource = CadHotelORM.SelectCadenaHoteles();
                ciudadesBindingSource.DataSource = CiudadesORM.SelectCiudades();
                ComboBoxActividades.SelectedValue = ComboBoxActividades.SelectedIndex;
                ComboBoxCadena.SelectedValue = ComboBoxCadena.SelectedIndex;
                ComboBoxCiudad.SelectedValue = ComboBoxCiudad.SelectedIndex;
            }
        }

        public FormHotels(hoteles hotel)
        {
            InitializeComponent();
            HotelSelected = hotel;
            actividadesBindingSource.DataSource = ActHotelORM.SelectActividades();
            cadenasBindingSource.DataSource = CadHotelORM.SelectCadenaHoteles();
            ciudadesBindingSource.DataSource = CiudadesORM.SelectCiudades();
            cargarHotel(HotelSelected);
            TextBoxNombre.Enabled = false;
            ComboBoxCiudad.Enabled = false;
        }

        private void cargarHotel(hoteles hotel)
        {
            TextBoxNombre.Text = hotel.nombre.ToString();
            ComboBoxCadena.SelectedItem = hotel.cadenas;
            ComboBoxCiudad.SelectedItem = hotel.ciudades;
            TextBoxUbicacion.Text = hotel.tipo.ToString();
            TextBoxTelefono.Text = hotel.telefono.ToString();
            TextBoxCategoria.Text = hotel.categoria.ToString();
            TextBoxDireccion.Text = hotel.direccion.ToString();
            Fill(hotel.act_hotel.ToList());
        }

        private void Fill(List<act_hotel> act_Hotel)
        {
            foreach (act_hotel act in act_Hotel)
            {
                DataGridView.Rows.Add();
                int rowIndex = DataGridView.Rows.Count - 1;

                DataGridView.Rows[rowIndex].Cells[0].Value = act.id_act;
                DataGridView.Rows[rowIndex].Cells[1].Value = act.actividades.descripcion;
                DataGridView.Rows[rowIndex].Cells[2].Value = act.grado;
            }
        }
        private List<act_hotel> GetActHotel()
        {
            List<act_hotel> listaActividades = new List<act_hotel>();

            foreach (DataGridViewRow row in DataGridView.Rows)
            {
                act_hotel actividad = new act_hotel();

                actividad.id_act = Convert.ToInt32(row.Cells[0].Value);
                actividad.nombre = row.Cells[1].Value.ToString();
                actividad.grado = Convert.ToInt32(row.Cells[2].Value);
                actividad.id_ciudad = Convert.ToInt32(ComboBoxCiudad.SelectedValue.ToString());
                listaActividades.Add(actividad);
            }

            return listaActividades;
        }

        private hoteles cogerHotel()
        {
            hoteles hotelToUpdate = new hoteles()
            {
                id_ciudad = HotelSelected.id_ciudad,
                direccion = TextBoxDireccion.Text,
                telefono = int.Parse(TextBoxTelefono.Text),
                tipo = TextBoxUbicacion.Text,
                categoria = int.Parse(TextBoxCategoria.Text),
                cadenas = new cadenas() { nombre = ComboBoxCadena.SelectedItem.ToString() },
                ciudades = new ciudades() { nombre = ComboBoxCiudad.SelectedItem.ToString() },
                act_hotel = GetActHotel()
            };

            return hotelToUpdate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HotelORM.DeleteHotel(HotelSelected);

            this.Close();
        }

        private void ComboBoxActividades_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            actividades selectedActividad = ComboBoxActividades.SelectedItem as actividades;

            if (selectedActividad != null)
            {
                TextBoxGradoDificultad.Text = ActHotelORM.SelectGradoDificultad(selectedActividad).ToString();
            }
            else
            {
                TextBoxGradoDificultad.Text = "";
            }
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            if (ButtonEliminar.Visible == false)
            {
                hoteles hotel = new hoteles();
                hotel.nombre = TextBoxNombre.Text;
                hotel.cif = ComboBoxCadena.SelectedValue.ToString();
                hotel.act_hotel = GetActHotel();
                hotel.id_ciudad = (int)ComboBoxCiudad.SelectedValue;
                hotel.categoria = Int32.Parse(TextBoxCategoria.Text);
                hotel.telefono = Int32.Parse(TextBoxTelefono.Text);
                hotel.direccion = TextBoxDireccion.Text;
                hotel.tipo = TextBoxUbicacion.Text;

                HotelORM.AddHotel(hotel);
            }
            else
            {
                hoteles hotelToUpdate = cogerHotel();

                HotelORM.UpdateHotel(HotelSelected, hotelToUpdate);
            }

            this.Close();
        }

        private void ButtonEliminar_Click_1(object sender, EventArgs e)
        {

            
            HotelORM.DeleteHotel(HotelSelected);
            MessageBox.Show("Hotel eliminado");
            this.Close();
        }

        private void ButtonBorrar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DataGridView.CurrentRow;

            if (row != null)
            {
                DataGridView.Rows.Remove(row);
            }
        }

        private void ButtonAñadir_Click(object sender, EventArgs e)
        {
            int idAct = (int)ComboBoxActividades.SelectedValue;
            string nombre = ComboBoxActividades.Text;
            int grado = int.Parse(TextBoxGradoDificultad.Text);

            bool existe = false;
            foreach (DataGridViewRow row in DataGridView.Rows)
            {
                if (row.Cells[0].Value != null && (int)row.Cells[0].Value == idAct)
                {
                    existe = true;
                    break;
                }
            }

            if (existe)
            {
                MessageBox.Show("Este elemento ya fue agregado anteriormente.", "Elemento duplicado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataGridView.Rows.Add();

                int rowIndex = DataGridView.Rows.Count - 1;

                DataGridView.Rows[rowIndex].Cells[0].Value = idAct;
                DataGridView.Rows[rowIndex].Cells[1].Value = nombre;
                DataGridView.Rows[rowIndex].Cells[2].Value = grado;
            }
        }
    }
}