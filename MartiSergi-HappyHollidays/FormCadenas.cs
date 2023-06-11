using MartiSergi_HappyHollidays.Models;
using System;
using System.Windows.Forms;

namespace MartiSergi_HappyHollidays
{
    public partial class FormCadenas : Form
    {
        cadenas cadenaSeleccionada;

        public FormCadenas()
        {
            InitializeComponent();
            ButtonEliminar.Visible = false;
        }

        public FormCadenas(cadenas cad)
        {
            cadenaSeleccionada = cad;
            InitializeComponent();
            cargarCadena(cadenaSeleccionada);
            ButtonEliminar.Visible = true;
            textBoxCif.Enabled = false;
        }

        private void cargarCadena(cadenas cad)
        {
            textBoxCif.Text = cad.cif;
            textBoxDirFiscal.Text = cad.dir_fis;
            textBoxNombre.Text = cad.nombre;
        }

        private cadenas cogerCadena()
        {
            cadenas cadenaToUpdate = new cadenas()
            {
                cif = textBoxCif.Text,
                dir_fis = textBoxDirFiscal.Text,
                nombre = textBoxNombre.Text
            };

            return cadenaToUpdate;
        }

        private void ButtonAnadir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCif.Text) || string.IsNullOrWhiteSpace(textBoxDirFiscal.Text) || string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show("No puedes añadir una cadena vacía");
            }
            else if (CadHotelORM.NameExists(textBoxNombre.Text))
            {
                MessageBox.Show("No puedes introducir el mismo nombre");
            }
            else if (CadHotelORM.CifExists(textBoxCif.Text))
            {
                MessageBox.Show("No puedes introducir un CIF duplicado");
            }
            else
            {
                cadenas cadenaUpdate = cogerCadena();

                if (ButtonEliminar.Visible)
                {
                    CadHotelORM.UpdateCadena(cadenaSeleccionada, cadenaUpdate);
                    MessageBox.Show("Cadena actualizada");
                }
                else
                {
                    CadHotelORM.AddCadena(cadenaUpdate);
                    MessageBox.Show("Cadena añadida");
                }

                this.Close();
            }
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Estás seguro de que quieres eliminar la cadena?",
                                                        "Confirmación de eliminación",
                                                        MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                CadHotelORM.DeleteCadena(cadenaSeleccionada);
                MessageBox.Show("Cadena eliminada");
                this.Close();
            }
        }

    }
}
