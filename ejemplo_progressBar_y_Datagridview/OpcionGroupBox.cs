using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo_progressBar_y_Datagridview
{
    public partial class OpcionGroupBox : Form
    {
        public OpcionGroupBox()
        {
            InitializeComponent();
        }

        private void btngenero_Click(object sender, EventArgs e)
        {
            gbgenero.Location = new Point(252, 118);
            gbgenero.Visible = true;
            gbnacionalidad.Visible = false;
        }

        private void btnnacionalidad_Click(object sender, EventArgs e)
        {
            gbgenero.Visible = false;
            gbnacionalidad.Location = new Point(252, 118);
            gbnacionalidad.Visible = true;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }
    }
}
