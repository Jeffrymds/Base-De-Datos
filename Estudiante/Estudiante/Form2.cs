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
    public partial class Nuevo : Form
    {
   
    public void limpiar()
    {
    txnombre.Clear();
    txapellido1.Clear();
    cbtipoiden.Text ="";
    mtnoiden.Text ="";
    txfamiliar.Clear();
    rbm.Checked = false;
    rbf.Checked = false;
    dtpfechanaci.Value = DateTime.Now.Date;
    txdireccion.Clear();
    txcarrera.Clear();
    mttelefono.Text ="";
    mtmatricula.Text ="";

    }

        public Nuevo()
        {
            InitializeComponent();
        }

        private void Nuevo_Load(object sender, EventArgs e)
        {

        }

        private void cbtipoiden_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbtipoiden.Text == "Cedula")
            {
                mtnoiden.Clear();
                mtnoiden.Mask = "###-#######-#";

            }
            else
            {
                mtnoiden.Clear();
                mtnoiden.Mask = "";
            }

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {

            if
               (txnombre.Text != "" && txapellido1.Text != "" && txfamiliar.Text != "" && txcarrera.Text != "" && txdireccion.Text != "" 
               && cbtipoiden.Text != "" && mtnoiden.Text != "" && mttelefono.Text != "" && mtmatricula.Text != "" && 
               rbm.Checked == true || rbf.Checked )
        
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

                string sql = "exec sp_inserta_Estudiantes'" +
                    txnombre.Text + "','" +
                    txapellido1.Text + "','" +
                    genero + "','" +
                    cbtipoiden.Text + "','" +
                    mtnoiden.Text + "','" +
                    dtpfechanaci.Value.ToString("yyyy-MM-dd") + "','" +
                    txdireccion.Text + "','" +
                    mttelefono.Text + "','" +
                    txfamiliar.Text + "','" +
                    mtmatricula.Text + "','" +
                    txcarrera.Text + "'";

                conexionesdb conex = new conexionesdb();
                conex.conectar(sql);
                MessageBox.Show("Datos Guardados Correctamente");
                  limpiar();

            }
            else
            {
                    MessageBox.Show("Algun Campo esta vacio, favor verificar");
                }

            

        }
        
    }
}
