
namespace SistemaAsistencias.UI
{
    partial class PersonalControlFm
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrimeraPagina = new System.Windows.Forms.Button();
            this.btnUltimaPagina = new System.Windows.Forms.Button();
            this.lblPagTotales = new System.Windows.Forms.Label();
            this.lblPagActual = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPagSiguiente = new System.Windows.Forms.Button();
            this.btnPagAnterior = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlAgregarPersonal = new System.Windows.Forms.Panel();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.btnAgregarCargo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtSueldoxHora = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtIdentifier = new System.Windows.Forms.TextBox();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewBasic = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameComplete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indentificator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarypHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlAgregarPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBasic)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txtBuscador);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 48);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(33, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Buscar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(720, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 34);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Crear";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel4.Location = new System.Drawing.Point(107, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 2);
            this.panel4.TabIndex = 1;
            // 
            // txtBuscador
            // 
            this.txtBuscador.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscador.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBuscador.Location = new System.Drawing.Point(107, 15);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(189, 19);
            this.txtBuscador.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnPrimeraPagina);
            this.panel2.Controls.Add(this.btnUltimaPagina);
            this.panel2.Controls.Add(this.lblPagTotales);
            this.panel2.Controls.Add(this.lblPagActual);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnPagSiguiente);
            this.panel2.Controls.Add(this.btnPagAnterior);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(828, 82);
            this.panel2.TabIndex = 1;
            // 
            // btnPrimeraPagina
            // 
            this.btnPrimeraPagina.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPrimeraPagina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrimeraPagina.FlatAppearance.BorderSize = 0;
            this.btnPrimeraPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeraPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeraPagina.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrimeraPagina.Location = new System.Drawing.Point(661, 15);
            this.btnPrimeraPagina.Name = "btnPrimeraPagina";
            this.btnPrimeraPagina.Size = new System.Drawing.Size(156, 47);
            this.btnPrimeraPagina.TabIndex = 7;
            this.btnPrimeraPagina.Text = "Primera Página";
            this.btnPrimeraPagina.UseVisualStyleBackColor = false;
            // 
            // btnUltimaPagina
            // 
            this.btnUltimaPagina.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUltimaPagina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUltimaPagina.FlatAppearance.BorderSize = 0;
            this.btnUltimaPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimaPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimaPagina.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUltimaPagina.Location = new System.Drawing.Point(493, 15);
            this.btnUltimaPagina.Name = "btnUltimaPagina";
            this.btnUltimaPagina.Size = new System.Drawing.Size(162, 47);
            this.btnUltimaPagina.TabIndex = 6;
            this.btnUltimaPagina.Text = "Última Página";
            this.btnUltimaPagina.UseVisualStyleBackColor = false;
            // 
            // lblPagTotales
            // 
            this.lblPagTotales.AutoSize = true;
            this.lblPagTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagTotales.Location = new System.Drawing.Point(468, 33);
            this.lblPagTotales.Name = "lblPagTotales";
            this.lblPagTotales.Size = new System.Drawing.Size(14, 13);
            this.lblPagTotales.TabIndex = 5;
            this.lblPagTotales.Text = "0";
            // 
            // lblPagActual
            // 
            this.lblPagActual.AutoSize = true;
            this.lblPagActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagActual.Location = new System.Drawing.Point(402, 33);
            this.lblPagActual.Name = "lblPagActual";
            this.lblPagActual.Size = new System.Drawing.Size(14, 13);
            this.lblPagActual.TabIndex = 4;
            this.lblPagActual.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(433, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "de";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(353, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Página";
            // 
            // btnPagSiguiente
            // 
            this.btnPagSiguiente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPagSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagSiguiente.FlatAppearance.BorderSize = 0;
            this.btnPagSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagSiguiente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPagSiguiente.Location = new System.Drawing.Point(171, 15);
            this.btnPagSiguiente.Name = "btnPagSiguiente";
            this.btnPagSiguiente.Size = new System.Drawing.Size(156, 47);
            this.btnPagSiguiente.TabIndex = 1;
            this.btnPagSiguiente.Text = "Pagina Siguiente";
            this.btnPagSiguiente.UseVisualStyleBackColor = false;
            // 
            // btnPagAnterior
            // 
            this.btnPagAnterior.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPagAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagAnterior.FlatAppearance.BorderSize = 0;
            this.btnPagAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagAnterior.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPagAnterior.Location = new System.Drawing.Point(3, 15);
            this.btnPagAnterior.Name = "btnPagAnterior";
            this.btnPagAnterior.Size = new System.Drawing.Size(162, 47);
            this.btnPagAnterior.TabIndex = 0;
            this.btnPagAnterior.Text = "Pagina Anterior";
            this.btnPagAnterior.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnlAgregarPersonal);
            this.panel3.Controls.Add(this.dataGridViewBasic);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(828, 350);
            this.panel3.TabIndex = 2;
            // 
            // pnlAgregarPersonal
            // 
            this.pnlAgregarPersonal.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlAgregarPersonal.Controls.Add(this.cbCargo);
            this.pnlAgregarPersonal.Controls.Add(this.btnAgregarCargo);
            this.pnlAgregarPersonal.Controls.Add(this.btnCancelar);
            this.pnlAgregarPersonal.Controls.Add(this.btnGuardar);
            this.pnlAgregarPersonal.Controls.Add(this.panel9);
            this.pnlAgregarPersonal.Controls.Add(this.txtSueldoxHora);
            this.pnlAgregarPersonal.Controls.Add(this.panel7);
            this.pnlAgregarPersonal.Controls.Add(this.txtIdentifier);
            this.pnlAgregarPersonal.Controls.Add(this.cbPais);
            this.pnlAgregarPersonal.Controls.Add(this.panel6);
            this.pnlAgregarPersonal.Controls.Add(this.txtName);
            this.pnlAgregarPersonal.Controls.Add(this.label7);
            this.pnlAgregarPersonal.Controls.Add(this.label6);
            this.pnlAgregarPersonal.Controls.Add(this.label5);
            this.pnlAgregarPersonal.Controls.Add(this.label4);
            this.pnlAgregarPersonal.Controls.Add(this.label3);
            this.pnlAgregarPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAgregarPersonal.Location = new System.Drawing.Point(37, 16);
            this.pnlAgregarPersonal.Name = "pnlAgregarPersonal";
            this.pnlAgregarPersonal.Size = new System.Drawing.Size(788, 328);
            this.pnlAgregarPersonal.TabIndex = 1;
            this.pnlAgregarPersonal.Visible = false;
            // 
            // cbCargo
            // 
            this.cbCargo.DisplayMember = "Description";
            this.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(192, 128);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(223, 28);
            this.cbCargo.TabIndex = 15;
            this.cbCargo.ValueMember = "PositionID";
            // 
            // btnAgregarCargo
            // 
            this.btnAgregarCargo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgregarCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCargo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarCargo.Location = new System.Drawing.Point(434, 127);
            this.btnAgregarCargo.Name = "btnAgregarCargo";
            this.btnAgregarCargo.Size = new System.Drawing.Size(150, 27);
            this.btnAgregarCargo.TabIndex = 14;
            this.btnAgregarCargo.Text = "Agregar Cargo";
            this.btnAgregarCargo.UseVisualStyleBackColor = false;
            this.btnAgregarCargo.Click += new System.EventHandler(this.btnAgregarCargo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(192, 237);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 44);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardar.Location = new System.Drawing.Point(53, 237);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(113, 44);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel9.Location = new System.Drawing.Point(192, 190);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(223, 2);
            this.panel9.TabIndex = 12;
            // 
            // txtSueldoxHora
            // 
            this.txtSueldoxHora.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtSueldoxHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldoxHora.Location = new System.Drawing.Point(192, 168);
            this.txtSueldoxHora.Name = "txtSueldoxHora";
            this.txtSueldoxHora.Size = new System.Drawing.Size(223, 19);
            this.txtSueldoxHora.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel7.Location = new System.Drawing.Point(192, 86);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(223, 2);
            this.panel7.TabIndex = 10;
            // 
            // txtIdentifier
            // 
            this.txtIdentifier.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtIdentifier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentifier.Location = new System.Drawing.Point(192, 64);
            this.txtIdentifier.Name = "txtIdentifier";
            this.txtIdentifier.Size = new System.Drawing.Size(223, 19);
            this.txtIdentifier.TabIndex = 9;
            // 
            // cbPais
            // 
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Items.AddRange(new object[] {
            "EL SALAVADOR",
            "GUATEMALA",
            "HONDURAS",
            "NICARAGUA",
            "COSTA RICA"});
            this.cbPais.Location = new System.Drawing.Point(192, 94);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(223, 28);
            this.cbPais.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel6.Location = new System.Drawing.Point(192, 49);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(336, 2);
            this.panel6.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtName.Location = new System.Drawing.Point(192, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(336, 19);
            this.txtName.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(34, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Sueldo x Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(34, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cargo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(34, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "País";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(34, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Identificación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(34, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombres y Apellidos";
            // 
            // dataGridViewBasic
            // 
            this.dataGridViewBasic.AllowUserToAddRows = false;
            this.dataGridViewBasic.AllowUserToDeleteRows = false;
            this.dataGridViewBasic.AllowUserToResizeRows = false;
            this.dataGridViewBasic.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBasic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBasic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBasic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameComplete,
            this.Indentificator,
            this.Country,
            this.Position,
            this.SalarypHour,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBasic.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBasic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBasic.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBasic.Name = "dataGridViewBasic";
            this.dataGridViewBasic.ReadOnly = true;
            this.dataGridViewBasic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBasic.Size = new System.Drawing.Size(828, 350);
            this.dataGridViewBasic.TabIndex = 0;
            this.dataGridViewBasic.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBasic_CellMouseEnter);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // NameComplete
            // 
            this.NameComplete.HeaderText = "Nombre";
            this.NameComplete.Name = "NameComplete";
            this.NameComplete.ReadOnly = true;
            // 
            // Indentificator
            // 
            this.Indentificator.HeaderText = "Identificador";
            this.Indentificator.Name = "Indentificator";
            this.Indentificator.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.HeaderText = "Pais";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.HeaderText = "Cargo";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // SalarypHour
            // 
            this.SalarypHour.HeaderText = "Salario x Hora";
            this.SalarypHour.Name = "SalarypHour";
            this.SalarypHour.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Estado";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(SistemaAsistencias.Entities.Employee);
            // 
            // positionBindingSource
            // 
            this.positionBindingSource.DataSource = typeof(SistemaAsistencias.Entities.Position);
            // 
            // PersonalControlFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PersonalControlFm";
            this.Size = new System.Drawing.Size(828, 480);
            this.Load += new System.EventHandler(this.PersonalControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlAgregarPersonal.ResumeLayout(false);
            this.pnlAgregarPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBasic)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewBasic;
        private System.Windows.Forms.Button btnPrimeraPagina;
        private System.Windows.Forms.Button btnUltimaPagina;
        private System.Windows.Forms.Label lblPagTotales;
        private System.Windows.Forms.Label lblPagActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPagSiguiente;
        private System.Windows.Forms.Button btnPagAnterior;
        private System.Windows.Forms.Panel pnlAgregarPersonal;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtSueldoxHora;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtIdentifier;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregarCargo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indentificator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarypHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.BindingSource positionBindingSource;
    }
}
