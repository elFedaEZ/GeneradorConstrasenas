using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GeneradorContraseñas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericLength.Minimum = 6;
            numericLength.Maximum = 64;
            numericLength.Value = 12;

            chkUppercase.Checked = true;
            chkLowercase.Checked = true;
            chkDigits.Checked = true;
            chkSpecials.Checked = true;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            txtPass.Visible = true;
            int length = (int)numericLength.Value;
            bool upper = chkUppercase.Checked;
            bool lower = chkLowercase.Checked;
            bool digits = chkDigits.Checked;
            bool specials = chkSpecials.Checked;

            try
            {
                string password = GeneratePassword(length, upper, lower, digits, specials);
                txtPass.Text = password;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPass.Text))
            {
                Clipboard.SetText(txtPass.Text);
                MessageBox.Show("Contraseña copiada al portapapeles.", "Copiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // -------------------------------
        // Lógica de generación de contraseña
        // -------------------------------

        private const string UPPER = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string LOWER = "abcdefghijklmnopqrstuvwxyz";
        private const string DIGITS = "0123456789";
        private const string SPECIALS = "!@#$%^&*()-_=+[]{}|;:,.<>?/";

        private static readonly RandomNumberGenerator rng = RandomNumberGenerator.Create();

        private static int GetRandomInt(int maxExclusive)
        {
            if (maxExclusive <= 0) throw new ArgumentOutOfRangeException(nameof(maxExclusive));
            var bytes = new byte[4];
            int value;
            do
            {
                rng.GetBytes(bytes);
                value = BitConverter.ToInt32(bytes, 0) & int.MaxValue;
            } while (value >= (int.MaxValue / maxExclusive) * maxExclusive);
            return value % maxExclusive;
        }

        private static void Shuffle<T>(IList<T> list)
        {
            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = GetRandomInt(i + 1);
                (list[i], list[j]) = (list[j], list[i]);
            }
        }

        private static string GeneratePassword(int length, bool includeUpper, bool includeLower, bool includeDigits, bool includeSpecials)
        {
            var pools = new List<string>();
            var requiredChars = new List<char>();

            if (includeUpper) { pools.Add(UPPER); requiredChars.Add(UPPER[GetRandomInt(UPPER.Length)]); }
            if (includeLower) { pools.Add(LOWER); requiredChars.Add(LOWER[GetRandomInt(LOWER.Length)]); }
            if (includeDigits) { pools.Add(DIGITS); requiredChars.Add(DIGITS[GetRandomInt(DIGITS.Length)]); }
            if (includeSpecials) { pools.Add(SPECIALS); requiredChars.Add(SPECIALS[GetRandomInt(SPECIALS.Length)]); }

            if (pools.Count == 0)
                throw new ArgumentException("Debe seleccionar al menos un tipo de carácter.");

            if (requiredChars.Count > length)
                throw new ArgumentException("La longitud es menor que los tipos de caracteres seleccionados.");

            string allChars = string.Concat(pools);
            var password = new List<char>(requiredChars);

            for (int i = password.Count; i < length; i++)
            {
                password.Add(allChars[GetRandomInt(allChars.Length)]);
            }

            Shuffle(password);
            return new string(password.ToArray());
        }
    }
}
