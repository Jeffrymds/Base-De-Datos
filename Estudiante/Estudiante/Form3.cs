using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiante
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            string sql = "Exec sp_consulta_Estudiantes'" + txtcriterio.Text + "'";

            conexionesdb consulta = new conexionesdb();
            consulta.Consulta(sql);
            dgresultado.DataSource = consulta.Consulta(sql);
        }

        private void dgresultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txnombre.Text = dgresultado.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txapellido1.Text = dgresultado.Rows[e.RowIndex].Cells["Apellidos"].Value.ToString();
            string genero = dgresultado.Rows[e.RowIndex].Cells["Genero"].Value.ToString();
            if (genero == "M")
            {
                rbm.Checked = true;
            }

            if (genero == "F")
            {
                rbf.Checked = true;
            }

            cbtipoiden.Text = dgresultado.Rows[e.RowIndex].Cells["TipodeIdentificacion"].Value.ToString();
             mtnoiden.Text = dgresultado.Rows[e.RowIndex].Cells["NoIdentificacion"].Value.ToString();
            dtpfechanaci.Text = dgresultado.Rows[e.RowIndex].Cells["Fechanaci"].Value.ToString();
            txdireccion.Text = dgresultado.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
            mttelefono.Text = dgresultado.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
            txfamiliar.Text = dgresultado.Rows[e.RowIndex].Cells["Familiar"].Value.ToString();
            mtmatricula.Text = dgresultado.Rows[e.RowIndex].Cells["Matricula"].Value.ToString();
            txcarrera.Text = dgresultado.Rows[e.RowIndex].Cells["Carrera"].Value.ToString();
       
        }

        private void txtcriterio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            if
              (txnombre.Text != "" && txapellido1.Text != "" && txfamiliar.Text != "" && txcarrera.Text != "" && txdireccion.Text != ""
              && cbtipoiden.Text != "" && mtnoiden.Text != "" && mttelefono.Text != "" && mtmatricula.Text != "" &&
              rbm.Checked == true || rbf.Checked)

            {

                string genero = "";
            if (rbm.Checked == true)
            {
                genero = "M";
            }
            else
            {
                genero = "F";
            }

                string sql = "update estudiantes set " +
"Nombre='" + txnombre.Text + "'," +
"Apellidos='" + txapellido1.Text + "'," +
 "Genero='" + genero + "'," +
"TipodeIdentificacion='" + cbtipoiden.Text + "'," +
 "NoIdentificacion ='" + mtnoiden.Text + "'," +
"Fechanaci='" + dtpfechanaci.Value.ToString("yyyy-MM-dd") + "'," +
"Direccion='" + txdireccion.Text + "'," +
 "Telefono='" + mttelefono.Text + "'," +
 "familiar='" + txfamiliar.Text + "'," +
   "Carrera='" + txcarrera.Text + "" + "' where Matricula = '" + mtmatricula.Text + "'";


                conexionesdb conex = new conexionesdb();
            conex.conectar(sql);
            MessageBox.Show("Datos Guardados Correctamente");

            }
            else
            {
                MessageBox.Show("Algun Campo esta vacio, favor verificar");
            }


        }

        private void cbEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEditar.Checked == true)

               {
                txnombre.ReadOnly = false;
                txapellido1.ReadOnly = false;
                mtmatricula.ReadOnly = false;
                cbtipoiden.Enabled = true;
                mtnoiden.ReadOnly = false;
                dtpfechanaci.Enabled = true;
                txdireccion.ReadOnly = false;
                mttelefono.ReadOnly = false;
                txfamiliar.ReadOnly = false;
                txcarrera.ReadOnly = false;
            }
          if  (cbEditar.Checked == false)
                    {

                txnombre.ReadOnly = true;
                txapellido1.ReadOnly = true;
                mtmatricula.ReadOnly = true;
                cbtipoiden.Enabled = false;
                mtnoiden.ReadOnly = true;
                dtpfechanaci.Enabled = false;
                txdireccion.ReadOnly = true;
                mttelefono.ReadOnly = true;
                txfamiliar.ReadOnly = true;
                txcarrera.ReadOnly = true;

            }
         
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void mtnoiden_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Consultar_Load(object sender, EventArgs e)
        {

        }
    }
}