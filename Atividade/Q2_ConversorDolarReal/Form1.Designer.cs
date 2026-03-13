namespace Q2_ConversorDolarReal
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
            lbDolar = new Label();
            lbQTDDolares = new Label();
            lbResultado = new Label();
            txtCotacao = new TextBox();
            txtDolares = new TextBox();
            btnConverter = new Button();
            SuspendLayout();
            // 
            // lbDolar
            // 
            lbDolar.AutoSize = true;
            lbDolar.Location = new Point(51, 109);
            lbDolar.Name = "lbDolar";
            lbDolar.Size = new Size(125, 15);
            lbDolar.TabIndex = 0;
            lbDolar.Text = "Cotação do dólar (R$):";
            // 
            // lbQTDDolares
            // 
            lbQTDDolares.AutoSize = true;
            lbQTDDolares.Location = new Point(51, 153);
            lbQTDDolares.Name = "lbQTDDolares";
            lbQTDDolares.Size = new Size(164, 15);
            lbQTDDolares.TabIndex = 1;
            lbQTDDolares.Text = "Quantidade em dólares (US$):";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbResultado.ForeColor = Color.ForestGreen;
            lbResultado.Location = new Point(154, 39);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(83, 32);
            lbResultado.TabIndex = 2;
            lbResultado.Text = "label3";
            lbResultado.Click += label3_Click;
            // 
            // txtCotacao
            // 
            txtCotacao.Location = new Point(182, 101);
            txtCotacao.Name = "txtCotacao";
            txtCotacao.Size = new Size(133, 23);
            txtCotacao.TabIndex = 3;
            // 
            // txtDolares
            // 
            txtDolares.Location = new Point(215, 146);
            txtDolares.Name = "txtDolares";
            txtDolares.Size = new Size(100, 23);
            txtDolares.TabIndex = 4;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(145, 185);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(102, 23);
            btnConverter.TabIndex = 5;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 251);
            Controls.Add(btnConverter);
            Controls.Add(txtDolares);
            Controls.Add(txtCotacao);
            Controls.Add(lbResultado);
            Controls.Add(lbQTDDolares);
            Controls.Add(lbDolar);
            Name = "Form1";
            Text = "Conversor Dólar → Real";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDolar;
        private Label lbQTDDolares;
        private Label lbResultado;
        private TextBox txtCotacao;
        private TextBox txtDolares;
        private Button btnConverter;
    }
}
