namespace ProjetoFinaceiro.Designer
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeEntradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finaceiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlValoresMensal = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtValorEntrada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlValoresMensal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.finaceiroToolStripMenuItem,
            this.entradasToolStripMenuItem,
            this.saidasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposDeEntradasToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // tiposDeEntradasToolStripMenuItem
            // 
            this.tiposDeEntradasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tiposDeEntradasToolStripMenuItem.Name = "tiposDeEntradasToolStripMenuItem";
            this.tiposDeEntradasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.tiposDeEntradasToolStripMenuItem.Text = "Tipos De Entradas/Saidas";
            this.tiposDeEntradasToolStripMenuItem.Click += new System.EventHandler(this.tiposDeEntradasToolStripMenuItem_Click);
            // 
            // finaceiroToolStripMenuItem
            // 
            this.finaceiroToolStripMenuItem.Name = "finaceiroToolStripMenuItem";
            this.finaceiroToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.finaceiroToolStripMenuItem.Text = "Finaceiro";
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarEntradaToolStripMenuItem});
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.entradasToolStripMenuItem.Text = "Entradas";
            // 
            // adicionarEntradaToolStripMenuItem
            // 
            //this.adicionarEntradaToolStripMenuItem.Image = global::ProjetoFinaceiro.Properties.Resources.Dinheiro;
            this.adicionarEntradaToolStripMenuItem.Name = "adicionarEntradaToolStripMenuItem";
            this.adicionarEntradaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.adicionarEntradaToolStripMenuItem.Text = "Adicionar Valor";
            this.adicionarEntradaToolStripMenuItem.Click += new System.EventHandler(this.adicionarEntradaToolStripMenuItem_Click);
            // 
            // saidasToolStripMenuItem
            // 
            this.saidasToolStripMenuItem.Name = "saidasToolStripMenuItem";
            this.saidasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.saidasToolStripMenuItem.Text = "Saidas";
            // 
            // pnlValoresMensal
            // 
            this.pnlValoresMensal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlValoresMensal.Controls.Add(this.label4);
            this.pnlValoresMensal.Controls.Add(this.textBox3);
            this.pnlValoresMensal.Controls.Add(this.textBox2);
            this.pnlValoresMensal.Controls.Add(this.txtValorEntrada);
            this.pnlValoresMensal.Controls.Add(this.label3);
            this.pnlValoresMensal.Controls.Add(this.label2);
            this.pnlValoresMensal.Controls.Add(this.label1);
            this.pnlValoresMensal.Location = new System.Drawing.Point(398, 195);
            this.pnlValoresMensal.Name = "pnlValoresMensal";
            this.pnlValoresMensal.Size = new System.Drawing.Size(248, 156);
            this.pnlValoresMensal.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(61, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valores mensal";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(106, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(94, 22);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(106, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 22);
            this.textBox2.TabIndex = 4;
            // 
            // txtValorEntrada
            // 
            this.txtValorEntrada.Enabled = false;
            this.txtValorEntrada.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorEntrada.Location = new System.Drawing.Point(106, 48);
            this.txtValorEntrada.Name = "txtValorEntrada";
            this.txtValorEntrada.Size = new System.Drawing.Size(94, 22);
            this.txtValorEntrada.TabIndex = 3;
            this.txtValorEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Saida ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor total ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Entrada ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoFinaceiro.Properties.Resources.Finaceiro_ico;
            this.ClientSize = new System.Drawing.Size(658, 425);
            this.Controls.Add(this.pnlValoresMensal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlValoresMensal.ResumeLayout(false);
            this.pnlValoresMensal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem finaceiroToolStripMenuItem;
        private ToolStripMenuItem saidasToolStripMenuItem;
        private ToolStripMenuItem entradasToolStripMenuItem;
        private Panel pnlValoresMensal;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txtValorEntrada;
        private Label label3;
        private Label label2;
        private Label label1;
        private ToolStripMenuItem adicionarEntradaToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem tiposDeEntradasToolStripMenuItem;
    }
}