namespace ProyectoPuntoVenta
{
    partial class frmGestion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabGestion = new System.Windows.Forms.TabControl();
            this.tabProducto = new System.Windows.Forms.TabPage();
            this.txtindexproducto = new System.Windows.Forms.TextBox();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.dgdataproducto = new System.Windows.Forms.DataGridView();
            this.txtbuscarproducto = new System.Windows.Forms.TextBox();
            this.cbobuscarproducto = new System.Windows.Forms.ComboBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.cbocategoria = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btneliminarproducto = new System.Windows.Forms.Button();
            this.btnlimpiarproducto = new System.Windows.Forms.Button();
            this.btnguardarproducto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdescripcionproducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombreproducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcodigoproducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCategoria = new System.Windows.Forms.TabPage();
            this.txtindexcategoria = new System.Windows.Forms.TextBox();
            this.txtidcategoria = new System.Windows.Forms.TextBox();
            this.dgdatacategoria = new System.Windows.Forms.DataGridView();
            this.btneliminarcategoria = new System.Windows.Forms.Button();
            this.btnlimpiarcategoria = new System.Windows.Forms.Button();
            this.btnguardarcategoria = new System.Windows.Forms.Button();
            this.txtdescripcioncategoria = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabTienda = new System.Windows.Forms.TabPage();
            this.btnguardartienda = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txttelefonotienda = new System.Windows.Forms.TextBox();
            this.txtcorreotienda = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtrazonsocialtienda = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtdocumentotienda = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.tabGestion.SuspendLayout();
            this.tabProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdataproducto)).BeginInit();
            this.tabCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdatacategoria)).BeginInit();
            this.tabTienda.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGestion
            // 
            this.tabGestion.Controls.Add(this.tabProducto);
            this.tabGestion.Controls.Add(this.tabCategoria);
            this.tabGestion.Controls.Add(this.tabTienda);
            this.tabGestion.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabGestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabGestion.Location = new System.Drawing.Point(16, 13);
            this.tabGestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabGestion.Name = "tabGestion";
            this.tabGestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabGestion.SelectedIndex = 0;
            this.tabGestion.Size = new System.Drawing.Size(1654, 673);
            this.tabGestion.TabIndex = 0;
            // 
            // tabProducto
            // 
            this.tabProducto.BackColor = System.Drawing.Color.SkyBlue;
            this.tabProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabProducto.Controls.Add(this.txtindexproducto);
            this.tabProducto.Controls.Add(this.txtidproducto);
            this.tabProducto.Controls.Add(this.dgdataproducto);
            this.tabProducto.Controls.Add(this.txtbuscarproducto);
            this.tabProducto.Controls.Add(this.cbobuscarproducto);
            this.tabProducto.Controls.Add(this.btnclear);
            this.tabProducto.Controls.Add(this.btnbuscar);
            this.tabProducto.Controls.Add(this.cbocategoria);
            this.tabProducto.Controls.Add(this.label9);
            this.tabProducto.Controls.Add(this.label10);
            this.tabProducto.Controls.Add(this.btneliminarproducto);
            this.tabProducto.Controls.Add(this.btnlimpiarproducto);
            this.tabProducto.Controls.Add(this.btnguardarproducto);
            this.tabProducto.Controls.Add(this.label6);
            this.tabProducto.Controls.Add(this.txtdescripcionproducto);
            this.tabProducto.Controls.Add(this.label5);
            this.tabProducto.Controls.Add(this.txtnombreproducto);
            this.tabProducto.Controls.Add(this.label4);
            this.tabProducto.Controls.Add(this.txtcodigoproducto);
            this.tabProducto.Controls.Add(this.label7);
            this.tabProducto.Controls.Add(this.label8);
            this.tabProducto.Controls.Add(this.label3);
            this.tabProducto.Controls.Add(this.label2);
            this.tabProducto.Controls.Add(this.label1);
            this.tabProducto.Location = new System.Drawing.Point(4, 29);
            this.tabProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabProducto.Name = "tabProducto";
            this.tabProducto.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabProducto.Size = new System.Drawing.Size(1646, 640);
            this.tabProducto.TabIndex = 0;
            this.tabProducto.Text = "Productos";
            // 
            // txtindexproducto
            // 
            this.txtindexproducto.Location = new System.Drawing.Point(307, 85);
            this.txtindexproducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtindexproducto.Name = "txtindexproducto";
            this.txtindexproducto.Size = new System.Drawing.Size(28, 26);
            this.txtindexproducto.TabIndex = 64;
            this.txtindexproducto.Text = "0";
            this.txtindexproducto.Visible = false;
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(341, 85);
            this.txtidproducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(28, 26);
            this.txtidproducto.TabIndex = 65;
            this.txtidproducto.Text = "0";
            this.txtidproducto.Visible = false;
            // 
            // dgdataproducto
            // 
            this.dgdataproducto.AllowUserToAddRows = false;
            this.dgdataproducto.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdataproducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgdataproducto.ColumnHeadersHeight = 30;
            this.dgdataproducto.EnableHeadersVisualStyles = false;
            this.dgdataproducto.GridColor = System.Drawing.Color.DimGray;
            this.dgdataproducto.Location = new System.Drawing.Point(405, 95);
            this.dgdataproducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgdataproducto.MultiSelect = false;
            this.dgdataproducto.Name = "dgdataproducto";
            this.dgdataproducto.ReadOnly = true;
            this.dgdataproducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdataproducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgdataproducto.RowHeadersWidth = 51;
            this.dgdataproducto.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgdataproducto.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgdataproducto.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgdataproducto.RowTemplate.Height = 30;
            this.dgdataproducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdataproducto.Size = new System.Drawing.Size(1162, 484);
            this.dgdataproducto.TabIndex = 63;
            this.dgdataproducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdataproducto_CellContentClick);
            this.dgdataproducto.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdataproducto_CellMouseEnter);
            this.dgdataproducto.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgdataproducto_CellPainting);
            // 
            // txtbuscarproducto
            // 
            this.txtbuscarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscarproducto.Location = new System.Drawing.Point(1157, 36);
            this.txtbuscarproducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbuscarproducto.Name = "txtbuscarproducto";
            this.txtbuscarproducto.Size = new System.Drawing.Size(259, 24);
            this.txtbuscarproducto.TabIndex = 62;
            // 
            // cbobuscarproducto
            // 
            this.cbobuscarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbobuscarproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobuscarproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbobuscarproducto.FormattingEnabled = true;
            this.cbobuscarproducto.Location = new System.Drawing.Point(850, 36);
            this.cbobuscarproducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbobuscarproducto.Name = "cbobuscarproducto";
            this.cbobuscarproducto.Size = new System.Drawing.Size(257, 26);
            this.cbobuscarproducto.TabIndex = 61;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Image = global::ProyectoPuntoVenta.Properties.Resources.clear16;
            this.btnclear.Location = new System.Drawing.Point(1508, 34);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(49, 26);
            this.btnclear.TabIndex = 59;
            this.btnclear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Image = global::ProyectoPuntoVenta.Properties.Resources.search16;
            this.btnbuscar.Location = new System.Drawing.Point(1451, 34);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(49, 26);
            this.btnbuscar.TabIndex = 60;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // cbocategoria
            // 
            this.cbocategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbocategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocategoria.FormattingEnabled = true;
            this.cbocategoria.Location = new System.Drawing.Point(47, 327);
            this.cbocategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbocategoria.Name = "cbocategoria";
            this.cbocategoria.Size = new System.Drawing.Size(323, 26);
            this.cbocategoria.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(739, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 18);
            this.label9.TabIndex = 38;
            this.label9.Text = "Buscar por:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(433, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 25);
            this.label10.TabIndex = 37;
            this.label10.Text = "Lista de Productos";
            // 
            // btneliminarproducto
            // 
            this.btneliminarproducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btneliminarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminarproducto.Image = global::ProyectoPuntoVenta.Properties.Resources.delete32;
            this.btneliminarproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminarproducto.Location = new System.Drawing.Point(45, 506);
            this.btneliminarproducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btneliminarproducto.Name = "btneliminarproducto";
            this.btneliminarproducto.Size = new System.Drawing.Size(325, 47);
            this.btneliminarproducto.TabIndex = 35;
            this.btneliminarproducto.Text = "Eliminar";
            this.btneliminarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminarproducto.UseVisualStyleBackColor = false;
            this.btneliminarproducto.Click += new System.EventHandler(this.btneliminarproducto_Click);
            // 
            // btnlimpiarproducto
            // 
            this.btnlimpiarproducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnlimpiarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarproducto.Image = global::ProyectoPuntoVenta.Properties.Resources.clear32;
            this.btnlimpiarproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiarproducto.Location = new System.Drawing.Point(45, 452);
            this.btnlimpiarproducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlimpiarproducto.Name = "btnlimpiarproducto";
            this.btnlimpiarproducto.Size = new System.Drawing.Size(325, 47);
            this.btnlimpiarproducto.TabIndex = 34;
            this.btnlimpiarproducto.Text = "Limpiar";
            this.btnlimpiarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiarproducto.UseVisualStyleBackColor = false;
            this.btnlimpiarproducto.Click += new System.EventHandler(this.btnlimpiarproducto_Click);
            // 
            // btnguardarproducto
            // 
            this.btnguardarproducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnguardarproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardarproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarproducto.Image = global::ProyectoPuntoVenta.Properties.Resources.save32;
            this.btnguardarproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardarproducto.Location = new System.Drawing.Point(45, 398);
            this.btnguardarproducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnguardarproducto.Name = "btnguardarproducto";
            this.btnguardarproducto.Size = new System.Drawing.Size(325, 47);
            this.btnguardarproducto.TabIndex = 36;
            this.btnguardarproducto.Text = "Guardar";
            this.btnguardarproducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardarproducto.UseVisualStyleBackColor = false;
            this.btnguardarproducto.Click += new System.EventHandler(this.btnguardarproducto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 304);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Categoría:";
            // 
            // txtdescripcionproducto
            // 
            this.txtdescripcionproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcionproducto.Location = new System.Drawing.Point(45, 254);
            this.txtdescripcionproducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdescripcionproducto.Name = "txtdescripcionproducto";
            this.txtdescripcionproducto.Size = new System.Drawing.Size(324, 24);
            this.txtdescripcionproducto.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Descripción:";
            // 
            // txtnombreproducto
            // 
            this.txtnombreproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombreproducto.Location = new System.Drawing.Point(45, 183);
            this.txtnombreproducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnombreproducto.Name = "txtnombreproducto";
            this.txtnombreproducto.Size = new System.Drawing.Size(324, 24);
            this.txtnombreproducto.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nombre:";
            // 
            // txtcodigoproducto
            // 
            this.txtcodigoproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigoproducto.Location = new System.Drawing.Point(45, 117);
            this.txtcodigoproducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcodigoproducto.Name = "txtcodigoproducto";
            this.txtcodigoproducto.Size = new System.Drawing.Size(324, 24);
            this.txtcodigoproducto.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Código:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Detalle de Producto";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(396, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1190, 72);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(396, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1190, 512);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 630);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabCategoria
            // 
            this.tabCategoria.BackColor = System.Drawing.Color.SkyBlue;
            this.tabCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCategoria.Controls.Add(this.txtindexcategoria);
            this.tabCategoria.Controls.Add(this.txtidcategoria);
            this.tabCategoria.Controls.Add(this.dgdatacategoria);
            this.tabCategoria.Controls.Add(this.btneliminarcategoria);
            this.tabCategoria.Controls.Add(this.btnlimpiarcategoria);
            this.tabCategoria.Controls.Add(this.btnguardarcategoria);
            this.tabCategoria.Controls.Add(this.txtdescripcioncategoria);
            this.tabCategoria.Controls.Add(this.label11);
            this.tabCategoria.Controls.Add(this.label12);
            this.tabCategoria.Controls.Add(this.label13);
            this.tabCategoria.Controls.Add(this.label14);
            this.tabCategoria.Controls.Add(this.label16);
            this.tabCategoria.Controls.Add(this.label17);
            this.tabCategoria.Location = new System.Drawing.Point(4, 29);
            this.tabCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCategoria.Name = "tabCategoria";
            this.tabCategoria.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCategoria.Size = new System.Drawing.Size(1652, 637);
            this.tabCategoria.TabIndex = 1;
            this.tabCategoria.Text = "Categorias";
            // 
            // txtindexcategoria
            // 
            this.txtindexcategoria.Location = new System.Drawing.Point(295, 70);
            this.txtindexcategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtindexcategoria.Name = "txtindexcategoria";
            this.txtindexcategoria.Size = new System.Drawing.Size(28, 26);
            this.txtindexcategoria.TabIndex = 59;
            this.txtindexcategoria.Text = "0";
            this.txtindexcategoria.Visible = false;
            // 
            // txtidcategoria
            // 
            this.txtidcategoria.Location = new System.Drawing.Point(329, 70);
            this.txtidcategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidcategoria.Name = "txtidcategoria";
            this.txtidcategoria.Size = new System.Drawing.Size(28, 26);
            this.txtidcategoria.TabIndex = 60;
            this.txtidcategoria.Text = "0";
            this.txtidcategoria.Visible = false;
            // 
            // dgdatacategoria
            // 
            this.dgdatacategoria.AllowUserToAddRows = false;
            this.dgdatacategoria.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdatacategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgdatacategoria.ColumnHeadersHeight = 30;
            this.dgdatacategoria.EnableHeadersVisualStyles = false;
            this.dgdatacategoria.GridColor = System.Drawing.Color.DimGray;
            this.dgdatacategoria.Location = new System.Drawing.Point(433, 134);
            this.dgdatacategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgdatacategoria.MultiSelect = false;
            this.dgdatacategoria.Name = "dgdatacategoria";
            this.dgdatacategoria.ReadOnly = true;
            this.dgdatacategoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdatacategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgdatacategoria.RowHeadersWidth = 51;
            this.dgdatacategoria.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgdatacategoria.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgdatacategoria.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgdatacategoria.RowTemplate.Height = 30;
            this.dgdatacategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdatacategoria.Size = new System.Drawing.Size(1185, 476);
            this.dgdatacategoria.TabIndex = 58;
            this.dgdatacategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdatacategoria_CellContentClick);
            this.dgdatacategoria.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdatacategoria_CellMouseEnter);
            this.dgdatacategoria.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgdatacategoria_CellPainting);
            // 
            // btneliminarcategoria
            // 
            this.btneliminarcategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btneliminarcategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminarcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminarcategoria.Image = global::ProyectoPuntoVenta.Properties.Resources.delete32;
            this.btneliminarcategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminarcategoria.Location = new System.Drawing.Point(35, 267);
            this.btneliminarcategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btneliminarcategoria.Name = "btneliminarcategoria";
            this.btneliminarcategoria.Size = new System.Drawing.Size(325, 47);
            this.btneliminarcategoria.TabIndex = 56;
            this.btneliminarcategoria.Text = "Eliminar";
            this.btneliminarcategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminarcategoria.UseVisualStyleBackColor = false;
            this.btneliminarcategoria.Click += new System.EventHandler(this.btneliminarcategoria_Click);
            // 
            // btnlimpiarcategoria
            // 
            this.btnlimpiarcategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnlimpiarcategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarcategoria.Image = global::ProyectoPuntoVenta.Properties.Resources.clear32;
            this.btnlimpiarcategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiarcategoria.Location = new System.Drawing.Point(35, 213);
            this.btnlimpiarcategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlimpiarcategoria.Name = "btnlimpiarcategoria";
            this.btnlimpiarcategoria.Size = new System.Drawing.Size(325, 47);
            this.btnlimpiarcategoria.TabIndex = 55;
            this.btnlimpiarcategoria.Text = "Limpiar";
            this.btnlimpiarcategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiarcategoria.UseVisualStyleBackColor = false;
            this.btnlimpiarcategoria.Click += new System.EventHandler(this.btnlimpiarcategoria_Click);
            // 
            // btnguardarcategoria
            // 
            this.btnguardarcategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnguardarcategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardarcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarcategoria.Image = global::ProyectoPuntoVenta.Properties.Resources.save32;
            this.btnguardarcategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardarcategoria.Location = new System.Drawing.Point(35, 159);
            this.btnguardarcategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnguardarcategoria.Name = "btnguardarcategoria";
            this.btnguardarcategoria.Size = new System.Drawing.Size(325, 47);
            this.btnguardarcategoria.TabIndex = 57;
            this.btnguardarcategoria.Text = "Guardar";
            this.btnguardarcategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardarcategoria.UseVisualStyleBackColor = false;
            this.btnguardarcategoria.Click += new System.EventHandler(this.btnguardarcategoria_Click);
            // 
            // txtdescripcioncategoria
            // 
            this.txtdescripcioncategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcioncategoria.Location = new System.Drawing.Point(35, 102);
            this.txtdescripcioncategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdescripcioncategoria.Name = "txtdescripcioncategoria";
            this.txtdescripcioncategoria.Size = new System.Drawing.Size(324, 24);
            this.txtdescripcioncategoria.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 80);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 18);
            this.label11.TabIndex = 46;
            this.label11.Text = "Descripción:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(79, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(209, 25);
            this.label12.TabIndex = 45;
            this.label12.Text = "Detalle de Categoria";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(416, 116);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1221, 512);
            this.label13.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Dock = System.Windows.Forms.DockStyle.Left;
            this.label14.Location = new System.Drawing.Point(4, 4);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(382, 627);
            this.label14.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(433, 39);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(199, 25);
            this.label16.TabIndex = 51;
            this.label16.Text = "Lista de Categorias";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(416, 18);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(1221, 72);
            this.label17.TabIndex = 43;
            // 
            // tabTienda
            // 
            this.tabTienda.BackColor = System.Drawing.Color.SkyBlue;
            this.tabTienda.Controls.Add(this.btnguardartienda);
            this.tabTienda.Controls.Add(this.label22);
            this.tabTienda.Controls.Add(this.label21);
            this.tabTienda.Controls.Add(this.txttelefonotienda);
            this.tabTienda.Controls.Add(this.txtcorreotienda);
            this.tabTienda.Controls.Add(this.label18);
            this.tabTienda.Controls.Add(this.txtrazonsocialtienda);
            this.tabTienda.Controls.Add(this.label19);
            this.tabTienda.Controls.Add(this.txtdocumentotienda);
            this.tabTienda.Controls.Add(this.label20);
            this.tabTienda.Controls.Add(this.label15);
            this.tabTienda.Controls.Add(this.button10);
            this.tabTienda.Location = new System.Drawing.Point(4, 29);
            this.tabTienda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabTienda.Name = "tabTienda";
            this.tabTienda.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabTienda.Size = new System.Drawing.Size(1652, 637);
            this.tabTienda.TabIndex = 2;
            this.tabTienda.Text = "Tienda";
            // 
            // btnguardartienda
            // 
            this.btnguardartienda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnguardartienda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardartienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardartienda.Image = global::ProyectoPuntoVenta.Properties.Resources.save32;
            this.btnguardartienda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardartienda.Location = new System.Drawing.Point(257, 443);
            this.btnguardartienda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnguardartienda.Name = "btnguardartienda";
            this.btnguardartienda.Size = new System.Drawing.Size(329, 47);
            this.btnguardartienda.TabIndex = 58;
            this.btnguardartienda.Text = "Guardar";
            this.btnguardartienda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardartienda.UseVisualStyleBackColor = false;
            this.btnguardartienda.Click += new System.EventHandler(this.btnguardartienda_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(252, 98);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(210, 25);
            this.label22.TabIndex = 34;
            this.label22.Text = "Detalle de mi Tienda";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(253, 361);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 18);
            this.label21.TabIndex = 33;
            this.label21.Text = "Telefono:";
            // 
            // txttelefonotienda
            // 
            this.txttelefonotienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefonotienda.Location = new System.Drawing.Point(257, 383);
            this.txttelefonotienda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttelefonotienda.Name = "txttelefonotienda";
            this.txttelefonotienda.Size = new System.Drawing.Size(328, 24);
            this.txttelefonotienda.TabIndex = 31;
            // 
            // txtcorreotienda
            // 
            this.txtcorreotienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreotienda.Location = new System.Drawing.Point(257, 310);
            this.txtcorreotienda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcorreotienda.Name = "txtcorreotienda";
            this.txtcorreotienda.Size = new System.Drawing.Size(328, 24);
            this.txtcorreotienda.TabIndex = 30;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(253, 289);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 18);
            this.label18.TabIndex = 27;
            this.label18.Text = "Correo:";
            // 
            // txtrazonsocialtienda
            // 
            this.txtrazonsocialtienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrazonsocialtienda.Location = new System.Drawing.Point(257, 240);
            this.txtrazonsocialtienda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtrazonsocialtienda.Name = "txtrazonsocialtienda";
            this.txtrazonsocialtienda.Size = new System.Drawing.Size(328, 24);
            this.txtrazonsocialtienda.TabIndex = 29;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(253, 219);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 18);
            this.label19.TabIndex = 26;
            this.label19.Text = "Razón Social:";
            // 
            // txtdocumentotienda
            // 
            this.txtdocumentotienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumentotienda.Location = new System.Drawing.Point(257, 174);
            this.txtdocumentotienda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdocumentotienda.Name = "txtdocumentotienda";
            this.txtdocumentotienda.Size = new System.Drawing.Size(328, 24);
            this.txtdocumentotienda.TabIndex = 28;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(253, 153);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(148, 18);
            this.label20.TabIndex = 25;
            this.label20.Text = "Numero Documento:";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(28, 23);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(770, 589);
            this.label15.TabIndex = 0;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Image = global::ProyectoPuntoVenta.Properties.Resources.save32;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.Location = new System.Drawing.Point(257, 455);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(329, 47);
            this.button10.TabIndex = 32;
            this.button10.Text = "Guardar";
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // frmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1702, 699);
            this.ControlBox = false;
            this.Controls.Add(this.tabGestion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGestion";
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.frmGestion_Load);
            this.tabGestion.ResumeLayout(false);
            this.tabProducto.ResumeLayout(false);
            this.tabProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdataproducto)).EndInit();
            this.tabCategoria.ResumeLayout(false);
            this.tabCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdatacategoria)).EndInit();
            this.tabTienda.ResumeLayout(false);
            this.tabTienda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGestion;
        private System.Windows.Forms.TabPage tabProducto;
        private System.Windows.Forms.TabPage tabCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btneliminarproducto;
        private System.Windows.Forms.Button btnlimpiarproducto;
        private System.Windows.Forms.Button btnguardarproducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdescripcionproducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnombreproducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcodigoproducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbocategoria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdescripcioncategoria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btneliminarcategoria;
        private System.Windows.Forms.Button btnlimpiarcategoria;
        private System.Windows.Forms.Button btnguardarcategoria;
        private System.Windows.Forms.TabPage tabTienda;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox txttelefonotienda;
        private System.Windows.Forms.TextBox txtcorreotienda;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtrazonsocialtienda;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtdocumentotienda;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnguardartienda;
        private System.Windows.Forms.DataGridView dgdatacategoria;
        private System.Windows.Forms.TextBox txtindexcategoria;
        private System.Windows.Forms.TextBox txtidcategoria;
        private System.Windows.Forms.TextBox txtbuscarproducto;
        private System.Windows.Forms.ComboBox cbobuscarproducto;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView dgdataproducto;
        private System.Windows.Forms.TextBox txtindexproducto;
        private System.Windows.Forms.TextBox txtidproducto;
    }
}