namespace ProjetoFinaceiro.Designer.Usuario
{
    partial class frmAlterarSenha
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlterarSenha = new System.Windows.Forms.Button();
            this.mskSenha = new System.Windows.Forms.MaskedTextBox();
            this.mskCpfAlterar = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailAlterar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(129, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(165, 23);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(151, 80);
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(145, 23);
            this.mskCPF.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.btnAlterarSenha);
            this.panel1.Controls.Add(this.mskSenha);
            this.panel1.Controls.Add(this.mskCpfAlterar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtEmailAlterar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 209);
            this.panel1.TabIndex = 3;
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.Enabled = false;
            this.btnAlterarSenha.Location = new System.Drawing.Point(82, 171);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(105, 31);
            this.btnAlterarSenha.TabIndex = 5;
            this.btnAlterarSenha.Text = "Alterar Senha";
            this.btnAlterarSenha.UseVisualStyleBackColor = true;
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_ClickAsync);
            // 
            // mskSenha
            // 
            this.mskSenha.Enabled = false;
            this.mskSenha.Location = new System.Drawing.Point(129, 127);
            this.mskSenha.Name = "mskSenha";
            this.mskSenha.Size = new System.Drawing.Size(165, 23);
            this.mskSenha.TabIndex = 4;
            // 
            // mskCpfAlterar
            // 
            this.mskCpfAlterar.Enabled = false;
            this.mskCpfAlterar.Location = new System.Drawing.Point(129, 77);
            this.mskCpfAlterar.Name = "mskCpfAlterar";
            this.mskCpfAlterar.Size = new System.Drawing.Size(165, 23);
            this.mskCpfAlterar.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nova Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "CPF";
            // 
            // txtEmailAlterar
            // 
            this.txtEmailAlterar.Enabled = false;
            this.txtEmailAlterar.Location = new System.Drawing.Point(129, 43);
            this.txtEmailAlterar.Name = "txtEmailAlterar";
            this.txtEmailAlterar.Size = new System.Drawing.Size(165, 23);
            this.txtEmailAlterar.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Digite seu CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Digite seu Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(151, 36);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(145, 23);
            this.txtEmail.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(84, 118);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 31);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar Usuario";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(308, 381);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mskCPF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmAlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            this.Load += new System.EventHandler(this.frmAlterarSenha_LoadAsync);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private MaskedTextBox mskCPF;
        private Panel panel1;
        private Button btnAlterarSenha;
        private MaskedTextBox mskSenha;
        private MaskedTextBox maskedTextBox2;
        private Label label6;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private Button btnBuscar;
        private MaskedTextBox txtCpfAlterar;
        private TextBox txtEmailAlterar;
        private MaskedTextBox mskCpfAlterar;
    }
}