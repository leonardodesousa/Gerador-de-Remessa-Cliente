namespace Gerador_de_Remessa_Cliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGerarArquivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.mskTextBoxSeuNumero = new System.Windows.Forms.MaskedTextBox();
            this.mskTextBoxLinhasArquivo = new System.Windows.Forms.MaskedTextBox();
            this.mskTextBoxQtdArquivos = new System.Windows.Forms.MaskedTextBox();
            this.mskTextBoxDataInclusao = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskTextBoxDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDiretorioDestino = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mskTextBoxSequencialArq = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskTextBoxAgCedente = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mskTextBoxContaCedente = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskTextBoxConvenio = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerarArquivo
            // 
            this.btnGerarArquivo.Location = new System.Drawing.Point(50, 511);
            this.btnGerarArquivo.Name = "btnGerarArquivo";
            this.btnGerarArquivo.Size = new System.Drawing.Size(137, 49);
            this.btnGerarArquivo.TabIndex = 0;
            this.btnGerarArquivo.Text = "Gerar Arquivo";
            this.btnGerarArquivo.UseVisualStyleBackColor = true;
            this.btnGerarArquivo.Click += new System.EventHandler(this.btnGerarArquivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seu Número inicial ->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Linhas por arquivo ->";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantidade de arquivos ->";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // mskTextBoxSeuNumero
            // 
            this.mskTextBoxSeuNumero.Location = new System.Drawing.Point(185, 47);
            this.mskTextBoxSeuNumero.Mask = "0000000000";
            this.mskTextBoxSeuNumero.Name = "mskTextBoxSeuNumero";
            this.mskTextBoxSeuNumero.Size = new System.Drawing.Size(137, 23);
            this.mskTextBoxSeuNumero.TabIndex = 7;
            this.mskTextBoxSeuNumero.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTextBoxSeuNumero_MaskInputRejected);
            // 
            // mskTextBoxLinhasArquivo
            // 
            this.mskTextBoxLinhasArquivo.Location = new System.Drawing.Point(185, 81);
            this.mskTextBoxLinhasArquivo.Mask = "00000";
            this.mskTextBoxLinhasArquivo.Name = "mskTextBoxLinhasArquivo";
            this.mskTextBoxLinhasArquivo.Size = new System.Drawing.Size(137, 23);
            this.mskTextBoxLinhasArquivo.TabIndex = 8;
            this.mskTextBoxLinhasArquivo.ValidatingType = typeof(int);
            // 
            // mskTextBoxQtdArquivos
            // 
            this.mskTextBoxQtdArquivos.Location = new System.Drawing.Point(185, 151);
            this.mskTextBoxQtdArquivos.Mask = "00000";
            this.mskTextBoxQtdArquivos.Name = "mskTextBoxQtdArquivos";
            this.mskTextBoxQtdArquivos.Size = new System.Drawing.Size(137, 23);
            this.mskTextBoxQtdArquivos.TabIndex = 9;
            this.mskTextBoxQtdArquivos.ValidatingType = typeof(int);
            // 
            // mskTextBoxDataInclusao
            // 
            this.mskTextBoxDataInclusao.Location = new System.Drawing.Point(576, 52);
            this.mskTextBoxDataInclusao.Mask = "000000";
            this.mskTextBoxDataInclusao.Name = "mskTextBoxDataInclusao";
            this.mskTextBoxDataInclusao.Size = new System.Drawing.Size(113, 23);
            this.mskTextBoxDataInclusao.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data do arquivo (ddmmaa) ->";
            // 
            // mskTextBoxDataVencimento
            // 
            this.mskTextBoxDataVencimento.Location = new System.Drawing.Point(576, 86);
            this.mskTextBoxDataVencimento.Mask = "000000";
            this.mskTextBoxDataVencimento.Name = "mskTextBoxDataVencimento";
            this.mskTextBoxDataVencimento.Size = new System.Drawing.Size(113, 23);
            this.mskTextBoxDataVencimento.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data Vencimento Boletos (ddmmaa) ->";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDiretorioDestino);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.mskTextBoxSequencialArq);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.mskTextBoxLinhasArquivo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mskTextBoxDataVencimento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mskTextBoxDataInclusao);
            this.groupBox1.Controls.Add(this.mskTextBoxSeuNumero);
            this.groupBox1.Controls.Add(this.mskTextBoxQtdArquivos);
            this.groupBox1.Location = new System.Drawing.Point(50, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 263);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parâmetros de entrada";
            // 
            // textBoxDiretorioDestino
            // 
            this.textBoxDiretorioDestino.Location = new System.Drawing.Point(185, 203);
            this.textBoxDiretorioDestino.Name = "textBoxDiretorioDestino";
            this.textBoxDiretorioDestino.Size = new System.Drawing.Size(504, 23);
            this.textBoxDiretorioDestino.TabIndex = 17;
            this.textBoxDiretorioDestino.TextChanged += new System.EventHandler(this.textBoxDiretorioDestino_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Diretório destino arquivo ->";
            // 
            // mskTextBoxSequencialArq
            // 
            this.mskTextBoxSequencialArq.Location = new System.Drawing.Point(185, 118);
            this.mskTextBoxSequencialArq.Mask = "00000";
            this.mskTextBoxSequencialArq.Name = "mskTextBoxSequencialArq";
            this.mskTextBoxSequencialArq.Size = new System.Drawing.Size(137, 23);
            this.mskTextBoxSequencialArq.TabIndex = 15;
            this.mskTextBoxSequencialArq.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sequencial inicial Arquivo ->";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mskTextBoxAgCedente);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.mskTextBoxContaCedente);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.mskTextBoxConvenio);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(50, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 140);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Cedente";
            // 
            // mskTextBoxAgCedente
            // 
            this.mskTextBoxAgCedente.Location = new System.Drawing.Point(185, 28);
            this.mskTextBoxAgCedente.Mask = "00";
            this.mskTextBoxAgCedente.Name = "mskTextBoxAgCedente";
            this.mskTextBoxAgCedente.Size = new System.Drawing.Size(100, 23);
            this.mskTextBoxAgCedente.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Agência Cedente ->";
            // 
            // mskTextBoxContaCedente
            // 
            this.mskTextBoxContaCedente.Location = new System.Drawing.Point(185, 71);
            this.mskTextBoxContaCedente.Mask = "0000000000";
            this.mskTextBoxContaCedente.Name = "mskTextBoxContaCedente";
            this.mskTextBoxContaCedente.Size = new System.Drawing.Size(100, 23);
            this.mskTextBoxContaCedente.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Conta do Cedente ->";
            // 
            // mskTextBoxConvenio
            // 
            this.mskTextBoxConvenio.Location = new System.Drawing.Point(518, 33);
            this.mskTextBoxConvenio.Mask = "000000000000";
            this.mskTextBoxConvenio.Name = "mskTextBoxConvenio";
            this.mskTextBoxConvenio.Size = new System.Drawing.Size(118, 23);
            this.mskTextBoxConvenio.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(350, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Identificação do Convênio ->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 633);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGerarArquivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gerador de Remessa Cliente - LetsBank version";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGerarArquivo;
        private Label label1;
        private Label label2;
        private ImageList imageList1;
        private Label label3;
        private MaskedTextBox mskTextBoxSeuNumero;
        private MaskedTextBox mskTextBoxLinhasArquivo;
        private MaskedTextBox mskTextBoxQtdArquivos;
        private MaskedTextBox mskTextBoxDataInclusao;
        private Label label4;
        private MaskedTextBox mskTextBoxDataVencimento;
        private Label label5;
        private GroupBox groupBox1;
        private MaskedTextBox mskTextBoxSequencialArq;
        private Label label6;
        private GroupBox groupBox2;
        private MaskedTextBox mskTextBoxContaCedente;
        private Label label8;
        private MaskedTextBox mskTextBoxConvenio;
        private Label label7;
        private MaskedTextBox mskTextBoxAgCedente;
        private Label label9;
        private TextBox textBoxDiretorioDestino;
        private Label label10;
    }
}