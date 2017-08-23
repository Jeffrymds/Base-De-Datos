namespace Estudiante
{
    partial class Consultar
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
            this.dgresultado = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstudiantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipodeIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fechanaci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Familiar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fechacreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcriterio = new System.Windows.Forms.TextBox();
            this.btbuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEditar = new System.Windows.Forms.CheckBox();
            this.btmodificar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txcarrera = new System.Windows.Forms.TextBox();
            this.mtmatricula = new System.Windows.Forms.MaskedTextBox();
            this.txfamiliar = new System.Windows.Forms.TextBox();
            this.mttelefono = new System.Windows.Forms.MaskedTextBox();
            this.txdireccion = new System.Windows.Forms.TextBox();
            this.dtpfechanaci = new System.Windows.Forms.DateTimePicker();
            this.mtnoiden = new System.Windows.Forms.MaskedTextBox();
            this.cbtipoiden = new System.Windows.Forms.ComboBox();
            this.rbf = new System.Windows.Forms.RadioButton();
            this.rbm = new System.Windows.Forms.RadioButton();
            this.txapellido1 = new System.Windows.Forms.TextBox();
            this.txnombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgresultado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgresultado
            // 
            this.dgresultado.AllowUserToAddRows = false;
            this.dgresultado.AllowUserToDeleteRows = false;
            this.dgresultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgresultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.idEstudiantes,
            this.Apellidos,
            this.Genero,
            this.TipodeIdentificacion,
            this.NoIdentificacion,
            this.Fechanaci,
            this.Direccion,
            this.Telefono,
            this.Familiar,
            this.Matricula,
            this.Carrera,
            this.Fechacreacion,
            this.Usuario});
            this.dgresultado.Location = new System.Drawing.Point(0, 172);
            this.dgresultado.Name = "dgresultado";
            this.dgresultado.ReadOnly = true;
            this.dgresultado.Size = new System.Drawing.Size(336, 494);
            this.dgresultado.TabIndex = 0;
            this.dgresultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgresultado_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // idEstudiantes
            // 
            this.idEstudiantes.DataPropertyName = "idEstudiantes";
            this.idEstudiantes.HeaderText = "idEstudiantes";
            this.idEstudiantes.Name = "idEstudiantes";
            this.idEstudiantes.ReadOnly = true;
            this.idEstudiantes.Visible = false;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "Genero";
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Visible = false;
            // 
            // TipodeIdentificacion
            // 
            this.TipodeIdentificacion.DataPropertyName = "TipodeIdentificacion";
            this.TipodeIdentificacion.HeaderText = "TipodeIdentificacion";
            this.TipodeIdentificacion.Name = "TipodeIdentificacion";
            this.TipodeIdentificacion.ReadOnly = true;
            this.TipodeIdentificacion.Visible = false;
            // 
            // NoIdentificacion
            // 
            this.NoIdentificacion.DataPropertyName = "NoIdentificacion";
            this.NoIdentificacion.HeaderText = "NoIdentificacion";
            this.NoIdentificacion.Name = "NoIdentificacion";
            this.NoIdentificacion.ReadOnly = true;
            this.NoIdentificacion.Visible = false;
            // 
            // Fechanaci
            // 
            this.Fechanaci.DataPropertyName = "Fechanaci";
            this.Fechanaci.HeaderText = "Fechanaci";
            this.Fechanaci.Name = "Fechanaci";
            this.Fechanaci.ReadOnly = true;
            this.Fechanaci.Visible = false;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Visible = false;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Visible = false;
            // 
            // Familiar
            // 
            this.Familiar.DataPropertyName = "Familiar";
            this.Familiar.HeaderText = "Familiar";
            this.Familiar.Name = "Familiar";
            this.Familiar.ReadOnly = true;
            this.Familiar.Visible = false;
            // 
            // Matricula
            // 
            this.Matricula.DataPropertyName = "Matricula";
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            // 
            // Carrera
            // 
            this.Carrera.DataPropertyName = "Carrera";
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            this.Carrera.Visible = false;
            // 
            // Fechacreacion
            // 
            this.Fechacreacion.DataPropertyName = "Fechacreacion";
            this.Fechacreacion.HeaderText = "Fechacreacion";
            this.Fechacreacion.Name = "Fechacreacion";
            this.Fechacreacion.ReadOnly = true;
            this.Fechacreacion.Visible = false;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Visible = false;
            // 
            // txtcriterio
            // 
            this.txtcriterio.Location = new System.Drawing.Point(6, 52);
            this.txtcriterio.Name = "txtcriterio";
            this.txtcriterio.Size = new System.Drawing.Size(100, 20);
            this.txtcriterio.TabIndex = 1;
            this.txtcriterio.TextChanged += new System.EventHandler(this.txtcriterio_TextChanged);
            // 
            // btbuscar
            // 
            this.btbuscar.Location = new System.Drawing.Point(169, 52);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(75, 23);
            this.btbuscar.TabIndex = 2;
            this.btbuscar.Text = "Buscar";
            this.btbuscar.UseVisualStyleBackColor = true;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEditar);
            this.groupBox1.Controls.Add(this.btmodificar);
            this.groupBox1.Controls.Add(this.txtcriterio);
            this.groupBox1.Controls.Add(this.dgresultado);
            this.groupBox1.Controls.Add(this.btbuscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 674);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // cbEditar
            // 
            this.cbEditar.AutoSize = true;
            this.cbEditar.Location = new System.Drawing.Point(169, 95);
            this.cbEditar.Name = "cbEditar";
            this.cbEditar.Size = new System.Drawing.Size(53, 17);
            this.cbEditar.TabIndex = 50;
            this.cbEditar.Text = "Editar";
            this.cbEditar.UseVisualStyleBackColor = true;
            this.cbEditar.CheckedChanged += new System.EventHandler(this.cbEditar_CheckedChanged);
            // 
            // btmodificar
            // 
            this.btmodificar.Location = new System.Drawing.Point(31, 126);
            this.btmodificar.Name = "btmodificar";
            this.btmodificar.Size = new System.Drawing.Size(75, 23);
            this.btmodificar.TabIndex = 49;
            this.btmodificar.Text = "Modificar";
            this.btmodificar.UseVisualStyleBackColor = true;
            this.btmodificar.Click += new System.EventHandler(this.btmodificar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txcarrera);
            this.groupBox2.Controls.Add(this.mtmatricula);
            this.groupBox2.Controls.Add(this.txfamiliar);
            this.groupBox2.Controls.Add(this.mttelefono);
            this.groupBox2.Controls.Add(this.txdireccion);
            this.groupBox2.Controls.Add(this.dtpfechanaci);
            this.groupBox2.Controls.Add(this.mtnoiden);
            this.groupBox2.Controls.Add(this.cbtipoiden);
            this.groupBox2.Controls.Add(this.rbf);
            this.groupBox2.Controls.Add(this.rbm);
            this.groupBox2.Controls.Add(this.txapellido1);
            this.groupBox2.Controls.Add(this.txnombre);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(359, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 752);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Consultados";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txcarrera
            // 
            this.txcarrera.Location = new System.Drawing.Point(134, 650);
            this.txcarrera.Name = "txcarrera";
            this.txcarrera.ReadOnly = true;
            this.txcarrera.Size = new System.Drawing.Size(100, 20);
            this.txcarrera.TabIndex = 48;
            // 
            // mtmatricula
            // 
            this.mtmatricula.Location = new System.Drawing.Point(134, 613);
            this.mtmatricula.Mask = "0000-0000";
            this.mtmatricula.Name = "mtmatricula";
            this.mtmatricula.ReadOnly = true;
            this.mtmatricula.Size = new System.Drawing.Size(100, 20);
            this.mtmatricula.TabIndex = 47;
            // 
            // txfamiliar
            // 
            this.txfamiliar.Location = new System.Drawing.Point(176, 547);
            this.txfamiliar.Multiline = true;
            this.txfamiliar.Name = "txfamiliar";
            this.txfamiliar.ReadOnly = true;
            this.txfamiliar.Size = new System.Drawing.Size(214, 37);
            this.txfamiliar.TabIndex = 46;
            // 
            // mttelefono
            // 
            this.mttelefono.Location = new System.Drawing.Point(161, 495);
            this.mttelefono.Mask = "(999)000-0000";
            this.mttelefono.Name = "mttelefono";
            this.mttelefono.ReadOnly = true;
            this.mttelefono.Size = new System.Drawing.Size(100, 20);
            this.mttelefono.TabIndex = 45;
            // 
            // txdireccion
            // 
            this.txdireccion.Location = new System.Drawing.Point(152, 396);
            this.txdireccion.Multiline = true;
            this.txdireccion.Name = "txdireccion";
            this.txdireccion.ReadOnly = true;
            this.txdireccion.Size = new System.Drawing.Size(397, 68);
            this.txdireccion.TabIndex = 44;
            // 
            // dtpfechanaci
            // 
            this.dtpfechanaci.Enabled = false;
            this.dtpfechanaci.Location = new System.Drawing.Point(190, 339);
            this.dtpfechanaci.Name = "dtpfechanaci";
            this.dtpfechanaci.Size = new System.Drawing.Size(200, 20);
            this.dtpfechanaci.TabIndex = 43;
            // 
            // mtnoiden
            // 
            this.mtnoiden.Location = new System.Drawing.Point(190, 275);
            this.mtnoiden.Name = "mtnoiden";
            this.mtnoiden.ReadOnly = true;
            this.mtnoiden.Size = new System.Drawing.Size(100, 20);
            this.mtnoiden.TabIndex = 42;
            this.mtnoiden.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtnoiden_MaskInputRejected);
            // 
            // cbtipoiden
            // 
            this.cbtipoiden.Enabled = false;
            this.cbtipoiden.FormattingEnabled = true;
            this.cbtipoiden.Items.AddRange(new object[] {
            "Cedula",
            "Pasaporte"});
            this.cbtipoiden.Location = new System.Drawing.Point(194, 228);
            this.cbtipoiden.Name = "cbtipoiden";
            this.cbtipoiden.Size = new System.Drawing.Size(121, 21);
            this.cbtipoiden.TabIndex = 41;
            // 
            // rbf
            // 
            this.rbf.AutoSize = true;
            this.rbf.Location = new System.Drawing.Point(190, 179);
            this.rbf.Name = "rbf";
            this.rbf.Size = new System.Drawing.Size(31, 17);
            this.rbf.TabIndex = 40;
            this.rbf.TabStop = true;
            this.rbf.Text = "F";
            this.rbf.UseVisualStyleBackColor = true;
            // 
            // rbm
            // 
            this.rbm.AutoSize = true;
            this.rbm.Location = new System.Drawing.Point(134, 179);
            this.rbm.Name = "rbm";
            this.rbm.Size = new System.Drawing.Size(34, 17);
            this.rbm.TabIndex = 39;
            this.rbm.TabStop = true;
            this.rbm.Text = "M";
            this.rbm.UseVisualStyleBackColor = true;
            // 
            // txapellido1
            // 
            this.txapellido1.Location = new System.Drawing.Point(134, 133);
            this.txapellido1.Name = "txapellido1";
            this.txapellido1.ReadOnly = true;
            this.txapellido1.Size = new System.Drawing.Size(100, 20);
            this.txapellido1.TabIndex = 37;
            // 
            // txnombre
            // 
            this.txnombre.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.txnombre.Location = new System.Drawing.Point(134, 83);
            this.txnombre.Name = "txnombre";
            this.txnombre.ReadOnly = true;
            this.txnombre.Size = new System.Drawing.Size(100, 20);
            this.txnombre.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 653);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Carrera :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 616);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Matricula :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 550);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Contacto de Familiar :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Telefono/Cellular :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Direccion :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Fecha de Naciminto :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "No. de Identificacion :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tipo de Identificacion :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Genero :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Apellidos :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nombre :";
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 750);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgresultado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgresultado;
        private System.Windows.Forms.TextBox txtcriterio;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txcarrera;
        private System.Windows.Forms.MaskedTextBox mtmatricula;
        private System.Windows.Forms.TextBox txfamiliar;
        private System.Windows.Forms.MaskedTextBox mttelefono;
        private System.Windows.Forms.TextBox txdireccion;
        private System.Windows.Forms.DateTimePicker dtpfechanaci;
        private System.Windows.Forms.MaskedTextBox mtnoiden;
        private System.Windows.Forms.ComboBox cbtipoiden;
        private System.Windows.Forms.RadioButton rbf;
        private System.Windows.Forms.RadioButton rbm;
        private System.Windows.Forms.TextBox txapellido1;
        private System.Windows.Forms.TextBox txnombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btmodificar;
        private System.Windows.Forms.CheckBox cbEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstudiantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipodeIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechanaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Familiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechacreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
    }
}