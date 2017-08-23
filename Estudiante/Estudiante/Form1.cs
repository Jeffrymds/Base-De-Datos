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
    public partial class Registro : Form

    {

        public Registro()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Nuevo nuevovista = new Nuevo();
                nuevovista.Show();
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void buscarEditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar consultarvista = new Consultar();
            consultarvista.Show();
        }
    }
}
