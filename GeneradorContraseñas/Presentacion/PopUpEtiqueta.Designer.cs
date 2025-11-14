namespace GeneradorContraseñas.Presentacion
{
    partial class PopUpEtiqueta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            btnAceptar = new Button();
            label1 = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 23);
            textBox1.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(202, 65);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(154, 15);
            label1.TabIndex = 2;
            label1.Text = "Agregar Etiqueta (Opcional)";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(283, 65);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // PopUpEtiqueta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 100);
            ControlBox = false;
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "PopUpEtiqueta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar etiqueta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnAceptar;
        private Label label1;
        private Button btnCancelar;
    }
}