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
            this.checkBoxEnviaSeuNum = new System.Windows.Forms.CheckBox();
            this.Leaute = new System.Windows.Forms.Label();
            this.comboLeiaute = new System.Windows.Forms.ComboBox();
            this.textBoxDiretorioDestino = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelCarteira = new System.Windows.Forms.Label();
            this.mskTextBoxCarteira = new System.Windows.Forms.MaskedTextBox();
            this.labelBcoCobrador = new System.Windows.Forms.Label();
            this.mskBancoCobrador = new System.Windows.Forms.MaskedTextBox();
            this.mskTextBoxNumDocCedente = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mskTextBoxAgCedente = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mskTextBoxContaCedente = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskTextBoxConvenio = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.comboConvenios = new System.Windows.Forms.ComboBox();
            this.labelConvenios = new System.Windows.Forms.Label();
            this.bnBuscarDados = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerarArquivo
            // 
            this.btnGerarArquivo.Location = new System.Drawing.Point(90, 656);
            this.btnGerarArquivo.Name = "btnGerarArquivo";
            this.btnGerarArquivo.Size = new System.Drawing.Size(137, 49);
            this.btnGerarArquivo.TabIndex = 16;
            this.btnGerarArquivo.Text = "Gerar Arquivo";
            this.btnGerarArquivo.UseVisualStyleBackColor = true;
            this.btnGerarArquivo.Click += new System.EventHandler(this.btnGerarArquivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seu Número inicial ->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
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
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(570, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantidade de arquivos ->";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // mskTextBoxSeuNumero
            // 
            this.mskTextBoxSeuNumero.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTextBoxSeuNumero.Location = new System.Drawing.Point(185, 47);
            this.mskTextBoxSeuNumero.Mask = "0000000000";
            this.mskTextBoxSeuNumero.Name = "mskTextBoxSeuNumero";
            this.mskTextBoxSeuNumero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskTextBoxSeuNumero.Size = new System.Drawing.Size(137, 27);
            this.mskTextBoxSeuNumero.TabIndex = 1;
            this.mskTextBoxSeuNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskTextBoxSeuNumero.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTextBoxSeuNumero_MaskInputRejected);
            // 
            // mskTextBoxLinhasArquivo
            // 
            this.mskTextBoxLinhasArquivo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTextBoxLinhasArquivo.Location = new System.Drawing.Point(185, 81);
            this.mskTextBoxLinhasArquivo.Mask = "00000";
            this.mskTextBoxLinhasArquivo.Name = "mskTextBoxLinhasArquivo";
            this.mskTextBoxLinhasArquivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskTextBoxLinhasArquivo.Size = new System.Drawing.Size(137, 27);
            this.mskTextBoxLinhasArquivo.TabIndex = 3;
            this.mskTextBoxLinhasArquivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mskTextBoxQtdArquivos
            // 
            this.mskTextBoxQtdArquivos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTextBoxQtdArquivos.Location = new System.Drawing.Point(764, 128);
            this.mskTextBoxQtdArquivos.Mask = "00000";
            this.mskTextBoxQtdArquivos.Name = "mskTextBoxQtdArquivos";
            this.mskTextBoxQtdArquivos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskTextBoxQtdArquivos.Size = new System.Drawing.Size(113, 27);
            this.mskTextBoxQtdArquivos.TabIndex = 6;
            this.mskTextBoxQtdArquivos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskTextBoxQtdArquivos.ValidatingType = typeof(int);
            // 
            // mskTextBoxDataInclusao
            // 
            this.mskTextBoxDataInclusao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTextBoxDataInclusao.Location = new System.Drawing.Point(764, 53);
            this.mskTextBoxDataInclusao.Mask = "00/00/0000";
            this.mskTextBoxDataInclusao.Name = "mskTextBoxDataInclusao";
            this.mskTextBoxDataInclusao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskTextBoxDataInclusao.Size = new System.Drawing.Size(113, 27);
            this.mskTextBoxDataInclusao.TabIndex = 2;
            this.mskTextBoxDataInclusao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskTextBoxDataInclusao.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(544, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data de emissão (ddmmaa) ->";
            // 
            // mskTextBoxDataVencimento
            // 
            this.mskTextBoxDataVencimento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTextBoxDataVencimento.Location = new System.Drawing.Point(764, 91);
            this.mskTextBoxDataVencimento.Mask = "00/00/0000";
            this.mskTextBoxDataVencimento.Name = "mskTextBoxDataVencimento";
            this.mskTextBoxDataVencimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskTextBoxDataVencimento.Size = new System.Drawing.Size(113, 27);
            this.mskTextBoxDataVencimento.TabIndex = 4;
            this.mskTextBoxDataVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskTextBoxDataVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(487, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data Vencimento Boletos (ddmmaa) ->";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxEnviaSeuNum);
            this.groupBox1.Controls.Add(this.Leaute);
            this.groupBox1.Controls.Add(this.comboLeiaute);
            this.groupBox1.Controls.Add(this.textBoxDiretorioDestino);
            this.groupBox1.Controls.Add(this.label10);
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
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(90, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 263);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parâmetros de entrada";
            // 
            // checkBoxEnviaSeuNum
            // 
            this.checkBoxEnviaSeuNum.AutoSize = true;
            this.checkBoxEnviaSeuNum.ForeColor = System.Drawing.Color.Red;
            this.checkBoxEnviaSeuNum.Location = new System.Drawing.Point(328, 51);
            this.checkBoxEnviaSeuNum.Name = "checkBoxEnviaSeuNum";
            this.checkBoxEnviaSeuNum.Size = new System.Drawing.Size(186, 24);
            this.checkBoxEnviaSeuNum.TabIndex = 19;
            this.checkBoxEnviaSeuNum.Text = "Não enviar Seu Número";
            this.checkBoxEnviaSeuNum.UseVisualStyleBackColor = true;
            this.checkBoxEnviaSeuNum.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // Leaute
            // 
            this.Leaute.AutoSize = true;
            this.Leaute.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Leaute.Location = new System.Drawing.Point(106, 126);
            this.Leaute.Name = "Leaute";
            this.Leaute.Size = new System.Drawing.Size(73, 20);
            this.Leaute.TabIndex = 18;
            this.Leaute.Text = "Layout ->";
            // 
            // comboLeiaute
            // 
            this.comboLeiaute.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboLeiaute.FormattingEnabled = true;
            this.comboLeiaute.Items.AddRange(new object[] {
            "Bradesco",
            "Itaú",
            "TotalBanco"});
            this.comboLeiaute.Location = new System.Drawing.Point(185, 118);
            this.comboLeiaute.Name = "comboLeiaute";
            this.comboLeiaute.Size = new System.Drawing.Size(137, 28);
            this.comboLeiaute.Sorted = true;
            this.comboLeiaute.TabIndex = 17;
            // 
            // textBoxDiretorioDestino
            // 
            this.textBoxDiretorioDestino.Location = new System.Drawing.Point(232, 203);
            this.textBoxDiretorioDestino.Name = "textBoxDiretorioDestino";
            this.textBoxDiretorioDestino.Size = new System.Drawing.Size(549, 27);
            this.textBoxDiretorioDestino.TabIndex = 7;
            this.textBoxDiretorioDestino.TextChanged += new System.EventHandler(this.textBoxDiretorioDestino_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(20, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Diretório destino arquivo ->";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelCarteira);
            this.groupBox2.Controls.Add(this.mskTextBoxCarteira);
            this.groupBox2.Controls.Add(this.labelBcoCobrador);
            this.groupBox2.Controls.Add(this.mskBancoCobrador);
            this.groupBox2.Controls.Add(this.mskTextBoxNumDocCedente);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.mskTextBoxAgCedente);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.mskTextBoxContaCedente);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.mskTextBoxConvenio);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(90, 420);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(965, 190);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Cedente";
            // 
            // labelCarteira
            // 
            this.labelCarteira.AutoSize = true;
            this.labelCarteira.Location = new System.Drawing.Point(636, 120);
            this.labelCarteira.Name = "labelCarteira";
            this.labelCarteira.Size = new System.Drawing.Size(81, 20);
            this.labelCarteira.TabIndex = 15;
            this.labelCarteira.Text = "Carteira ->";
            // 
            // mskTextBoxCarteira
            // 
            this.mskTextBoxCarteira.Location = new System.Drawing.Point(723, 117);
            this.mskTextBoxCarteira.Mask = "000";
            this.mskTextBoxCarteira.Name = "mskTextBoxCarteira";
            this.mskTextBoxCarteira.Size = new System.Drawing.Size(100, 27);
            this.mskTextBoxCarteira.TabIndex = 14;
            this.mskTextBoxCarteira.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskTextBoxCarteira.ValidatingType = typeof(int);
            // 
            // labelBcoCobrador
            // 
            this.labelBcoCobrador.AutoSize = true;
            this.labelBcoCobrador.Location = new System.Drawing.Point(106, 123);
            this.labelBcoCobrador.Name = "labelBcoCobrador";
            this.labelBcoCobrador.Size = new System.Drawing.Size(70, 20);
            this.labelBcoCobrador.TabIndex = 13;
            this.labelBcoCobrador.Text = "Banco ->";
            // 
            // mskBancoCobrador
            // 
            this.mskBancoCobrador.Location = new System.Drawing.Point(185, 116);
            this.mskBancoCobrador.Mask = "000";
            this.mskBancoCobrador.Name = "mskBancoCobrador";
            this.mskBancoCobrador.Size = new System.Drawing.Size(100, 27);
            this.mskBancoCobrador.TabIndex = 12;
            this.mskBancoCobrador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskBancoCobrador.ValidatingType = typeof(int);
            this.mskBancoCobrador.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskBancoCobrador_MaskInputRejected);
            // 
            // mskTextBoxNumDocCedente
            // 
            this.mskTextBoxNumDocCedente.Location = new System.Drawing.Point(723, 65);
            this.mskTextBoxNumDocCedente.Mask = "00000000000000";
            this.mskTextBoxNumDocCedente.Name = "mskTextBoxNumDocCedente";
            this.mskTextBoxNumDocCedente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskTextBoxNumDocCedente.Size = new System.Drawing.Size(154, 27);
            this.mskTextBoxNumDocCedente.TabIndex = 11;
            this.mskTextBoxNumDocCedente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskTextBoxNumDocCedente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTextBoxNumDocCedente_MaskInputRejected);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(544, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Número Doc Cedente ->";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // mskTextBoxAgCedente
            // 
            this.mskTextBoxAgCedente.Location = new System.Drawing.Point(185, 28);
            this.mskTextBoxAgCedente.Mask = "00";
            this.mskTextBoxAgCedente.Name = "mskTextBoxAgCedente";
            this.mskTextBoxAgCedente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskTextBoxAgCedente.Size = new System.Drawing.Size(100, 27);
            this.mskTextBoxAgCedente.TabIndex = 8;
            this.mskTextBoxAgCedente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Agência Cedente ->";
            // 
            // mskTextBoxContaCedente
            // 
            this.mskTextBoxContaCedente.Location = new System.Drawing.Point(185, 71);
            this.mskTextBoxContaCedente.Mask = "0000000000";
            this.mskTextBoxContaCedente.Name = "mskTextBoxContaCedente";
            this.mskTextBoxContaCedente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskTextBoxContaCedente.Size = new System.Drawing.Size(100, 27);
            this.mskTextBoxContaCedente.TabIndex = 10;
            this.mskTextBoxContaCedente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskTextBoxContaCedente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTextBoxContaCedente_MaskInputRejected);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Conta do Cedente ->";
            // 
            // mskTextBoxConvenio
            // 
            this.mskTextBoxConvenio.Location = new System.Drawing.Point(723, 30);
            this.mskTextBoxConvenio.Mask = "000000000000";
            this.mskTextBoxConvenio.Name = "mskTextBoxConvenio";
            this.mskTextBoxConvenio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskTextBoxConvenio.Size = new System.Drawing.Size(154, 27);
            this.mskTextBoxConvenio.TabIndex = 9;
            this.mskTextBoxConvenio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskTextBoxConvenio.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTextBoxConvenio_MaskInputRejected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Identificação do Convênio ->";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(830, 656);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(137, 49);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // comboConvenios
            // 
            this.comboConvenios.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboConvenios.FormattingEnabled = true;
            this.comboConvenios.Location = new System.Drawing.Point(315, 62);
            this.comboConvenios.Name = "comboConvenios";
            this.comboConvenios.Size = new System.Drawing.Size(488, 28);
            this.comboConvenios.TabIndex = 18;
            this.comboConvenios.SelectedIndexChanged += new System.EventHandler(this.comboConvenios_SelectedIndexChanged);
            // 
            // labelConvenios
            // 
            this.labelConvenios.AutoSize = true;
            this.labelConvenios.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelConvenios.Location = new System.Drawing.Point(88, 62);
            this.labelConvenios.Name = "labelConvenios";
            this.labelConvenios.Size = new System.Drawing.Size(181, 20);
            this.labelConvenios.TabIndex = 19;
            this.labelConvenios.Text = "Convênios cadastrados ->";
            // 
            // bnBuscarDados
            // 
            this.bnBuscarDados.Location = new System.Drawing.Point(828, 49);
            this.bnBuscarDados.Name = "bnBuscarDados";
            this.bnBuscarDados.Size = new System.Drawing.Size(137, 49);
            this.bnBuscarDados.TabIndex = 20;
            this.bnBuscarDados.Text = "Buscar Dados";
            this.bnBuscarDados.UseVisualStyleBackColor = true;
            this.bnBuscarDados.Click += new System.EventHandler(this.bnBuscarDados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1086, 749);
            this.Controls.Add(this.bnBuscarDados);
            this.Controls.Add(this.labelConvenios);
            this.Controls.Add(this.comboConvenios);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGerarArquivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gerador de Remessa Cliente ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private GroupBox groupBox2;
        private MaskedTextBox mskTextBoxContaCedente;
        private Label label8;
        private MaskedTextBox mskTextBoxConvenio;
        private Label label7;
        private MaskedTextBox mskTextBoxAgCedente;
        private Label label9;
        private TextBox textBoxDiretorioDestino;
        private Label label10;
        private Label label11;
        private MaskedTextBox mskTextBoxNumDocCedente;
        private Button btnSair;
        private Label Leaute;
        private ComboBox comboLeiaute;
        private ComboBox comboConvenios;
        private Label labelConvenios;
        private Button bnBuscarDados;
        private Label labelBcoCobrador;
        private MaskedTextBox mskBancoCobrador;
        private Label labelCarteira;
        private MaskedTextBox mskTextBoxCarteira;
        private CheckBox checkBoxEnviaSeuNum;
    }
}