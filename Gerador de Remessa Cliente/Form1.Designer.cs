﻿namespace Gerador_de_Remessa_Cliente
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnGerarArquivo = new Button();
            label1 = new Label();
            label2 = new Label();
            imageList1 = new ImageList(components);
            label3 = new Label();
            mskTextBoxSeuNumero = new MaskedTextBox();
            mskTextBoxLinhasArquivo = new MaskedTextBox();
            mskTextBoxQtdArquivos = new MaskedTextBox();
            mskTextBoxDataInclusao = new MaskedTextBox();
            label4 = new Label();
            mskTextBoxDataVencimento = new MaskedTextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            checkBoxEnviaSeuNum = new CheckBox();
            Leaute = new Label();
            comboLeiaute = new ComboBox();
            textBoxDiretorioDestino = new TextBox();
            label10 = new Label();
            groupBox2 = new GroupBox();
            label14 = new Label();
            mskTextBoxEmpresa = new MaskedTextBox();
            labelCodCliente = new Label();
            textBoxCodCliente = new TextBox();
            labelCarteira = new Label();
            mskTextBoxCarteira = new MaskedTextBox();
            labelBcoCobrador = new Label();
            mskBancoCobrador = new MaskedTextBox();
            mskTextBoxNumDocCedente = new MaskedTextBox();
            label11 = new Label();
            mskTextBoxAgCedente = new MaskedTextBox();
            label9 = new Label();
            mskTextBoxContaCedente = new MaskedTextBox();
            label8 = new Label();
            mskTextBoxConvenio = new MaskedTextBox();
            label7 = new Label();
            btnSair = new Button();
            comboConvenios = new ComboBox();
            labelConvenios = new Label();
            bnBuscarDados = new Button();
            Soap = new Button();
            btnConfigServerWs = new Button();
            groupBox3 = new GroupBox();
            label12 = new Label();
            label6 = new Label();
            LabelSdBloq = new Label();
            txtBxSaldoDisponivel = new TextBox();
            txtBoxSaldoBloqJud = new TextBox();
            txtBoxSaldoBloq = new TextBox();
            dataGridViewExtrato = new DataGridView();
            dtLanColumn = new DataGridViewTextBoxColumn();
            vlrLancadoColumn = new DataGridViewTextBoxColumn();
            vlrSaldoColumn = new DataGridViewTextBoxColumn();
            historicoColumn = new DataGridViewTextBoxColumn();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            linkLabelHistorico = new LinkLabel();
            btnLancarValor = new Button();
            textBoxValorLancado = new TextBox();
            label13 = new Label();
            label15 = new Label();
            textBoxNumDoc = new TextBox();
            textBoxHistorico = new TextBox();
            btnConfigModalidade = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnCliente = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExtrato).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // btnGerarArquivo
            // 
            btnGerarArquivo.BackColor = Color.DodgerBlue;
            btnGerarArquivo.FlatStyle = FlatStyle.Popup;
            btnGerarArquivo.Location = new Point(43, 616);
            btnGerarArquivo.Name = "btnGerarArquivo";
            btnGerarArquivo.Size = new Size(137, 49);
            btnGerarArquivo.TabIndex = 20;
            btnGerarArquivo.Text = "Gerar Arquivo CNAB";
            btnGerarArquivo.UseVisualStyleBackColor = false;
            btnGerarArquivo.Click += btnGerarArquivo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 51);
            label1.Name = "label1";
            label1.Size = new Size(198, 25);
            label1.TabIndex = 2;
            label1.Text = "Seu Número inicial ->";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(-2, 81);
            label2.Name = "label2";
            label2.Size = new Size(203, 25);
            label2.TabIndex = 4;
            label2.Text = "Boletos por arquivo ->";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(621, 125);
            label3.Name = "label3";
            label3.Size = new Size(240, 25);
            label3.TabIndex = 6;
            label3.Text = "Quantidade de arquivos ->";
            label3.Click += label3_Click;
            // 
            // mskTextBoxSeuNumero
            // 
            mskTextBoxSeuNumero.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mskTextBoxSeuNumero.Location = new Point(210, 44);
            mskTextBoxSeuNumero.Mask = "0000000000";
            mskTextBoxSeuNumero.Name = "mskTextBoxSeuNumero";
            mskTextBoxSeuNumero.RightToLeft = RightToLeft.No;
            mskTextBoxSeuNumero.Size = new Size(137, 32);
            mskTextBoxSeuNumero.TabIndex = 1;
            mskTextBoxSeuNumero.TextAlign = HorizontalAlignment.Right;
            mskTextBoxSeuNumero.MaskInputRejected += mskTextBoxSeuNumero_MaskInputRejected;
            // 
            // mskTextBoxLinhasArquivo
            // 
            mskTextBoxLinhasArquivo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mskTextBoxLinhasArquivo.Location = new Point(210, 78);
            mskTextBoxLinhasArquivo.Mask = "00000";
            mskTextBoxLinhasArquivo.Name = "mskTextBoxLinhasArquivo";
            mskTextBoxLinhasArquivo.RightToLeft = RightToLeft.No;
            mskTextBoxLinhasArquivo.Size = new Size(137, 32);
            mskTextBoxLinhasArquivo.TabIndex = 3;
            mskTextBoxLinhasArquivo.TextAlign = HorizontalAlignment.Right;
            // 
            // mskTextBoxQtdArquivos
            // 
            mskTextBoxQtdArquivos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mskTextBoxQtdArquivos.Location = new Point(867, 119);
            mskTextBoxQtdArquivos.Mask = "000";
            mskTextBoxQtdArquivos.Name = "mskTextBoxQtdArquivos";
            mskTextBoxQtdArquivos.RightToLeft = RightToLeft.No;
            mskTextBoxQtdArquivos.Size = new Size(113, 32);
            mskTextBoxQtdArquivos.TabIndex = 6;
            mskTextBoxQtdArquivos.TextAlign = HorizontalAlignment.Right;
            // 
            // mskTextBoxDataInclusao
            // 
            mskTextBoxDataInclusao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mskTextBoxDataInclusao.Location = new Point(867, 47);
            mskTextBoxDataInclusao.Mask = "00/00/0000";
            mskTextBoxDataInclusao.Name = "mskTextBoxDataInclusao";
            mskTextBoxDataInclusao.RightToLeft = RightToLeft.No;
            mskTextBoxDataInclusao.Size = new Size(113, 32);
            mskTextBoxDataInclusao.TabIndex = 2;
            mskTextBoxDataInclusao.TextAlign = HorizontalAlignment.Right;
            mskTextBoxDataInclusao.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(594, 51);
            label4.Name = "label4";
            label4.Size = new Size(267, 25);
            label4.TabIndex = 11;
            label4.Text = "Data de emissão (ddmmaa) ->";
            // 
            // mskTextBoxDataVencimento
            // 
            mskTextBoxDataVencimento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mskTextBoxDataVencimento.Location = new Point(867, 82);
            mskTextBoxDataVencimento.Mask = "00/00/0000";
            mskTextBoxDataVencimento.Name = "mskTextBoxDataVencimento";
            mskTextBoxDataVencimento.RightToLeft = RightToLeft.No;
            mskTextBoxDataVencimento.Size = new Size(113, 32);
            mskTextBoxDataVencimento.TabIndex = 4;
            mskTextBoxDataVencimento.TextAlign = HorizontalAlignment.Right;
            mskTextBoxDataVencimento.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(521, 90);
            label5.Name = "label5";
            label5.Size = new Size(340, 25);
            label5.TabIndex = 13;
            label5.Text = "Data Vencimento Boletos (ddmmaa) ->";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBoxEnviaSeuNum);
            groupBox1.Controls.Add(Leaute);
            groupBox1.Controls.Add(comboLeiaute);
            groupBox1.Controls.Add(textBoxDiretorioDestino);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(mskTextBoxLinhasArquivo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(mskTextBoxDataVencimento);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(mskTextBoxDataInclusao);
            groupBox1.Controls.Add(mskTextBoxSeuNumero);
            groupBox1.Controls.Add(mskTextBoxQtdArquivos);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(49, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1005, 232);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parâmetros de entrada";
            // 
            // checkBoxEnviaSeuNum
            // 
            checkBoxEnviaSeuNum.AutoSize = true;
            checkBoxEnviaSeuNum.ForeColor = Color.Red;
            checkBoxEnviaSeuNum.Location = new Point(352, 51);
            checkBoxEnviaSeuNum.Name = "checkBoxEnviaSeuNum";
            checkBoxEnviaSeuNum.Size = new Size(236, 29);
            checkBoxEnviaSeuNum.TabIndex = 19;
            checkBoxEnviaSeuNum.Text = "Não enviar Seu Número";
            checkBoxEnviaSeuNum.UseVisualStyleBackColor = true;
            checkBoxEnviaSeuNum.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // Leaute
            // 
            Leaute.AutoSize = true;
            Leaute.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Leaute.Location = new Point(84, 122);
            Leaute.Name = "Leaute";
            Leaute.Size = new Size(94, 25);
            Leaute.TabIndex = 18;
            Leaute.Text = "Layout ->";
            // 
            // comboLeiaute
            // 
            comboLeiaute.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboLeiaute.FormattingEnabled = true;
            comboLeiaute.Items.AddRange(new object[] { "Bradesco", "Itaú", "TotalBanco" });
            comboLeiaute.Location = new Point(210, 117);
            comboLeiaute.Name = "comboLeiaute";
            comboLeiaute.Size = new Size(137, 33);
            comboLeiaute.Sorted = true;
            comboLeiaute.TabIndex = 17;
            // 
            // textBoxDiretorioDestino
            // 
            textBoxDiretorioDestino.Location = new Point(269, 172);
            textBoxDiretorioDestino.Name = "textBoxDiretorioDestino";
            textBoxDiretorioDestino.Size = new Size(549, 32);
            textBoxDiretorioDestino.TabIndex = 7;
            textBoxDiretorioDestino.TextChanged += textBoxDiretorioDestino_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(25, 177);
            label10.Name = "label10";
            label10.Size = new Size(249, 25);
            label10.TabIndex = 16;
            label10.Text = "Diretório destino arquivo ->";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(mskTextBoxEmpresa);
            groupBox2.Controls.Add(labelCodCliente);
            groupBox2.Controls.Add(textBoxCodCliente);
            groupBox2.Controls.Add(labelCarteira);
            groupBox2.Controls.Add(mskTextBoxCarteira);
            groupBox2.Controls.Add(labelBcoCobrador);
            groupBox2.Controls.Add(mskBancoCobrador);
            groupBox2.Controls.Add(mskTextBoxNumDocCedente);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(mskTextBoxAgCedente);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(mskTextBoxContaCedente);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(mskTextBoxConvenio);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(49, 404);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1005, 197);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados do Cedente";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(666, 158);
            label14.Name = "label14";
            label14.Size = new Size(110, 25);
            label14.TabIndex = 18;
            label14.Text = "Empresa ->";
            // 
            // mskTextBoxEmpresa
            // 
            mskTextBoxEmpresa.Location = new Point(782, 155);
            mskTextBoxEmpresa.Mask = "00";
            mskTextBoxEmpresa.Name = "mskTextBoxEmpresa";
            mskTextBoxEmpresa.RightToLeft = RightToLeft.No;
            mskTextBoxEmpresa.Size = new Size(100, 32);
            mskTextBoxEmpresa.TabIndex = 17;
            mskTextBoxEmpresa.TextAlign = HorizontalAlignment.Right;
            mskTextBoxEmpresa.MaskInputRejected += mskTextBoxEmpresa_MaskInputRejected;
            // 
            // labelCodCliente
            // 
            labelCodCliente.AutoSize = true;
            labelCodCliente.Location = new Point(11, 32);
            labelCodCliente.Name = "labelCodCliente";
            labelCodCliente.Size = new Size(190, 25);
            labelCodCliente.TabIndex = 16;
            labelCodCliente.Text = "Código do Cliente ->";
            // 
            // textBoxCodCliente
            // 
            textBoxCodCliente.Location = new Point(200, 29);
            textBoxCodCliente.MaxLength = 8;
            textBoxCodCliente.Name = "textBoxCodCliente";
            textBoxCodCliente.Size = new Size(137, 32);
            textBoxCodCliente.TabIndex = 13;
            textBoxCodCliente.TextAlign = HorizontalAlignment.Right;
            textBoxCodCliente.TextChanged += textBoxCodCliente_TextChanged;
            // 
            // labelCarteira
            // 
            labelCarteira.AutoSize = true;
            labelCarteira.Location = new Point(671, 112);
            labelCarteira.Name = "labelCarteira";
            labelCarteira.Size = new Size(105, 25);
            labelCarteira.TabIndex = 15;
            labelCarteira.Text = "Carteira ->";
            // 
            // mskTextBoxCarteira
            // 
            mskTextBoxCarteira.Location = new Point(782, 105);
            mskTextBoxCarteira.Mask = "000";
            mskTextBoxCarteira.Name = "mskTextBoxCarteira";
            mskTextBoxCarteira.Size = new Size(100, 32);
            mskTextBoxCarteira.TabIndex = 13;
            mskTextBoxCarteira.TextAlign = HorizontalAlignment.Right;
            mskTextBoxCarteira.ValidatingType = typeof(int);
            // 
            // labelBcoCobrador
            // 
            labelBcoCobrador.AutoSize = true;
            labelBcoCobrador.Location = new Point(89, 112);
            labelBcoCobrador.Name = "labelBcoCobrador";
            labelBcoCobrador.Size = new Size(90, 25);
            labelBcoCobrador.TabIndex = 13;
            labelBcoCobrador.Text = "Banco ->";
            // 
            // mskBancoCobrador
            // 
            mskBancoCobrador.Location = new Point(200, 109);
            mskBancoCobrador.Mask = "000";
            mskBancoCobrador.Name = "mskBancoCobrador";
            mskBancoCobrador.Size = new Size(100, 32);
            mskBancoCobrador.TabIndex = 12;
            mskBancoCobrador.TextAlign = HorizontalAlignment.Right;
            mskBancoCobrador.ValidatingType = typeof(int);
            mskBancoCobrador.MaskInputRejected += mskBancoCobrador_MaskInputRejected;
            // 
            // mskTextBoxNumDocCedente
            // 
            mskTextBoxNumDocCedente.Location = new Point(782, 62);
            mskTextBoxNumDocCedente.Mask = "00000000000000";
            mskTextBoxNumDocCedente.Name = "mskTextBoxNumDocCedente";
            mskTextBoxNumDocCedente.RightToLeft = RightToLeft.No;
            mskTextBoxNumDocCedente.Size = new Size(154, 32);
            mskTextBoxNumDocCedente.TabIndex = 11;
            mskTextBoxNumDocCedente.TextAlign = HorizontalAlignment.Right;
            mskTextBoxNumDocCedente.MaskInputRejected += mskTextBoxNumDocCedente_MaskInputRejected;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(556, 69);
            label11.Name = "label11";
            label11.Size = new Size(220, 25);
            label11.TabIndex = 9;
            label11.Text = "Número Doc Cedente ->";
            label11.Click += label11_Click;
            // 
            // mskTextBoxAgCedente
            // 
            mskTextBoxAgCedente.Location = new Point(200, 155);
            mskTextBoxAgCedente.Mask = "00";
            mskTextBoxAgCedente.Name = "mskTextBoxAgCedente";
            mskTextBoxAgCedente.RightToLeft = RightToLeft.No;
            mskTextBoxAgCedente.Size = new Size(100, 32);
            mskTextBoxAgCedente.TabIndex = 14;
            mskTextBoxAgCedente.TextAlign = HorizontalAlignment.Right;
            mskTextBoxAgCedente.MaskInputRejected += mskTextBoxAgCedente_MaskInputRejected;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 158);
            label9.Name = "label9";
            label9.Size = new Size(181, 25);
            label9.TabIndex = 7;
            label9.Text = "Agência Cedente ->";
            // 
            // mskTextBoxContaCedente
            // 
            mskTextBoxContaCedente.Location = new Point(200, 71);
            mskTextBoxContaCedente.Mask = "0000000000";
            mskTextBoxContaCedente.Name = "mskTextBoxContaCedente";
            mskTextBoxContaCedente.RightToLeft = RightToLeft.No;
            mskTextBoxContaCedente.Size = new Size(137, 32);
            mskTextBoxContaCedente.TabIndex = 10;
            mskTextBoxContaCedente.TextAlign = HorizontalAlignment.Right;
            mskTextBoxContaCedente.MaskInputRejected += mskTextBoxContaCedente_MaskInputRejected;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 74);
            label8.Name = "label8";
            label8.Size = new Size(190, 25);
            label8.TabIndex = 5;
            label8.Text = "Conta do Cedente ->";
            // 
            // mskTextBoxConvenio
            // 
            mskTextBoxConvenio.Location = new Point(782, 25);
            mskTextBoxConvenio.Mask = "000000000000";
            mskTextBoxConvenio.Name = "mskTextBoxConvenio";
            mskTextBoxConvenio.RightToLeft = RightToLeft.No;
            mskTextBoxConvenio.Size = new Size(154, 32);
            mskTextBoxConvenio.TabIndex = 9;
            mskTextBoxConvenio.TextAlign = HorizontalAlignment.Right;
            mskTextBoxConvenio.MaskInputRejected += mskTextBoxConvenio_MaskInputRejected;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(518, 28);
            label7.Name = "label7";
            label7.Size = new Size(258, 25);
            label7.TabIndex = 3;
            label7.Text = "Identificação do Convênio ->";
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Red;
            btnSair.FlatStyle = FlatStyle.Popup;
            btnSair.ForeColor = SystemColors.ControlLightLight;
            btnSair.Location = new Point(917, 616);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(137, 49);
            btnSair.TabIndex = 60;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // comboConvenios
            // 
            comboConvenios.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboConvenios.FormattingEnabled = true;
            comboConvenios.Location = new Point(288, 55);
            comboConvenios.Name = "comboConvenios";
            comboConvenios.Size = new Size(622, 33);
            comboConvenios.TabIndex = 18;
            comboConvenios.SelectedIndexChanged += comboConvenios_SelectedIndexChanged;
            // 
            // labelConvenios
            // 
            labelConvenios.AutoSize = true;
            labelConvenios.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelConvenios.Location = new Point(49, 58);
            labelConvenios.Name = "labelConvenios";
            labelConvenios.Size = new Size(232, 25);
            labelConvenios.TabIndex = 19;
            labelConvenios.Text = "Convênios cadastrados ->";
            // 
            // bnBuscarDados
            // 
            bnBuscarDados.FlatStyle = FlatStyle.Popup;
            bnBuscarDados.Location = new Point(917, 48);
            bnBuscarDados.Name = "bnBuscarDados";
            bnBuscarDados.Size = new Size(137, 49);
            bnBuscarDados.TabIndex = 20;
            bnBuscarDados.Text = "Buscar Dados";
            bnBuscarDados.UseVisualStyleBackColor = true;
            bnBuscarDados.Click += bnBuscarDados_Click;
            // 
            // Soap
            // 
            Soap.BackColor = Color.LightGreen;
            Soap.FlatStyle = FlatStyle.Popup;
            Soap.Location = new Point(207, 616);
            Soap.Name = "Soap";
            Soap.Size = new Size(137, 49);
            Soap.TabIndex = 21;
            Soap.Text = "Criar lote via Soap";
            Soap.UseVisualStyleBackColor = false;
            Soap.Click += Soap_Click;
            // 
            // btnConfigServerWs
            // 
            btnConfigServerWs.FlatStyle = FlatStyle.Popup;
            btnConfigServerWs.Location = new Point(371, 616);
            btnConfigServerWs.Name = "btnConfigServerWs";
            btnConfigServerWs.Size = new Size(137, 49);
            btnConfigServerWs.TabIndex = 23;
            btnConfigServerWs.Text = "Configurações Servidor WS";
            btnConfigServerWs.UseVisualStyleBackColor = true;
            btnConfigServerWs.Click += btnConfigServerWs_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(LabelSdBloq);
            groupBox3.Controls.Add(txtBxSaldoDisponivel);
            groupBox3.Controls.Add(txtBoxSaldoBloqJud);
            groupBox3.Controls.Add(txtBoxSaldoBloq);
            groupBox3.Location = new Point(1090, 133);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(354, 196);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Saldos";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 116);
            label12.Name = "label12";
            label12.Size = new Size(121, 20);
            label12.TabIndex = 5;
            label12.Text = "Saldo Disponível";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 80);
            label6.Name = "label6";
            label6.Size = new Size(151, 20);
            label6.TabIndex = 4;
            label6.Text = "Saldo Bloq. Jud/ADM";
            // 
            // LabelSdBloq
            // 
            LabelSdBloq.AutoSize = true;
            LabelSdBloq.Location = new Point(18, 43);
            LabelSdBloq.Name = "LabelSdBloq";
            LabelSdBloq.Size = new Size(124, 20);
            LabelSdBloq.TabIndex = 3;
            LabelSdBloq.Text = "Saldo Bloqueado";
            // 
            // txtBxSaldoDisponivel
            // 
            txtBxSaldoDisponivel.ForeColor = SystemColors.WindowText;
            txtBxSaldoDisponivel.Location = new Point(175, 113);
            txtBxSaldoDisponivel.MaxLength = 20;
            txtBxSaldoDisponivel.Name = "txtBxSaldoDisponivel";
            txtBxSaldoDisponivel.ReadOnly = true;
            txtBxSaldoDisponivel.Size = new Size(127, 27);
            txtBxSaldoDisponivel.TabIndex = 2;
            txtBxSaldoDisponivel.TextChanged += txtBxSaldoDisponivel_TextChanged;
            // 
            // txtBoxSaldoBloqJud
            // 
            txtBoxSaldoBloqJud.Location = new Point(175, 77);
            txtBoxSaldoBloqJud.MaxLength = 20;
            txtBoxSaldoBloqJud.Name = "txtBoxSaldoBloqJud";
            txtBoxSaldoBloqJud.ReadOnly = true;
            txtBoxSaldoBloqJud.Size = new Size(127, 27);
            txtBoxSaldoBloqJud.TabIndex = 1;
            txtBoxSaldoBloqJud.TextChanged += txtBoxSaldoBloqJud_TextChanged;
            // 
            // txtBoxSaldoBloq
            // 
            txtBoxSaldoBloq.Location = new Point(175, 40);
            txtBoxSaldoBloq.MaxLength = 20;
            txtBoxSaldoBloq.Name = "txtBoxSaldoBloq";
            txtBoxSaldoBloq.ReadOnly = true;
            txtBoxSaldoBloq.Size = new Size(127, 27);
            txtBoxSaldoBloq.TabIndex = 0;
            txtBoxSaldoBloq.TextChanged += txtBoxSaldoBloq_TextChanged;
            // 
            // dataGridViewExtrato
            // 
            dataGridViewExtrato.AllowUserToAddRows = false;
            dataGridViewExtrato.AllowUserToDeleteRows = false;
            dataGridViewExtrato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExtrato.Columns.AddRange(new DataGridViewColumn[] { dtLanColumn, vlrLancadoColumn, vlrSaldoColumn, historicoColumn });
            dataGridViewExtrato.Location = new Point(18, 22);
            dataGridViewExtrato.Name = "dataGridViewExtrato";
            dataGridViewExtrato.ReadOnly = true;
            dataGridViewExtrato.RowHeadersWidth = 51;
            dataGridViewExtrato.RowTemplate.Height = 25;
            dataGridViewExtrato.Size = new Size(682, 261);
            dataGridViewExtrato.TabIndex = 26;
            dataGridViewExtrato.CellContentClick += dataGridViewExtrato_CellContentClick;
            // 
            // dtLanColumn
            // 
            dtLanColumn.HeaderText = "Data Lançamento";
            dtLanColumn.MaxInputLength = 20;
            dtLanColumn.MinimumWidth = 6;
            dtLanColumn.Name = "dtLanColumn";
            dtLanColumn.ReadOnly = true;
            dtLanColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            dtLanColumn.Width = 125;
            // 
            // vlrLancadoColumn
            // 
            vlrLancadoColumn.HeaderText = "Valor Lançado";
            vlrLancadoColumn.MaxInputLength = 20;
            vlrLancadoColumn.MinimumWidth = 6;
            vlrLancadoColumn.Name = "vlrLancadoColumn";
            vlrLancadoColumn.ReadOnly = true;
            vlrLancadoColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            vlrLancadoColumn.Width = 125;
            // 
            // vlrSaldoColumn
            // 
            vlrSaldoColumn.HeaderText = "Saldo";
            vlrSaldoColumn.MaxInputLength = 20;
            vlrSaldoColumn.MinimumWidth = 6;
            vlrSaldoColumn.Name = "vlrSaldoColumn";
            vlrSaldoColumn.ReadOnly = true;
            vlrSaldoColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            vlrSaldoColumn.Width = 150;
            // 
            // historicoColumn
            // 
            historicoColumn.HeaderText = "Histórico";
            historicoColumn.MaxInputLength = 100;
            historicoColumn.MinimumWidth = 6;
            historicoColumn.Name = "historicoColumn";
            historicoColumn.ReadOnly = true;
            historicoColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            historicoColumn.Width = 225;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewExtrato);
            groupBox4.Location = new Point(1090, 345);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(721, 306);
            groupBox4.TabIndex = 27;
            groupBox4.TabStop = false;
            groupBox4.Text = "Extrato últimos 7 dias";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(linkLabelHistorico);
            groupBox5.Controls.Add(btnLancarValor);
            groupBox5.Controls.Add(textBoxValorLancado);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(label15);
            groupBox5.Controls.Add(textBoxNumDoc);
            groupBox5.Controls.Add(textBoxHistorico);
            groupBox5.Location = new Point(1463, 133);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(348, 196);
            groupBox5.TabIndex = 28;
            groupBox5.TabStop = false;
            groupBox5.Text = "Lançar valor em conta";
            // 
            // linkLabelHistorico
            // 
            linkLabelHistorico.AutoSize = true;
            linkLabelHistorico.Location = new Point(18, 80);
            linkLabelHistorico.Name = "linkLabelHistorico";
            linkLabelHistorico.Size = new Size(69, 20);
            linkLabelHistorico.TabIndex = 27;
            linkLabelHistorico.TabStop = true;
            linkLabelHistorico.Text = "Histórico";
            linkLabelHistorico.LinkClicked += linkLabelHistorico_LinkClicked;
            // 
            // btnLancarValor
            // 
            btnLancarValor.BackColor = Color.LightGreen;
            btnLancarValor.FlatStyle = FlatStyle.Popup;
            btnLancarValor.Location = new Point(203, 160);
            btnLancarValor.Name = "btnLancarValor";
            btnLancarValor.Size = new Size(80, 30);
            btnLancarValor.TabIndex = 26;
            btnLancarValor.Text = "Lançar";
            btnLancarValor.UseVisualStyleBackColor = false;
            btnLancarValor.Click += btnLancarValor_Click;
            // 
            // textBoxValorLancado
            // 
            textBoxValorLancado.Location = new Point(183, 43);
            textBoxValorLancado.MaxLength = 20;
            textBoxValorLancado.Name = "textBoxValorLancado";
            textBoxValorLancado.Size = new Size(127, 27);
            textBoxValorLancado.TabIndex = 23;
            textBoxValorLancado.TextChanged += textBoxValorLancado_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 116);
            label13.Name = "label13";
            label13.Size = new Size(126, 20);
            label13.TabIndex = 5;
            label13.Text = "Num. Documento";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(18, 43);
            label15.Name = "label15";
            label15.Size = new Size(150, 20);
            label15.TabIndex = 3;
            label15.Text = "Valor do Lançamento";
            // 
            // textBoxNumDoc
            // 
            textBoxNumDoc.ForeColor = SystemColors.WindowText;
            textBoxNumDoc.Location = new Point(183, 112);
            textBoxNumDoc.MaxLength = 20;
            textBoxNumDoc.Name = "textBoxNumDoc";
            textBoxNumDoc.Size = new Size(127, 27);
            textBoxNumDoc.TabIndex = 25;
            // 
            // textBoxHistorico
            // 
            textBoxHistorico.Location = new Point(183, 76);
            textBoxHistorico.MaxLength = 4;
            textBoxHistorico.Name = "textBoxHistorico";
            textBoxHistorico.Size = new Size(127, 27);
            textBoxHistorico.TabIndex = 24;
            // 
            // btnConfigModalidade
            // 
            btnConfigModalidade.FlatStyle = FlatStyle.Popup;
            btnConfigModalidade.Location = new Point(531, 616);
            btnConfigModalidade.Name = "btnConfigModalidade";
            btnConfigModalidade.Size = new Size(137, 49);
            btnConfigModalidade.TabIndex = 24;
            btnConfigModalidade.Text = "Configurações Modalidade Cobrança";
            btnConfigModalidade.UseVisualStyleBackColor = true;
            btnConfigModalidade.Click += btnConfigModalidade_Click;
            // 
            // btnCliente
            // 
            btnCliente.FlatStyle = FlatStyle.Popup;
            btnCliente.Location = new Point(688, 616);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(137, 49);
            btnCliente.TabIndex = 25;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoScroll = true;
            ClientSize = new Size(1839, 709);
            Controls.Add(btnCliente);
            Controls.Add(btnConfigModalidade);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(btnConfigServerWs);
            Controls.Add(Soap);
            Controls.Add(bnBuscarDados);
            Controls.Add(labelConvenios);
            Controls.Add(comboConvenios);
            Controls.Add(btnSair);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnGerarArquivo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Gerador de Remessa Cliente ";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExtrato).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button Soap;
        private TextBox textBoxCodCliente;
        private Label labelCodCliente;
        private Button btnConfigServerWs;

        private GroupBox groupBox3;
        private TextBox txtBoxSaldoBloq;
        private TextBox txtBxSaldoDisponivel;
        private TextBox txtBoxSaldoBloqJud;
        private Label label12;
        private Label label6;
        private Label LabelSdBloq;
        private DataGridView dataGridViewExtrato;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label13;
        private Label label15;
        private TextBox textBoxNumDoc;
        private TextBox textBoxHistorico;
        private TextBox textBoxValorLancado;
        private Button btnLancarValor;
        private LinkLabel linkLabelHistorico;
        private Button btnConfigModalidade;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridViewTextBoxColumn dtLanColumn;
        private DataGridViewTextBoxColumn vlrLancadoColumn;
        private DataGridViewTextBoxColumn vlrSaldoColumn;
        private DataGridViewTextBoxColumn historicoColumn;
        private Button btnCliente;
        private Label label14;
        private MaskedTextBox mskTextBoxEmpresa;
    }
}