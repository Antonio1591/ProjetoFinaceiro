namespace ProjetoFinaceiro.Designer
{
    partial class frmRelatorio
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNomeoperacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDataLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTipoOperracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoOPeracao = new System.Windows.Forms.ComboBox();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtNomeoperacao,
            this.txtDataLancamento,
            this.txtTipoOperracao,
            this.txtValor,
            this.txtSituacao});
            this.dataGridView1.Location = new System.Drawing.Point(-5, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(545, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtNomeoperacao
            // 
            this.txtNomeoperacao.HeaderText = "Nome da Operação";
            this.txtNomeoperacao.Name = "txtNomeoperacao";
            this.txtNomeoperacao.ReadOnly = true;
            // 
            // txtDataLancamento
            // 
            this.txtDataLancamento.HeaderText = "Data da Operação";
            this.txtDataLancamento.Name = "txtDataLancamento";
            this.txtDataLancamento.ReadOnly = true;
            // 
            // txtTipoOperracao
            // 
            this.txtTipoOperracao.HeaderText = "Tipo da Operação";
            this.txtTipoOperracao.Name = "txtTipoOperracao";
            this.txtTipoOperracao.ReadOnly = true;
            // 
            // txtValor
            // 
            this.txtValor.HeaderText = "Valor da Operação";
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            // 
            // txtSituacao
            // 
            this.txtSituacao.HeaderText = "Situação";
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.ReadOnly = true;
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicial.Location = new System.Drawing.Point(12, 86);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(104, 23);
            this.dtInicial.TabIndex = 1;
            this.dtInicial.Value = new System.DateTime(2022, 9, 15, 0, 0, 0, 0);
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFinal.Location = new System.Drawing.Point(157, 84);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(104, 23);
            this.dtFinal.TabIndex = 2;
            this.dtFinal.Value = new System.DateTime(2022, 9, 15, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Até";
            // 
            // cmbTipoOPeracao
            // 
            this.cmbTipoOPeracao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoOPeracao.FormattingEnabled = true;
            this.cmbTipoOPeracao.Items.AddRange(new object[] {
            "Entrada",
            "Saida",
            "TODOS"});
            this.cmbTipoOPeracao.Location = new System.Drawing.Point(276, 84);
            this.cmbTipoOPeracao.Name = "cmbTipoOPeracao";
            this.cmbTipoOPeracao.Size = new System.Drawing.Size(120, 23);
            this.cmbTipoOPeracao.TabIndex = 4;
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO",
            "TODOS"});
            this.cmbSituacao.Location = new System.Drawing.Point(409, 84);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(120, 23);
            this.cmbSituacao.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(157, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(276, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo da Operacao";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(434, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Situação";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(122, 165);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(118, 38);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSituacao);
            this.Controls.Add(this.cmbTipoOPeracao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFinal);
            this.Controls.Add(this.dtInicial);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorio";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dtInicial;
        private DateTimePicker dtFinal;
        private Label label1;
        private ComboBox cmbTipoOPeracao;
        private ComboBox cmbSituacao;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnBuscar;
        private Button button1;
        private DataGridViewTextBoxColumn txtNomeoperacao;
        private DataGridViewTextBoxColumn txtDataLancamento;
        private DataGridViewTextBoxColumn txtTipoOperracao;
        private DataGridViewTextBoxColumn txtValor;
        private DataGridViewTextBoxColumn txtSituacao;
    }
}