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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewCadena = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DataGridViewHoteles = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PanelHotels = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelCadena = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonCadena = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ButtonHoteles = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ButtonAnadir = new Guna.UI2.WinForms.Guna2Button();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cifDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirfisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadenasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCadena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewHoteles)).BeginInit();
            this.PanelHotels.SuspendLayout();
            this.PanelCadena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadenasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewCadena
            // 
            this.DataGridViewCadena.AllowUserToAddRows = false;
            this.DataGridViewCadena.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridViewCadena.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewCadena.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewCadena.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewCadena.ColumnHeadersHeight = 18;
            this.DataGridViewCadena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewCadena.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn1,
            this.cifDataGridViewTextBoxColumn1,
            this.dirfisDataGridViewTextBoxColumn});
            this.DataGridViewCadena.DataSource = this.cadenasBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewCadena.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewCadena.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewCadena.Location = new System.Drawing.Point(3, 13);
            this.DataGridViewCadena.Name = "DataGridViewCadena";
            this.DataGridViewCadena.ReadOnly = true;
            this.DataGridViewCadena.RowHeadersVisible = false;
            this.DataGridViewCadena.RowHeadersWidth = 51;
            this.DataGridViewCadena.RowTemplate.Height = 24;
            this.DataGridViewCadena.Size = new System.Drawing.Size(1099, 418);
            this.DataGridViewCadena.TabIndex = 7;
            this.DataGridViewCadena.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewCadena.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewCadena.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewCadena.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewCadena.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewCadena.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewCadena.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewCadena.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewCadena.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewCadena.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewCadena.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewCadena.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewCadena.ThemeStyle.HeaderStyle.Height = 18;
            this.DataGridViewCadena.ThemeStyle.ReadOnly = true;
            this.DataGridViewCadena.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewCadena.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewCadena.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewCadena.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewCadena.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridViewCadena.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewCadena.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewCadena.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCadena_CellDoubleClick);
            // 
            // DataGridViewHoteles
            // 
            this.DataGridViewHoteles.AllowUserToAddRows = false;
            this.DataGridViewHoteles.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridViewHoteles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewHoteles.AutoGenerateColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewHoteles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewHoteles.ColumnHeadersHeight = 18;
            this.DataGridViewHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewHoteles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.cifDataGridViewTextBoxColumn,
            this.id_ciudad});
            this.DataGridViewHoteles.DataSource = this.hotelesBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewHoteles.DefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewHoteles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewHoteles.Location = new System.Drawing.Point(3, 13);
            this.DataGridViewHoteles.Name = "DataGridViewHoteles";
            this.DataGridViewHoteles.ReadOnly = true;
            this.DataGridViewHoteles.RowHeadersVisible = false;
            this.DataGridViewHoteles.RowHeadersWidth = 51;
            this.DataGridViewHoteles.RowTemplate.Height = 24;
            this.DataGridViewHoteles.Size = new System.Drawing.Size(1096, 418);
            this.DataGridViewHoteles.TabIndex = 8;
            this.DataGridViewHoteles.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewHoteles.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewHoteles.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewHoteles.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewHoteles.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewHoteles.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewHoteles.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewHoteles.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewHoteles.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewHoteles.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewHoteles.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewHoteles.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewHoteles.ThemeStyle.HeaderStyle.Height = 18;
            this.DataGridViewHoteles.ThemeStyle.ReadOnly = true;
            this.DataGridViewHoteles.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewHoteles.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewHoteles.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewHoteles.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewHoteles.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridViewHoteles.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewHoteles.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewHoteles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewHoteles_CellDoubleClick);
            this.DataGridViewHoteles.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridViewHoteles_CellFormatting);
            // 
            // PanelHotels
            // 
            this.PanelHotels.Controls.Add(this.DataGridViewHoteles);
            this.PanelHotels.Location = new System.Drawing.Point(26, 117);
            this.PanelHotels.Name = "PanelHotels";
            this.PanelHotels.Size = new System.Drawing.Size(1099, 431);
            this.PanelHotels.TabIndex = 9;
            // 
            // PanelCadena
            // 
            this.PanelCadena.Controls.Add(this.DataGridViewCadena);
            this.PanelCadena.Location = new System.Drawing.Point(26, 117);
            this.PanelCadena.Name = "PanelCadena";
            this.PanelCadena.Size = new System.Drawing.Size(1099, 431);
            this.PanelCadena.TabIndex = 10;
            // 
            // ButtonCadena
            // 
            this.ButtonCadena.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCadena.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonCadena.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonCadena.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonCadena.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonCadena.ForeColor = System.Drawing.Color.White;
            this.ButtonCadena.Location = new System.Drawing.Point(80, 13);
            this.ButtonCadena.Name = "ButtonCadena";
            this.ButtonCadena.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonCadena.Size = new System.Drawing.Size(150, 74);
            this.ButtonCadena.TabIndex = 12;
            this.ButtonCadena.Text = "Cadenas";
            this.ButtonCadena.Click += new System.EventHandler(this.ButtonCadena_Click);
            // 
            // ButtonHoteles
            // 
            this.ButtonHoteles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonHoteles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonHoteles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonHoteles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonHoteles.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonHoteles.ForeColor = System.Drawing.Color.White;
            this.ButtonHoteles.Location = new System.Drawing.Point(250, 13);
            this.ButtonHoteles.Name = "ButtonHoteles";
            this.ButtonHoteles.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonHoteles.Size = new System.Drawing.Size(150, 74);
            this.ButtonHoteles.TabIndex = 13;
            this.ButtonHoteles.Text = "Hoteles";
            this.ButtonHoteles.Click += new System.EventHandler(this.ButtonHoteles_Click);
            // 
            // ButtonAnadir
            // 
            this.ButtonAnadir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAnadir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAnadir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAnadir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAnadir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonAnadir.ForeColor = System.Drawing.Color.White;
            this.ButtonAnadir.Location = new System.Drawing.Point(955, 35);
            this.ButtonAnadir.Name = "ButtonAnadir";
            this.ButtonAnadir.Size = new System.Drawing.Size(170, 52);
            this.ButtonAnadir.TabIndex = 14;
            this.ButtonAnadir.Text = "Añadir";
            this.ButtonAnadir.Click += new System.EventHandler(this.ButtonAnadir_Click);
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            this.nombreDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cifDataGridViewTextBoxColumn1
            // 
            this.cifDataGridViewTextBoxColumn1.DataPropertyName = "cif";
            this.cifDataGridViewTextBoxColumn1.HeaderText = "CIF";
            this.cifDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cifDataGridViewTextBoxColumn1.Name = "cifDataGridViewTextBoxColumn1";
            this.cifDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dirfisDataGridViewTextBoxColumn
            // 
            this.dirfisDataGridViewTextBoxColumn.DataPropertyName = "dir_fis";
            this.dirfisDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.dirfisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dirfisDataGridViewTextBoxColumn.Name = "dirfisDataGridViewTextBoxColumn";
            this.dirfisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cadenasBindingSource
            // 
            this.cadenasBindingSource.DataSource = typeof(MartiSergi_HappyHollidays.Models.cadenas);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            dataGridViewCellStyle6.NullValue = null;
            this.nombreDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "categoria";
            this.categoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cifDataGridViewTextBoxColumn
            // 
            this.cifDataGridViewTextBoxColumn.DataPropertyName = "cif";
            this.cifDataGridViewTextBoxColumn.HeaderText = "Cadena";
            this.cifDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cifDataGridViewTextBoxColumn.Name = "cifDataGridViewTextBoxColumn";
            this.cifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // id_ciudad
            // 
            this.id_ciudad.DataPropertyName = "id_ciudad";
            this.id_ciudad.HeaderText = "Ciudad";
            this.id_ciudad.MinimumWidth = 6;
            this.id_ciudad.Name = "id_ciudad";
            this.id_ciudad.ReadOnly = true;
            // 
            // hotelesBindingSource
            // 
            this.hotelesBindingSource.DataSource = typeof(MartiSergi_HappyHollidays.Models.hoteles);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1160, 577);
            this.Controls.Add(this.ButtonAnadir);
            this.Controls.Add(this.ButtonHoteles);
            this.Controls.Add(this.ButtonCadena);
            this.Controls.Add(this.PanelCadena);
            this.Controls.Add(this.PanelHotels);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCadena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewHoteles)).EndInit();
            this.PanelHotels.ResumeLayout(false);
            this.PanelCadena.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cadenasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource hotelesBindingSource;
        private System.Windows.Forms.BindingSource cadenasBindingSource;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewCadena;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewHoteles;
        private Guna.UI2.WinForms.Guna2Panel PanelHotels;
        private Guna.UI2.WinForms.Guna2Panel PanelCadena;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cifDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirfisDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2CircleButton ButtonCadena;
        private Guna.UI2.WinForms.Guna2CircleButton ButtonHoteles;
        private Guna.UI2.WinForms.Guna2Button ButtonAnadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ciudad;
    }
}

