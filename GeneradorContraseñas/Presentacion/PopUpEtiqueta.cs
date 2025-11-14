using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorContraseñas.Presentacion
{
    public partial class PopUpEtiqueta : Form
    {
        public PopUpEtiqueta()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Contraseña copiada al portapapeles.", "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
