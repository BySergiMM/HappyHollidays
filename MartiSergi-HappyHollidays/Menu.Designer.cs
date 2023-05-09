namespace MartiSergi_HappyHollidays
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.hotelesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cadenasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCadenas = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dir_fis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHoteles = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreCadena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxHoteles = new System.Windows.Forms.PictureBox();
            this.pictureBoxCadenaHoteles = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hotelesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadenasBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelCadenas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panelHoteles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHoteles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadenaHoteles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panelCadenas);
            this.panel1.Controls.Add(this.panelHoteles);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxHoteles);
            this.panel1.Controls.Add(this.pictureBoxCadenaHoteles);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(47, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 566);
            this.panel1.TabIndex = 2;
            // 
            // panelCadenas
            // 
            this.panelCadenas.Controls.Add(this.dataGridView2);
            this.panelCadenas.Location = new System.Drawing.Point(4, 130);
            this.panelCadenas.Margin = new System.Windows.Forms.Padding(4);
            this.panelCadenas.Name = "panelCadenas";
            this.panelCadenas.Size = new System.Drawing.Size(1063, 447);
            this.panelCadenas.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dir_fis});
            this.dataGridView2.DataSource = this.cadenasBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(1063, 447);
            this.dataGridView2.TabIndex = 0;
            // 
            // dir_fis
            // 
            this.dir_fis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dir_fis.DataPropertyName = "dir_fis";
            this.dir_fis.HeaderText = "dir_fis";
            this.dir_fis.MinimumWidth = 6;
            this.dir_fis.Name = "dir_fis";
            this.dir_fis.ReadOnly = true;
            // 
            // panelHoteles
            // 
            this.panelHoteles.Controls.Add(this.dataGridView1);
            this.panelHoteles.Location = new System.Drawing.Point(4, 127);
            this.panelHoteles.Margin = new System.Windows.Forms.Padding(4);
            this.panelHoteles.Name = "panelHoteles";
            this.panelHoteles.Size = new System.Drawing.Size(1067, 450);
            this.panelHoteles.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreCadena});
            this.dataGridView1.DataSource = this.hotelesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1059, 443);
            this.dataGridView1.TabIndex = 0;
            // 
            // nombreCadena
            // 
            this.nombreCadena.HeaderText = "cadena";
            this.nombreCadena.MinimumWidth = 6;
            this.nombreCadena.Name = "nombreCadena";
            this.nombreCadena.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hoteles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cadena de hoteles";
            // 
            // pictureBoxHoteles
            // 
            this.pictureBoxHoteles.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHoteles.Image")));
            this.pictureBoxHoteles.Location = new System.Drawing.Point(241, 15);
            this.pictureBoxHoteles.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxHoteles.Name = "pictureBoxHoteles";
            this.pictureBoxHoteles.Size = new System.Drawing.Size(100, 84);
            this.pictureBoxHoteles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHoteles.TabIndex = 4;
            this.pictureBoxHoteles.TabStop = false;
            // 
            // pictureBoxCadenaHoteles
            // 
            this.pictureBoxCadenaHoteles.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCadenaHoteles.Image")));
            this.pictureBoxCadenaHoteles.Location = new System.Drawing.Point(61, 15);
            this.pictureBoxCadenaHoteles.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCadenaHoteles.Name = "pictureBoxCadenaHoteles";
            this.pictureBoxCadenaHoteles.Size = new System.Drawing.Size(89, 84);
            this.pictureBoxCadenaHoteles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCadenaHoteles.TabIndex = 3;
            this.pictureBoxCadenaHoteles.TabStop = false;
            this.pictureBoxCadenaHoteles.Click += new System.EventHandler(this.pictureBoxCadenaHoteles_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(927, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 592);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.hotelesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadenasBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCadenas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panelHoteles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHoteles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadenaHoteles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource hotelesBindingSource;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.BindingSource cadenasBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCadenas;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dir_fis;
        private System.Windows.Forms.Panel panelHoteles;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCadena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxHoteles;
        private System.Windows.Forms.PictureBox pictureBoxCadenaHoteles;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

