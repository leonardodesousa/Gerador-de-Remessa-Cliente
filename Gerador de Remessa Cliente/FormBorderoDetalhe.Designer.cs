namespace Gerador_de_Remessa_Cliente
{
    partial class FormBorderoDetalhe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBorderoDetalhe));
            dataGridView1 = new DataGridView();
            emissao = new DataGridViewTextBoxColumn();
            vencimento = new DataGridViewTextBoxColumn();
            seuNumero = new DataGridViewTextBoxColumn();
            valor = new DataGridViewTextBoxColumn();
            pagador = new DataGridViewTextBoxColumn();
            txtBoxLote = new TextBox();
            labelLote = new Label();
            txtBoxContrato = new TextBox();
            labelContrato = new Label();
            txtBoxTotal = new TextBox();
            label1 = new Label();
            btnOk = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { emissao, vencimento, seuNumero, valor, pagador });
            dataGridView1.Location = new Point(183, 197);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(544, 325);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // emissao
            // 
            emissao.HeaderText = "Emissão";
            emissao.Name = "emissao";
            emissao.ReadOnly = true;
            // 
            // vencimento
            // 
            vencimento.HeaderText = "Vencimento";
            vencimento.Name = "vencimento";
            vencimento.ReadOnly = true;
            // 
            // seuNumero
            // 
            seuNumero.HeaderText = "Seu Número";
            seuNumero.Name = "seuNumero";
            seuNumero.ReadOnly = true;
            // 
            // valor
            // 
            valor.HeaderText = "Valor";
            valor.Name = "valor";
            valor.ReadOnly = true;
            // 
            // pagador
            // 
            pagador.HeaderText = "Pagador";
            pagador.Name = "pagador";
            pagador.ReadOnly = true;
            // 
            // txtBoxLote
            // 
            txtBoxLote.Location = new Point(192, 134);
            txtBoxLote.MaxLength = 10;
            txtBoxLote.Name = "txtBoxLote";
            txtBoxLote.ReadOnly = true;
            txtBoxLote.Size = new Size(100, 23);
            txtBoxLote.TabIndex = 1;
            txtBoxLote.TextChanged += txtBoxLote_TextChanged;
            // 
            // labelLote
            // 
            labelLote.AutoSize = true;
            labelLote.Location = new Point(142, 134);
            labelLote.Name = "labelLote";
            labelLote.Size = new Size(30, 15);
            labelLote.TabIndex = 2;
            labelLote.Text = "Lote";
            // 
            // txtBoxContrato
            // 
            txtBoxContrato.Location = new Point(406, 134);
            txtBoxContrato.Name = "txtBoxContrato";
            txtBoxContrato.ReadOnly = true;
            txtBoxContrato.Size = new Size(100, 23);
            txtBoxContrato.TabIndex = 3;
            txtBoxContrato.TextChanged += txtBoxContrato_TextChanged;
            // 
            // labelContrato
            // 
            labelContrato.AutoSize = true;
            labelContrato.Location = new Point(334, 134);
            labelContrato.Name = "labelContrato";
            labelContrato.Size = new Size(54, 15);
            labelContrato.TabIndex = 4;
            labelContrato.Text = "Contrato";
            // 
            // txtBoxTotal
            // 
            txtBoxTotal.ImeMode = ImeMode.NoControl;
            txtBoxTotal.Location = new Point(668, 134);
            txtBoxTotal.MaxLength = 20;
            txtBoxTotal.Name = "txtBoxTotal";
            txtBoxTotal.ReadOnly = true;
            txtBoxTotal.Size = new Size(100, 23);
            txtBoxTotal.TabIndex = 5;
            txtBoxTotal.TextChanged += txtBoxTotal_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(587, 134);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 6;
            label1.Text = "Total do Lote";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(861, 507);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(126, 47);
            btnOk.TabIndex = 7;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // FormBorderoDetalhe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1161, 612);
            Controls.Add(btnOk);
            Controls.Add(label1);
            Controls.Add(txtBoxTotal);
            Controls.Add(labelContrato);
            Controls.Add(txtBoxContrato);
            Controls.Add(labelLote);
            Controls.Add(txtBoxLote);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormBorderoDetalhe";
            Text = "Borderô Detalhe";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn emissao;
        private DataGridViewTextBoxColumn vencimento;
        private DataGridViewTextBoxColumn seuNumero;
        private DataGridViewTextBoxColumn valor;
        private DataGridViewTextBoxColumn pagador;
        private TextBox txtBoxLote;
        private Label labelLote;
        private TextBox txtBoxContrato;
        private Label labelContrato;
        private TextBox txtBoxTotal;
        private Label label1;
        private Button btnOk;
    }
}