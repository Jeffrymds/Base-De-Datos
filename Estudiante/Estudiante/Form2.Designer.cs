namespace Estudiante
{
    partial class Nuevo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btlimpiar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btCancelar);
            this.groupBox1.Controls.Add(this.btlimpiar);
            this.groupBox1.Controls.Add(this.btGuardar);
            this.groupBox1.Location = new System.Drawing.Point(535, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(25, 107);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btlimpiar
            // 
            this.btlimpiar.Location = new System.Drawing.Point(25, 65);
            this.btlimpiar.Name = "btlimpiar";
            this.btlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btlimpiar.TabIndex = 2;
            this.btlimpiar.Text = "Limpiar";
            this.btlimpiar.UseVisualStyleBackColor = true;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(25, 19);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 1;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 649);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Estudiante";
            // 
            // txcarrera
            // 
            this.txcarrera.Location = new System.Drawing.Point(92, 606);
            this.txcarrera.Name = "txcarrera";
            this.txcarrera.Size = new System.Drawing.Size(100, 20);
            this.txcarrera.TabIndex = 24;
            // 
            // mtmatricula
            // 
            this.mtmatricula.Location = new System.Drawing.Point(92, 569);
            this.mtmatricula.Mask = "0000-0000";
            this.mtmatricula.Name = "mtmatricula";
            this.mtmatricula.Size = new System.Drawing.Size(100, 20);
            this.mtmatricula.TabIndex = 23;
            // 
            // txfamiliar
            // 
            this.txfamiliar.Location = new System.Drawing.Point(134, 503);
            this.txfamiliar.Multiline = true;
            this.txfamiliar.Name = "txfamiliar";
            this.txfamiliar.Size = new System.Drawing.Size(214, 37);
            this.txfamiliar.TabIndex = 22;
            // 
            // mttelefono
            // 
            this.mttelefono.Location = new System.Drawing.Point(119, 451);
            this.mttelefono.Mask = "(999)000-0000";
            this.mttelefono.Name = "mttelefono";
            this.mttelefono.Size = new System.Drawing.Size(100, 20);
            this.mttelefono.TabIndex = 21;
            // 
            // txdireccion
            // 
            this.txdireccion.Location = new System.Drawing.Point(110, 352);
            this.txdireccion.Multiline = true;
            this.txdireccion.Name = "txdireccion";
            this.txdireccion.Size = new System.Drawing.Size(397, 68);
            this.txdireccion.TabIndex = 20;
            // 
            // dtpfechanaci
            // 
            this.dtpfechanaci.Location = new System.Drawing.Point(148, 295);
            this.dtpfechanaci.Name = "dtpfechanaci";
            this.dtpfechanaci.Size = new System.Drawing.Size(200, 20);
            this.dtpfechanaci.TabIndex = 19;
            // 
            // mtnoiden
            // 
            this.mtnoiden.Location = new System.Drawing.Point(148, 231);
            this.mtnoiden.Name = "mtnoiden";
            this.mtnoiden.Size = new System.Drawing.Size(100, 20);
            this.mtnoiden.TabIndex = 18;
            // 
            // cbtipoiden
            // 
            this.cbtipoiden.FormattingEnabled = true;
            this.cbtipoiden.Items.AddRange(new object[] {
            "Cedula",
            "Pasaporte"});
            this.cbtipoiden.Location = new System.Drawing.Point(152, 184);
            this.cbtipoiden.Name = "cbtipoiden";
            this.cbtipoiden.Size = new System.Drawing.Size(121, 21);
            this.cbtipoiden.TabIndex = 16;
            this.cbtipoiden.Text = "--Seleccionar--";
            this.cbtipoiden.SelectedIndexChanged += new System.EventHandler(this.cbtipoiden_SelectedIndexChanged);
            // 
            // rbf
            // 
            this.rbf.AutoSize = true;
            this.rbf.Location = new System.Drawing.Point(148, 135);
            this.rbf.Name = "rbf";
            this.rbf.Size = new System.Drawing.Size(31, 17);
            this.rbf.TabIndex = 15;
            this.rbf.TabStop = true;
            this.rbf.Text = "F";
            this.rbf.UseVisualStyleBackColor = true;
            // 
            // rbm
            // 
            this.rbm.AutoSize = true;
            this.rbm.Location = new System.Drawing.Point(92, 135);
            this.rbm.Name = "rbm";
            this.rbm.Size = new System.Drawing.Size(34, 17);
            this.rbm.TabIndex = 14;
            this.rbm.TabStop = true;
            this.rbm.Text = "M";
            this.rbm.UseVisualStyleBackColor = true;
            // 
            // txapellido1
            // 
            this.txapellido1.Location = new System.Drawing.Point(92, 89);
            this.txapellido1.Name = "txapellido1";
            this.txapellido1.Size = new System.Drawing.Size(100, 20);
            this.txapellido1.TabIndex = 12;
            // 
            // txnombre
            // 
            this.txnombre.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.txnombre.Location = new System.Drawing.Point(92, 39);
            this.txnombre.Name = "txnombre";
            this.txnombre.Size = new System.Drawing.Size(100, 20);
            this.txnombre.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 609);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Carrera :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 572);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Matricula :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 506);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Contacto de Familiar :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Telefono/Cellular :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Direccion :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de Naciminto :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "No. de Identificacion :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Identificacion :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genero :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre :";
            // 
            // Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 673);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Nuevo";
            this.Text = "Nuevo";
            this.Load += new System.EventHandler(this.Nuevo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btlimpiar;
        private System.Windows.Forms.Button btGuardar;
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
    }
}