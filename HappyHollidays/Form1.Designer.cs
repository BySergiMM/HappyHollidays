namespace HappyHollidays
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PictureBoxFotos = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ButtonHoteles = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonCadenas = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFotos)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxFotos
            // 
            this.PictureBoxFotos.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxFotos.Image")));
            this.PictureBoxFotos.ImageRotate = 0F;
            this.PictureBoxFotos.Location = new System.Drawing.Point(107, 108);
            this.PictureBoxFotos.Name = "PictureBoxFotos";
            this.PictureBoxFotos.Size = new System.Drawing.Size(553, 330);
            this.PictureBoxFotos.TabIndex = 0;
            this.PictureBoxFotos.TabStop = false;
            // 
            // ButtonHoteles
            // 
            this.ButtonHoteles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonHoteles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonHoteles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonHoteles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonHoteles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonHoteles.ForeColor = System.Drawing.Color.White;
            this.ButtonHoteles.Location = new System.Drawing.Point(418, 27);
            this.ButtonHoteles.Name = "ButtonHoteles";
            this.ButtonHoteles.Size = new System.Drawing.Size(180, 45);
            this.ButtonHoteles.TabIndex = 1;
            this.ButtonHoteles.Text = "Hoteles";
            this.ButtonHoteles.Click += new System.EventHandler(this.ButtonHoteles_Click);
            // 
            // ButtonCadenas
            // 
            this.ButtonCadenas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCadenas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCadenas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonCadenas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonCadenas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonCadenas.ForeColor = System.Drawing.Color.White;
            this.ButtonCadenas.Location = new System.Drawing.Point(161, 27);
            this.ButtonCadenas.Name = "ButtonCadenas";
            this.ButtonCadenas.Size = new System.Drawing.Size(180, 45);
            this.ButtonCadenas.TabIndex = 2;
            this.ButtonCadenas.Text = "Cadenas";
            this.ButtonCadenas.Click += new System.EventHandler(this.ButtonCadenas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonCadenas);
            this.Controls.Add(this.ButtonHoteles);
            this.Controls.Add(this.PictureBoxFotos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Happy Holidays";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFotos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxFotos;
        private Guna.UI2.WinForms.Guna2Button ButtonHoteles;
        private Guna.UI2.WinForms.Guna2Button ButtonCadenas;
    }
}

