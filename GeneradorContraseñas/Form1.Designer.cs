namespace GeneradorContraseñas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGenerar = new Button();
            btnCopiar = new Button();
            label1 = new Label();
            txtPassword = new TextBox();
            chkUppercase = new CheckBox();
            chkLowercase = new CheckBox();
            chkDigits = new CheckBox();
            chkSpecials = new CheckBox();
            numericLength = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericLength).BeginInit();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(67, 241);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(270, 36);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnCopiar
            // 
            btnCopiar.Location = new Point(343, 201);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(67, 23);
            btnCopiar.TabIndex = 1;
            btnCopiar.Text = "Copiar";
            btnCopiar.UseVisualStyleBackColor = true;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(54, 26);
            label1.Name = "label1";
            label1.Size = new Size(413, 46);
            label1.TabIndex = 3;
            label1.Text = "Generador de contraseñas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.Enabled = false;
            txtPassword.Location = new Point(67, 202);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(270, 23);
            txtPassword.TabIndex = 4;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // chkUppercase
            // 
            chkUppercase.AutoSize = true;
            chkUppercase.BackColor = Color.Transparent;
            chkUppercase.Location = new Point(171, 301);
            chkUppercase.Name = "chkUppercase";
            chkUppercase.Size = new Size(124, 19);
            chkUppercase.TabIndex = 5;
            chkUppercase.Text = "Incluir mayusculas";
            chkUppercase.UseVisualStyleBackColor = false;
            // 
            // chkLowercase
            // 
            chkLowercase.AutoSize = true;
            chkLowercase.BackColor = Color.Transparent;
            chkLowercase.Location = new Point(171, 326);
            chkLowercase.Name = "chkLowercase";
            chkLowercase.Size = new Size(122, 19);
            chkLowercase.TabIndex = 6;
            chkLowercase.Text = "Incluir minusculas";
            chkLowercase.UseVisualStyleBackColor = false;
            // 
            // chkDigits
            // 
            chkDigits.AutoSize = true;
            chkDigits.BackColor = Color.Transparent;
            chkDigits.Location = new Point(171, 351);
            chkDigits.Name = "chkDigits";
            chkDigits.Size = new Size(109, 19);
            chkDigits.TabIndex = 7;
            chkDigits.Text = "Incluir numeros";
            chkDigits.UseVisualStyleBackColor = false;
            // 
            // chkSpecials
            // 
            chkSpecials.AutoSize = true;
            chkSpecials.BackColor = Color.Transparent;
            chkSpecials.Location = new Point(171, 376);
            chkSpecials.Name = "chkSpecials";
            chkSpecials.Size = new Size(171, 19);
            chkSpecials.TabIndex = 8;
            chkSpecials.Text = "Incluir caracteres especiales";
            chkSpecials.UseVisualStyleBackColor = false;
            // 
            // numericLength
            // 
            numericLength.BorderStyle = BorderStyle.FixedSingle;
            numericLength.Location = new Point(293, 172);
            numericLength.Name = "numericLength";
            numericLength.Size = new Size(44, 23);
            numericLength.TabIndex = 9;
            numericLength.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(67, 174);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 10;
            label2.Text = "Caracteres requeridos";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 522);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnGenerar);
            Controls.Add(chkLowercase);
            Controls.Add(numericLength);
            Controls.Add(chkUppercase);
            Controls.Add(btnCopiar);
            Controls.Add(chkDigits);
            Controls.Add(chkSpecials);
            Controls.Add(txtPassword);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generador de contraseñas";
            ((System.ComponentModel.ISupportInitialize)numericLength).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerar;
        private Button btnCopiar;
        private Label label1;
        private TextBox txtPassword;
        private CheckBox chkUppercase;
        private CheckBox chkLowercase;
        private CheckBox chkDigits;
        private CheckBox chkSpecials;
        private NumericUpDown numericLength;
        private Label label2;
    }
}
