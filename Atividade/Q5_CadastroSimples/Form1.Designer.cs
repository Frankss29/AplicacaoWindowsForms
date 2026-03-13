namespace Q5_CadastroSimples
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
            lbNome = new Label();
            lbIdade = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            btnAdicionar = new Button();
            lstPessoas = new ListBox();
            SuspendLayout();
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(44, 35);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(43, 15);
            lbNome.TabIndex = 0;
            lbNome.Text = "Nome:";
            // 
            // lbIdade
            // 
            lbIdade.AutoSize = true;
            lbIdade.Location = new Point(45, 67);
            lbIdade.Name = "lbIdade";
            lbIdade.Size = new Size(39, 15);
            lbIdade.TabIndex = 1;
            lbIdade.Text = "Idade:";
            lbIdade.Click += lbSenha_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(93, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(122, 23);
            txtNome.TabIndex = 2;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(93, 62);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(122, 23);
            txtIdade.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(239, 48);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lstPessoas
            // 
            lstPessoas.FormattingEnabled = true;
            lstPessoas.ItemHeight = 15;
            lstPessoas.Location = new Point(45, 109);
            lstPessoas.Name = "lstPessoas";
            lstPessoas.Size = new Size(269, 274);
            lstPessoas.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 411);
            Controls.Add(lstPessoas);
            Controls.Add(btnAdicionar);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(lbIdade);
            Controls.Add(lbNome);
            Name = "Form1";
            Text = "Sistema de Cadastro Simples";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNome;
        private Label lbIdade;
        private TextBox txtNome;
        private TextBox txtIdade;
        private Button btnAdicionar;
        private ListBox lstPessoas;
    }
}
