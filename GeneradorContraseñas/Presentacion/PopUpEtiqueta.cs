using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneradorContraseñas.Presentacion;

namespace GeneradorContraseñas.Presentacion
{
    public partial class PopUpEtiqueta : Form
    {
        private string _passEnviada;
        public PopUpEtiqueta(string recibirPass)
        {
            InitializeComponent();

            this._passEnviada = recibirPass;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(_passEnviada);
            this.Close();
            MessageBox.Show("Contraseña copiada al portapapeles.", "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
