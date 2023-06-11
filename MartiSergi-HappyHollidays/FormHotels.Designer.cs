namespace MartiSergi_HappyHollidays
{
    partial class FormHotels
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonGuardar = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonAñadir = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonBorrar = new Guna.UI2.WinForms.Guna2Button();
            this.DataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBoxNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxCategoria = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxDireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxGradoDificultad = new Guna.UI2.WinForms.Guna2TextBox();
            this.ComboBoxActividades = new Guna.UI2.WinForms.Guna2ComboBox();
            this.actividadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ComboBoxCadena = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cadenasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ComboBoxCiudad = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ciudadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hotelesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.TextBoxUbicacion = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadenasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(933, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 25);
            this.label9.TabIndex = 41;
            this.label9.Text = "Grado de dificultad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(631, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 40;
            this.label8.Text = "Actividades";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(370, 200);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 38;
            this.label7.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(370, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(26, 346);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(26, 280);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ubicacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(26, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(26, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Cadena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(26, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nombre";
            // 
            // ButtonGuardar
            // 
            this.ButtonGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonGuardar.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ButtonGuardar.ForeColor = System.Drawing.Color.White;
            this.ButtonGuardar.Location = new System.Drawing.Point(109, 408);
            this.ButtonGuardar.Name = "ButtonGuardar";
            this.ButtonGuardar.Size = new System.Drawing.Size(233, 73);
            this.ButtonGuardar.TabIndex = 51;
            this.ButtonGuardar.Text = "Guardar";
            this.ButtonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // ButtonAñadir
            // 
            this.ButtonAñadir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAñadir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAñadir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAñadir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAñadir.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ButtonAñadir.ForeColor = System.Drawing.Color.White;
            this.ButtonAñadir.Location = new System.Drawing.Point(699, 153);
            this.ButtonAñadir.Name = "ButtonAñadir";
            this.ButtonAñadir.Size = new System.Drawing.Size(177, 41);
            this.ButtonAñadir.TabIndex = 53;
            this.ButtonAñadir.Text = "Añadir";
            this.ButtonAñadir.Click += new System.EventHandler(this.ButtonAñadir_Click);
            // 
            // ButtonBorrar
            // 
            this.ButtonBorrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonBorrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonBorrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonBorrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonBorrar.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ButtonBorrar.ForeColor = System.Drawing.Color.White;
            this.ButtonBorrar.Location = new System.Drawing.Point(947, 153);
            this.ButtonBorrar.Name = "ButtonBorrar";
            this.ButtonBorrar.Size = new System.Drawing.Size(160, 41);
            this.ButtonBorrar.TabIndex = 54;
            this.ButtonBorrar.Text = "Borrar";
            this.ButtonBorrar.Click += new System.EventHandler(this.ButtonBorrar_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView.ColumnHeadersHeight = 18;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.Grado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.Location = new System.Drawing.Point(636, 211);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(494, 181);
            this.DataGridView.TabIndex = 55;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView.ThemeStyle.HeaderStyle.Height = 18;
            this.DataGridView.ThemeStyle.ReadOnly = true;
            this.DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // id
            // 
            this.id.HeaderText = "";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Grado
            // 
            this.Grado.HeaderText = "Grado";
            this.Grado.MinimumWidth = 6;
            this.Grado.Name = "Grado";
            this.Grado.ReadOnly = true;
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxNombre.DefaultText = "";
            this.TextBoxNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxNombre.Location = new System.Drawing.Point(125, 74);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.PasswordChar = '\0';
            this.TextBoxNombre.PlaceholderText = "";
            this.TextBoxNombre.SelectedText = "";
            this.TextBoxNombre.Size = new System.Drawing.Size(200, 36);
            this.TextBoxNombre.TabIndex = 56;
            // 
            // TextBoxTelefono
            // 
            this.TextBoxTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxTelefono.DefaultText = "";
            this.TextBoxTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxTelefono.Location = new System.Drawing.Point(125, 335);
            this.TextBoxTelefono.Name = "TextBoxTelefono";
            this.TextBoxTelefono.PasswordChar = '\0';
            this.TextBoxTelefono.PlaceholderText = "";
            this.TextBoxTelefono.SelectedText = "";
            this.TextBoxTelefono.Size = new System.Drawing.Size(200, 36);
            this.TextBoxTelefono.TabIndex = 58;
            // 
            // TextBoxCategoria
            // 
            this.TextBoxCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxCategoria.DefaultText = "";
            this.TextBoxCategoria.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxCategoria.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxCategoria.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxCategoria.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxCategoria.Location = new System.Drawing.Point(390, 133);
            this.TextBoxCategoria.Name = "TextBoxCategoria";
            this.TextBoxCategoria.PasswordChar = '\0';
            this.TextBoxCategoria.PlaceholderText = "";
            this.TextBoxCategoria.SelectedText = "";
            this.TextBoxCategoria.Size = new System.Drawing.Size(200, 36);
            this.TextBoxCategoria.TabIndex = 59;
            // 
            // TextBoxDireccion
            // 
            this.TextBoxDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxDireccion.DefaultText = "";
            this.TextBoxDireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxDireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxDireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxDireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxDireccion.Location = new System.Drawing.Point(390, 241);
            this.TextBoxDireccion.Name = "TextBoxDireccion";
            this.TextBoxDireccion.PasswordChar = '\0';
            this.TextBoxDireccion.PlaceholderText = "";
            this.TextBoxDireccion.SelectedText = "";
            this.TextBoxDireccion.Size = new System.Drawing.Size(200, 36);
            this.TextBoxDireccion.TabIndex = 60;
            // 
            // TextBoxGradoDificultad
            // 
            this.TextBoxGradoDificultad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxGradoDificultad.DefaultText = "";
            this.TextBoxGradoDificultad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxGradoDificultad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxGradoDificultad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxGradoDificultad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxGradoDificultad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxGradoDificultad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxGradoDificultad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxGradoDificultad.Location = new System.Drawing.Point(938, 85);
            this.TextBoxGradoDificultad.Name = "TextBoxGradoDificultad";
            this.TextBoxGradoDificultad.PasswordChar = '\0';
            this.TextBoxGradoDificultad.PlaceholderText = "";
            this.TextBoxGradoDificultad.SelectedText = "";
            this.TextBoxGradoDificultad.Size = new System.Drawing.Size(192, 36);
            this.TextBoxGradoDificultad.TabIndex = 61;
            // 
            // ComboBoxActividades
            // 
            this.ComboBoxActividades.AutoRoundedCorners = true;
            this.ComboBoxActividades.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxActividades.BorderRadius = 17;
            this.ComboBoxActividades.DataSource = this.actividadesBindingSource;
            this.ComboBoxActividades.DisplayMember = "descripcion";
            this.ComboBoxActividades.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxActividades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxActividades.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxActividades.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxActividades.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxActividades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxActividades.ItemHeight = 30;
            this.ComboBoxActividades.Location = new System.Drawing.Point(636, 85);
            this.ComboBoxActividades.Name = "ComboBoxActividades";
            this.ComboBoxActividades.Size = new System.Drawing.Size(212, 36);
            this.ComboBoxActividades.TabIndex = 62;
            this.ComboBoxActividades.ValueMember = "id_act";
            this.ComboBoxActividades.SelectedIndexChanged += new System.EventHandler(this.ComboBoxActividades_SelectedIndexChanged_1);
            // 
            // actividadesBindingSource
            // 
            this.actividadesBindingSource.DataSource = typeof(MartiSergi_HappyHollidays.Models.actividades);
            // 
            // ComboBoxCadena
            // 
            this.ComboBoxCadena.AutoRoundedCorners = true;
            this.ComboBoxCadena.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxCadena.BorderRadius = 17;
            this.ComboBoxCadena.DataSource = this.cadenasBindingSource;
            this.ComboBoxCadena.DisplayMember = "nombre";
            this.ComboBoxCadena.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxCadena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCadena.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxCadena.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxCadena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxCadena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxCadena.ItemHeight = 30;
            this.ComboBoxCadena.Location = new System.Drawing.Point(125, 133);
            this.ComboBoxCadena.Name = "ComboBoxCadena";
            this.ComboBoxCadena.Size = new System.Drawing.Size(200, 36);
            this.ComboBoxCadena.TabIndex = 63;
            this.ComboBoxCadena.ValueMember = "cif";
            // 
            // cadenasBindingSource
            // 
            this.cadenasBindingSource.DataSource = typeof(MartiSergi_HappyHollidays.Models.cadenas);
            // 
            // ComboBoxCiudad
            // 
            this.ComboBoxCiudad.AutoRoundedCorners = true;
            this.ComboBoxCiudad.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxCiudad.BorderRadius = 17;
            this.ComboBoxCiudad.DataSource = this.ciudadesBindingSource;
            this.ComboBoxCiudad.DisplayMember = "nombre";
            this.ComboBoxCiudad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCiudad.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxCiudad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxCiudad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxCiudad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxCiudad.ItemHeight = 30;
            this.ComboBoxCiudad.Location = new System.Drawing.Point(125, 200);
            this.ComboBoxCiudad.Name = "ComboBoxCiudad";
            this.ComboBoxCiudad.Size = new System.Drawing.Size(200, 36);
            this.ComboBoxCiudad.TabIndex = 64;
            this.ComboBoxCiudad.ValueMember = "id_ciudad";
            // 
            // ciudadesBindingSource
            // 
            this.ciudadesBindingSource.DataSource = typeof(MartiSergi_HappyHollidays.Models.ciudades);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonEliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonEliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonEliminar.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ButtonEliminar.ForeColor = System.Drawing.Color.White;
            this.ButtonEliminar.Location = new System.Drawing.Point(379, 408);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(211, 58);
            this.ButtonEliminar.TabIndex = 66;
            this.ButtonEliminar.Text = "Eliminar";
            this.ButtonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click_1);
            // 
            // TextBoxUbicacion
            // 
            this.TextBoxUbicacion.AutoRoundedCorners = true;
            this.TextBoxUbicacion.BackColor = System.Drawing.Color.Transparent;
            this.TextBoxUbicacion.BorderRadius = 17;
            this.TextBoxUbicacion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TextBoxUbicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextBoxUbicacion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUbicacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxUbicacion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TextBoxUbicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TextBoxUbicacion.ItemHeight = 30;
            this.TextBoxUbicacion.Items.AddRange(new object[] {
            "PLAYA",
            "MONTAÑA"});
            this.TextBoxUbicacion.Location = new System.Drawing.Point(125, 275);
            this.TextBoxUbicacion.Name = "TextBoxUbicacion";
            this.TextBoxUbicacion.Size = new System.Drawing.Size(200, 36);
            this.TextBoxUbicacion.TabIndex = 67;
            this.TextBoxUbicacion.ValueMember = "id_ciudad";
            // 
            // FormHotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1196, 543);
            this.Controls.Add(this.TextBoxUbicacion);
            this.Controls.Add(this.ButtonEliminar);
            this.Controls.Add(this.ComboBoxCiudad);
            this.Controls.Add(this.ComboBoxCadena);
            this.Controls.Add(this.ComboBoxActividades);
            this.Controls.Add(this.TextBoxGradoDificultad);
            this.Controls.Add(this.TextBoxDireccion);
            this.Controls.Add(this.TextBoxCategoria);
            this.Controls.Add(this.TextBoxTelefono);
            this.Controls.Add(this.TextBoxNombre);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.ButtonBorrar);
            this.Controls.Add(this.ButtonAñadir);
            this.Controls.Add(this.ButtonGuardar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHotels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHotels";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actividadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadenasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button ButtonGuardar;
        private Guna.UI2.WinForms.Guna2Button ButtonAñadir;
        private Guna.UI2.WinForms.Guna2Button ButtonBorrar;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxNombre;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxTelefono;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxCategoria;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxDireccion;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxGradoDificultad;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxActividades;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxCadena;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxCiudad;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource actividadesBindingSource;
        private System.Windows.Forms.BindingSource hotelesBindingSource;
        private System.Windows.Forms.BindingSource cadenasBindingSource;
        private System.Windows.Forms.BindingSource ciudadesBindingSource;
        private Guna.UI2.WinForms.Guna2Button ButtonEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grado;
        private Guna.UI2.WinForms.Guna2ComboBox TextBoxUbicacion;
    }
}