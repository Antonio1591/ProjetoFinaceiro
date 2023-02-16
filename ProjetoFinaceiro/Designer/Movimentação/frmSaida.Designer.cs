namespace ProjetoFinaceiro.Designer
{
    partial class frmSaida
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
            this.DataSaida = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cmbSaidas = new System.Windows.Forms.ComboBox();
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
            this.pnlEntradaFinaceira.BackColor = System.Drawing.Color.LightBlue;
            this.pnlEntradaFinaceira.Controls.Add(this.DataSaida);
            this.pnlEntradaFinaceira.Controls.Add(this.label4);
            this.pnlEntradaFinaceira.Controls.Add(this.txtValor);
            this.pnlEntradaFinaceira.Controls.Add(this.cmbSaidas);
            this.pnlEntradaFinaceira.Controls.Add(this.btnCancelar);
            this.pnlEntradaFinaceira.Controls.Add(this.btnInserir);
            this.pnlEntradaFinaceira.Controls.Add(this.label3);
            this.pnlEntradaFinaceira.Controls.Add(this.label2);
            this.pnlEntradaFinaceira.Controls.Add(this.label1);
            this.pnlEntradaFinaceira.Location = new System.Drawing.Point(122, 61);
            this.pnlEntradaFinaceira.Name = "pnlEntradaFinaceira";
            this.pnlEntradaFinaceira.Size = new System.Drawing.Size(345, 287);
            this.pnlEntradaFinaceira.TabIndex = 1;
            // 
            // DataSaida
            // 
            this.DataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataSaida.Location = new System.Drawing.Point(168, 193);
            this.DataSaida.Name = "DataSaida";
            this.DataSaida.RightToLeftLayout = true;
            this.DataSaida.Size = new System.Drawing.Size(160, 23);
            this.DataSaida.TabIndex = 8;
            this.DataSaida.Value = new System.DateTime(2023, 2, 14, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data Saida";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(168, 157);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(160, 23);
            this.txtValor.TabIndex = 6;
            // 
            // cmbSaidas
            // 
            this.cmbSaidas.BackColor = System.Drawing.Color.LightBlue;
            this.cmbSaidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSaidas.FormattingEnabled = true;
            this.cmbSaidas.Location = new System.Drawing.Point(168, 102);
            this.cmbSaidas.Name = "cmbSaidas";
            this.cmbSaidas.Size = new System.Drawing.Size(160, 23);
            this.cmbSaidas.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightBlue;
            this.btnCancelar.Location = new System.Drawing.Point(191, 233);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 36);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.LightBlue;
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInserir.Location = new System.Drawing.Point(49, 233);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(108, 36);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Inserir Saida";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor da saída";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o nome \r\n   da saída.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(102, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saída Finaceira";
            // 
            // frmSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::ProjetoFinaceiro.Properties.Resources.Saida;
            this.ClientSize = new System.Drawing.Size(601, 437);
            this.Controls.Add(this.pnlEntradaFinaceira);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "frmSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSaida";
            this.Load += new System.EventHandler(this.frmSaida_Load);
            this.pnlEntradaFinaceira.ResumeLayout(false);
            this.pnlEntradaFinaceira.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlEntradaFinaceira;
        //private substituicaoTxtValor txtValor;
        private ComboBox cmbSaidas;
        private Button btnCancelar;
        private Button btnInserir;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtValor;
        private DateTimePicker DataSaida;
        private Label label4;
    }
}