namespace ProjetoFinaceiro.Designer
{
    partial class frmEntrada
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
            this.pnlEntradaFinaceira = new System.Windows.Forms.Panel();
            this.substituicaoTxtValor1 = new ProjetoFinaceiro.Designer.substituicaoTxtValor();
            this.cmbEntradas = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlEntradaFinaceira.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEntradaFinaceira
            // 
            this.pnlEntradaFinaceira.BackColor = System.Drawing.Color.BurlyWood;
            this.pnlEntradaFinaceira.Controls.Add(this.substituicaoTxtValor1);
            this.pnlEntradaFinaceira.Controls.Add(this.cmbEntradas);
            this.pnlEntradaFinaceira.Controls.Add(this.btnCancelar);
            this.pnlEntradaFinaceira.Controls.Add(this.btnInserir);
            this.pnlEntradaFinaceira.Controls.Add(this.label3);
            this.pnlEntradaFinaceira.Controls.Add(this.label2);
            this.pnlEntradaFinaceira.Controls.Add(this.label1);
            this.pnlEntradaFinaceira.Location = new System.Drawing.Point(44, 82);
            this.pnlEntradaFinaceira.Name = "pnlEntradaFinaceira";
            this.pnlEntradaFinaceira.Size = new System.Drawing.Size(345, 281);
            this.pnlEntradaFinaceira.TabIndex = 0;
            // 
            // substituicaoTxtValor1
            // 
            this.substituicaoTxtValor1.BackColor = System.Drawing.Color.BurlyWood;
            this.substituicaoTxtValor1.Location = new System.Drawing.Point(168, 157);
            this.substituicaoTxtValor1.Name = "substituicaoTxtValor1";
            this.substituicaoTxtValor1.Size = new System.Drawing.Size(160, 23);
            this.substituicaoTxtValor1.TabIndex = 8;
            this.substituicaoTxtValor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbEntradas
            // 
            this.cmbEntradas.BackColor = System.Drawing.Color.BurlyWood;
            this.cmbEntradas.FormattingEnabled = true;
            this.cmbEntradas.Items.AddRange(new object[] {
            "Salario"});
            this.cmbEntradas.Location = new System.Drawing.Point(168, 102);
            this.cmbEntradas.Name = "cmbEntradas";
            this.cmbEntradas.Size = new System.Drawing.Size(160, 23);
            this.cmbEntradas.TabIndex = 7;
            this.cmbEntradas.SelectedIndexChanged += new System.EventHandler(this.cmbEntradas_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(193, 220);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 36);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInserir.Location = new System.Drawing.Point(47, 220);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(108, 36);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "Inserir Entrada";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor da entrada.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o nome \r\n   da entrada.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrada Finaceira";
            // 
            // frmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoFinaceiro.Properties.Resources.Controle_de_entrada_e_saida_de_pessoas_810x4551;
            this.ClientSize = new System.Drawing.Size(641, 458);
            this.Controls.Add(this.pnlEntradaFinaceira);
            this.MaximizeBox = false;
            this.Name = "frmEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada Finaceira";
            this.Load += new System.EventHandler(this.frmEntrada_Load);
            this.pnlEntradaFinaceira.ResumeLayout(false);
            this.pnlEntradaFinaceira.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlEntradaFinaceira;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnInserir;
        private substituicaoTxtValor TxtValor;
        private ComboBox cmbEntradas;
        private substituicaoTxtValor substituicaoTxtValor1;
    }
}