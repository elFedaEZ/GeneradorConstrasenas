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
            chkUppercase = new CheckBox();
            chkLowercase = new CheckBox();
            chkDigits = new CheckBox();
            chkSpecials = new CheckBox();
            numericLength = new NumericUpDown();
            label2 = new Label();
            txtPass = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericLength).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerar.Location = new Point(117, 177);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(270, 30);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnCopiar
            // 
            btnCopiar.Cursor = Cursors.Hand;
            btnCopiar.FlatAppearance.BorderSize = 0;
            btnCopiar.FlatStyle = FlatStyle.Flat;
            btnCopiar.Image = Properties.Resources.Copiar1;
            btnCopiar.Location = new Point(393, 141);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(30, 30);
            btnCopiar.TabIndex = 1;
            btnCopiar.UseVisualStyleBackColor = true;
            btnCopiar.Visible = false;
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
            // chkUppercase
            // 
            chkUppercase.AutoSize = true;
            chkUppercase.BackColor = Color.Transparent;
            chkUppercase.Font = new Font("Tahoma", 9F);
            chkUppercase.Location = new Point(190, 222);
            chkUppercase.Name = "chkUppercase";
            chkUppercase.Size = new Size(122, 18);
            chkUppercase.TabIndex = 5;
            chkUppercase.Text = "Incluir mayusculas";
            chkUppercase.UseVisualStyleBackColor = false;
            // 
            // chkLowercase
            // 
            chkLowercase.AutoSize = true;
            chkLowercase.BackColor = Color.Transparent;
            chkLowercase.Font = new Font("Tahoma", 9F);
            chkLowercase.Location = new Point(190, 247);
            chkLowercase.Name = "chkLowercase";
            chkLowercase.Size = new Size(119, 18);
            chkLowercase.TabIndex = 6;
            chkLowercase.Text = "Incluir minusculas";
            chkLowercase.UseVisualStyleBackColor = false;
            // 
            // chkDigits
            // 
            chkDigits.AutoSize = true;
            chkDigits.BackColor = Color.Transparent;
            chkDigits.Font = new Font("Tahoma", 9F);
            chkDigits.Location = new Point(190, 272);
            chkDigits.Name = "chkDigits";
            chkDigits.Size = new Size(109, 18);
            chkDigits.TabIndex = 7;
            chkDigits.Text = "Incluir numeros";
            chkDigits.UseVisualStyleBackColor = false;
            // 
            // chkSpecials
            // 
            chkSpecials.AutoSize = true;
            chkSpecials.BackColor = Color.Transparent;
            chkSpecials.Font = new Font("Tahoma", 9F);
            chkSpecials.Location = new Point(190, 297);
            chkSpecials.Name = "chkSpecials";
            chkSpecials.Size = new Size(176, 18);
            chkSpecials.TabIndex = 8;
            chkSpecials.Text = "Incluir caracteres especiales";
            chkSpecials.UseVisualStyleBackColor = false;
            // 
            // numericLength
            // 
            numericLength.BorderStyle = BorderStyle.FixedSingle;
            numericLength.Location = new Point(343, 96);
            numericLength.Name = "numericLength";
            numericLength.Size = new Size(44, 23);
            numericLength.TabIndex = 9;
            numericLength.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(117, 98);
            label2.Name = "label2";
            label2.Size = new Size(125, 14);
            label2.TabIndex = 10;
            label2.Text = "Caracteres requeridos";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtPass.AutoSize = true;
            txtPass.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(90, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(93, 18);
            txtPass.TabIndex = 11;
            txtPass.Text = "Contraseña";
            txtPass.TextAlign = ContentAlignment.MiddleCenter;
            txtPass.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(txtPass);
            panel1.Location = new Point(117, 141);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 30);
            panel1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 522);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnGenerar);
            Controls.Add(chkLowercase);
            Controls.Add(numericLength);
            Controls.Add(chkUppercase);
            Controls.Add(btnCopiar);
            Controls.Add(chkDigits);
            Controls.Add(chkSpecials);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generador de contraseñas";
            ((System.ComponentModel.ISupportInitialize)numericLength).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerar;
        private Button btnCopiar;
        private Label label1;
        private CheckBox chkUppercase;
        private CheckBox chkLowercase;
        private CheckBox chkDigits;
        private CheckBox chkSpecials;
        private NumericUpDown numericLength;
        private Label label2;
        private Label txtPass;
        private Panel panel1;
    }
}
