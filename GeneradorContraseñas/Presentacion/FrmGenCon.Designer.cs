namespace GeneradorContraseñas
{
    partial class FrmGenCon
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
            label2 = new Label();
            txtPass = new Label();
            panel1 = new Panel();
            trackBar1 = new TrackBar();
            txtBar = new Label();
            txtValorMin = new Label();
            txtValorMax = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerar.Location = new Point(88, 211);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(330, 30);
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
            btnCopiar.Location = new Point(424, 175);
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
            chkUppercase.Location = new Point(190, 256);
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
            chkLowercase.Location = new Point(190, 281);
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
            chkDigits.Location = new Point(190, 306);
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
            chkSpecials.Location = new Point(190, 331);
            chkSpecials.Name = "chkSpecials";
            chkSpecials.Size = new Size(176, 18);
            chkSpecials.TabIndex = 8;
            chkSpecials.Text = "Incluir caracteres especiales";
            chkSpecials.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(117, 96);
            label2.Name = "label2";
            label2.Size = new Size(125, 14);
            label2.TabIndex = 10;
            label2.Text = "Caracteres requeridos";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPass.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(-1, 4);
            txtPass.Name = "txtPass";
            txtPass.RightToLeft = RightToLeft.Yes;
            txtPass.Size = new Size(330, 18);
            txtPass.TabIndex = 11;
            txtPass.Text = "Contraseña";
            txtPass.TextAlign = ContentAlignment.MiddleCenter;
            txtPass.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtPass);
            panel1.Location = new Point(88, 175);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 30);
            panel1.TabIndex = 12;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(119, 113);
            trackBar1.Maximum = 32;
            trackBar1.Minimum = 6;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(270, 45);
            trackBar1.TabIndex = 13;
            trackBar1.Value = 6;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // txtBar
            // 
            txtBar.AutoSize = true;
            txtBar.Location = new Point(376, 95);
            txtBar.Name = "txtBar";
            txtBar.Size = new Size(0, 15);
            txtBar.TabIndex = 14;
            txtBar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtValorMin
            // 
            txtValorMin.AutoSize = true;
            txtValorMin.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorMin.Location = new Point(126, 145);
            txtValorMin.Name = "txtValorMin";
            txtValorMin.Size = new Size(11, 13);
            txtValorMin.TabIndex = 15;
            txtValorMin.Text = "-";
            // 
            // txtValorMax
            // 
            txtValorMax.AutoSize = true;
            txtValorMax.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorMax.Location = new Point(370, 145);
            txtValorMax.Name = "txtValorMax";
            txtValorMax.Size = new Size(11, 13);
            txtValorMax.TabIndex = 16;
            txtValorMax.Text = "-";
            // 
            // FrmGenCon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 521);
            Controls.Add(txtValorMax);
            Controls.Add(txtValorMin);
            Controls.Add(txtBar);
            Controls.Add(trackBar1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnGenerar);
            Controls.Add(chkLowercase);
            Controls.Add(chkUppercase);
            Controls.Add(btnCopiar);
            Controls.Add(chkDigits);
            Controls.Add(chkSpecials);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGenCon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generador de contraseñas";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
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
        private Label label2;
        private Label txtPass;
        private Panel panel1;
        private TrackBar trackBar1;
        private Label txtBar;
        private Label txtValorMin;
        private Label txtValorMax;
    }
}
