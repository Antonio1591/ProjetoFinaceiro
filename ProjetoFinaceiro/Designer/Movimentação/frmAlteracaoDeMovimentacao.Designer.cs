namespace ProjetoFinaceiro.Designer.Movimentação
{
    partial class frmAlteracaoDeMovimentacao
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
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoOperacao = new System.Windows.Forms.ComboBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtNomeOperacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorEntrada = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btbLimpar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtValorSaida = new System.Windows.Forms.TextBox();
            this.dtMovimentacao = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cmbSituacao.Location = new System.Drawing.Point(192, 303);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(149, 24);
            this.cmbSituacao.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Situação";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.Location = new System.Drawing.Point(192, 71);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(149, 22);
            this.txtCodigo.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(43, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Codigo";
            // 
            // cmbTipoOperacao
            // 
            this.cmbTipoOperacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbTipoOperacao.FormattingEnabled = true;
            this.cmbTipoOperacao.Items.AddRange(new object[] {
            "Entrada",
            "Saida"});
            this.cmbTipoOperacao.Location = new System.Drawing.Point(192, 152);
            this.cmbTipoOperacao.Name = "cmbTipoOperacao";
            this.cmbTipoOperacao.Size = new System.Drawing.Size(149, 24);
            this.cmbTipoOperacao.TabIndex = 26;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPesquisar.Location = new System.Drawing.Point(87, 20);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(152, 25);
            this.lblPesquisar.TabIndex = 27;
            this.lblPesquisar.Text = "Buscar cadastro";
            // 
            // txtNomeOperacao
            // 
            this.txtNomeOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNomeOperacao.Location = new System.Drawing.Point(192, 113);
            this.txtNomeOperacao.Name = "txtNomeOperacao";
            this.txtNomeOperacao.Size = new System.Drawing.Size(149, 22);
            this.txtNomeOperacao.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tipo de Operação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nome da Operação";
            // 
            // txtValorEntrada
            // 
            this.txtValorEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtValorEntrada.Location = new System.Drawing.Point(192, 199);
            this.txtValorEntrada.Name = "txtValorEntrada";
            this.txtValorEntrada.Size = new System.Drawing.Size(149, 22);
            this.txtValorEntrada.TabIndex = 33;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValor.Location = new System.Drawing.Point(15, 202);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(137, 16);
            this.lblValor.TabIndex = 32;
            this.lblValor.Text = "Valor da operação";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(34, 357);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 35);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btbLimpar
            // 
            this.btbLimpar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btbLimpar.Location = new System.Drawing.Point(192, 357);
            this.btbLimpar.Name = "btbLimpar";
            this.btbLimpar.Size = new System.Drawing.Size(106, 35);
            this.btbLimpar.TabIndex = 35;
            this.btbLimpar.Text = "Limpar";
            this.btbLimpar.UseVisualStyleBackColor = true;
            this.btbLimpar.Click += new System.EventHandler(this.btbLimpar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInserir.Location = new System.Drawing.Point(34, 357);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(109, 35);
            this.btnInserir.TabIndex = 36;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtValorSaida
            // 
            this.txtValorSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtValorSaida.Location = new System.Drawing.Point(192, 202);
            this.txtValorSaida.Name = "txtValorSaida";
            this.txtValorSaida.Size = new System.Drawing.Size(149, 22);
            this.txtValorSaida.TabIndex = 37;
            // 
            // dtMovimentacao
            // 
            this.dtMovimentacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMovimentacao.Location = new System.Drawing.Point(192, 242);
            this.dtMovimentacao.Name = "dtMovimentacao";
            this.dtMovimentacao.Size = new System.Drawing.Size(149, 23);
            this.dtMovimentacao.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 32);
            this.label3.TabIndex = 39;
            this.label3.Text = "Data da\r\n Movimentação";
            // 
            // frmAlteracaoDeMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(372, 429);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtMovimentacao);
            this.Controls.Add(this.btbLimpar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtValorEntrada);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.cmbSituacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipoOperacao);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.txtNomeOperacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtValorSaida);
            this.Name = "frmAlteracaoDeMovimentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlteracaoDeMovimentacao";
            this.Load += new System.EventHandler(this.frmAlteracaoDeMovimentacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbSituacao;
        private Label label4;
        private TextBox txtCodigo;
        private Label label5;
        private ComboBox cmbTipoOperacao;
        private Label lblPesquisar;
        private TextBox txtNomeOperacao;
        private Label label2;
        private Label label1;
        private TextBox txtValorEntrada;
        private Label lblValor;
        private Button btnBuscar;
        private Button btbLimpar;
        private Button btnInserir;
        private TextBox txtValorSaida;
        private DateTimePicker dtMovimentacao;
        private Label label3;
    }
}