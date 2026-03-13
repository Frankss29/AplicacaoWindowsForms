namespace Q1_ConversorCF
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
            lbResultado = new Label();
            txtCelsius = new TextBox();
            btnConverter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 47);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Celsius (°C):";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbResultado.ForeColor = Color.DarkBlue;
            lbResultado.Location = new Point(235, 75);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(83, 32);
            lbResultado.TabIndex = 1;
            lbResultado.Text = "label2";
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(64, 65);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(100, 23);
            txtCelsius.TabIndex = 2;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(64, 96);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(100, 23);
            btnConverter.TabIndex = 3;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 168);
            Controls.Add(btnConverter);
            Controls.Add(txtCelsius);
            Controls.Add(lbResultado);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Conversor Celsius → Fahrenheit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbResultado;
        private TextBox txtCelsius;
        private Button btnConverter;
    }
}
