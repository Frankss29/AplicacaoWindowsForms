namespace Q3_PassagemPorDistancia
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
            label1 = new Label();
            txtDistancia = new TextBox();
            btnCalcular = new Button();
            lbResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 105);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Distância (km):";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(164, 97);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(100, 23);
            txtDistancia.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(137, 144);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 28);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbResultado.ForeColor = SystemColors.Highlight;
            lbResultado.Location = new Point(129, 34);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(83, 32);
            lbResultado.TabIndex = 3;
            lbResultado.Text = "label2";
            lbResultado.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 201);
            Controls.Add(lbResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtDistancia);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Preço da Passagem por Distância";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDistancia;
        private Button btnCalcular;
        private Label lbResultado;
    }
}
