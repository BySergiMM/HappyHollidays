namespace MartiSergi_HappyHollidays
{
    partial class FormCadenas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDirFiscal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCif = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonAnadir = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // textBoxDirFiscal
            // 
            this.textBoxDirFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxDirFiscal.Location = new System.Drawing.Point(356, 165);
            this.textBoxDirFiscal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDirFiscal.Name = "textBoxDirFiscal";
            this.textBoxDirFiscal.Size = new System.Drawing.Size(181, 30);
            this.textBoxDirFiscal.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(240, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dir fiscal";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxNombre.Location = new System.Drawing.Point(356, 118);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(181, 30);
            this.textBoxNombre.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(240, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // textBoxCif
            // 
            this.textBoxCif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxCif.Location = new System.Drawing.Point(356, 72);
            this.textBoxCif.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCif.Name = "textBoxCif";
            this.textBoxCif.Size = new System.Drawing.Size(181, 30);
            this.textBoxCif.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(240, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cif";
            // 
            // ButtonAnadir
            // 
            this.ButtonAnadir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAnadir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAnadir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAnadir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAnadir.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ButtonAnadir.ForeColor = System.Drawing.Color.White;
            this.ButtonAnadir.Location = new System.Drawing.Point(266, 227);
            this.ButtonAnadir.Name = "ButtonAnadir";
            this.ButtonAnadir.Size = new System.Drawing.Size(271, 73);
            this.ButtonAnadir.TabIndex = 16;
            this.ButtonAnadir.Text = "Añadir";
            this.ButtonAnadir.Click += new System.EventHandler(this.ButtonAnadir_Click);
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonEliminar.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.ButtonEliminar.ForeColor = System.Drawing.Color.White;
            this.ButtonEliminar.Location = new System.Drawing.Point(311, 317);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(180, 45);
            this.ButtonEliminar.TabIndex = 17;
            this.ButtonEliminar.Text = "Eliminar";
            this.ButtonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            // 
            // FormCadenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(791, 415);
            this.Controls.Add(this.ButtonEliminar);
            this.Controls.Add(this.ButtonAnadir);
            this.Controls.Add(this.textBoxDirFiscal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCif);
            this.Controls.Add(this.label1);
            this.Name = "FormCadenas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadenas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxDirFiscal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCif;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button ButtonAnadir;
        private Guna.UI2.WinForms.Guna2Button ButtonEliminar;
    }
}