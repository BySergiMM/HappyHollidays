using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyHollidays
{
    public partial class Cadenas : Form
    {
        public Cadenas()
        {
            InitializeComponent();
        }

        private void ButtonVolver_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.ShowDialog();
            this.Close();
        }

        private void ButtonCadenas_Click(object sender, EventArgs e)
        {
            Cadenas cadenas = new Cadenas();
            cadenas.ShowDialog();
            this.Close();
        }

        private void ButtonHoteles_Click(object sender, EventArgs e)
        {
            Hoteles hoteles = new Hoteles();
            hoteles.ShowDialog();
            this.Close();
        }
    }
}
