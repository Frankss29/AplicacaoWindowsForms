namespace Q4_TabuadaTradicional
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
            lstTabuada = new ListBox();
            txtNumero = new TextBox();
            lbNome = new Label();
            btnGerar = new Button();
            SuspendLayout();
            // 
            // lstTabuada
            // 
            lstTabuada.FormattingEnabled = true;
            lstTabuada.ItemHeight = 15;
            lstTabuada.Location = new Point(52, 81);
            lstTabuada.Name = "lstTabuada";
            lstTabuada.Size = new Size(300, 199);
            lstTabuada.TabIndex = 0;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(114, 42);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(118, 23);
            txtNumero.TabIndex = 1;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.BorderStyle = BorderStyle.FixedSingle;
            lbNome.Location = new Point(52, 48);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(56, 17);
            lbNome.TabIndex = 2;
            lbNome.Text = "Número:";
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(238, 42);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(114, 23);
            btnGerar.TabIndex = 3;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 353);
            Controls.Add(btnGerar);
            Controls.Add(lbNome);
            Controls.Add(txtNumero);
            Controls.Add(lstTabuada);
            Name = "Form1";
            Text = "Tabuada Tradicional";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstTabuada;
        private TextBox txtNumero;
        private Label lbNome;
        private Button btnGerar;
    }
}
