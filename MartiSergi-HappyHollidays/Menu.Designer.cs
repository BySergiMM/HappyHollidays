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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxHoteles = new System.Windows.Forms.PictureBox();
            this.pictureBoxCadenaHoteles = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hotelesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cadenasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHoteles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadenaHoteles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadenasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hoteles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cadena de hoteles";
            // 
            // pictureBoxHoteles
            // 
            this.pictureBoxHoteles.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHoteles.Image")));
            this.pictureBoxHoteles.Location = new System.Drawing.Point(224, 13);
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
            this.pictureBoxCadenaHoteles.Location = new System.Drawing.Point(32, 13);
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
            this.pictureBox1.Location = new System.Drawing.Point(1020, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 638);
            this.Controls.Add(this.pictureBoxCadenaHoteles);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxHoteles);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHoteles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadenaHoteles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadenasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxHoteles;
        private System.Windows.Forms.PictureBox pictureBoxCadenaHoteles;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource hotelesBindingSource;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.BindingSource cadenasBindingSource;
    }
}

