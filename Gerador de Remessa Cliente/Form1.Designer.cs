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
            btnTesteTelaBord = new Button();
<<<<<<< HEAD
            groupBox3 = new GroupBox();
            label12 = new Label();
            label6 = new Label();
            LabelSdBloq = new Label();
            txtBxSaldoDisponivel = new TextBox();
            txtBoxSaldoBloqJud = new TextBox();
            txtBoxSaldoBloq = new TextBox();
=======
>>>>>>> 08f6633fea46c002b740d62a388b6d698d443675
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnGerarArquivo
            // 
            btnGerarArquivo.BackColor = Color.DodgerBlue;
            btnGerarArquivo.FlatStyle = FlatStyle.Popup;
            btnGerarArquivo.Location = new Point(103, 853);
            btnGerarArquivo.Margin = new Padding(3, 4, 3, 4);
            btnGerarArquivo.Name = "btnGerarArquivo";
            btnGerarArquivo.Size = new Size(157, 65);
            btnGerarArquivo.TabIndex = 20;
            btnGerarArquivo.Text = "Gerar Arquivo CNAB";
            btnGerarArquivo.UseVisualStyleBackColor = false;
            btnGerarArquivo.Click += btnGerarArquivo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 69);
            label1.Name = "label1";
            label1.Size = new Size(198, 25);
            label1.TabIndex = 2;
            label1.Text = "Seu Número inicial ->";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 113);
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
<<<<<<< HEAD
            label3.Location = new Point(698, 165);
=======
            label3.Location = new Point(611, 124);
>>>>>>> 08f6633fea46c002b740d62a388b6d698d443675
            label3.Name = "label3";
            label3.Size = new Size(240, 25);
            label3.TabIndex = 6;
            label3.Text = "Quantidade de arquivos ->";
            label3.Click += label3_Click;
            // 
            // mskTextBoxSeuNumero
            // 
            mskTextBoxSeuNumero.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mskTextBoxSeuNumero.Location = new Point(211, 63);
            mskTextBoxSeuNumero.Margin = new Padding(3, 4, 3, 4);
            mskTextBoxSeuNumero.Mask = "0000000000";
            mskTextBoxSeuNumero.Name = "mskTextBoxSeuNumero";
            mskTextBoxSeuNumero.RightToLeft = RightToLeft.No;
            mskTextBoxSeuNumero.Size = new Size(156, 32);
            mskTextBoxSeuNumero.TabIndex = 1;
            mskTextBoxSeuNumero.TextAlign = HorizontalAlignment.Right;
            mskTextBoxSeuNumero.MaskInputRejected += mskTextBoxSeuNumero_MaskInputRejected;
            // 
            // mskTextBoxLinhasArquivo
            // 
            mskTextBoxLinhasArquivo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            mskTextBoxLinhasArquivo.Location = new Point(211, 108);
            mskTextBoxLinhasArquivo.Margin = new Padding(3, 4, 3, 4);
            mskTextBoxLinhasArquivo.Mask = "00000";
            mskTextBoxLinhasArquivo.Name = "mskTextBoxLinhasArquivo";
            mskTextBoxLinhasArquivo.RightToLeft = RightToLeft.No;
            mskTextBoxLinhasArquivo.Size = new Size(156, 32);
            mskTextBoxLinhasArquivo.TabIndex = 3;
            mskTextBoxLinhasArquivo.TextAlign = HorizontalAlignment.Right;
            // 
            // mskTextBoxQtdArquivos
            // 
            mskTextBoxQtdArquivos.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
<<<<<<< HEAD
            mskTextBoxQtdArquivos.Location = new Point(947, 161);
            mskTextBoxQtdArquivos.Margin = new Padding(3, 4, 3, 4);
=======
            mskTextBoxQtdArquivos.Location = new Point(829, 121);
>>>>>>> 08f6633fea46c002b740d62a388b6d698d443675
            mskTextBoxQtdArquivos.Mask = "00000";
            mskTextBoxQtdArquivos.Name = "mskTextBoxQtdArquivos";
            mskTextBoxQtdArquivos.RightToLeft = RightToLeft.No;
            mskTextBoxQtdArquivos.Size = new Size(129, 32);
            mskTextBoxQtdArquivos.TabIndex = 6;
            mskTextBoxQtdArquivos.TextAlign = HorizontalAlignment.Right;
            mskTextBoxQtdArquivos.ValidatingType = typeof(int);
            // 
            // mskTextBoxDataInclusao
            // 
            mskTextBoxDataInclusao.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
<<<<<<< HEAD
            mskTextBoxDataInclusao.Location = new Point(947, 61);
            mskTextBoxDataInclusao.Margin = new Padding(3, 4, 3, 4);
=======
            mskTextBoxDataInclusao.Location = new Point(829, 46);
>>>>>>> 08f6633fea46c002b740d62a388b6d698d443675
            mskTextBoxDataInclusao.Mask = "00/00/0000";
            mskTextBoxDataInclusao.Name = "mskTextBoxDataInclusao";
            mskTextBoxDataInclusao.RightToLeft = RightToLeft.No;
            mskTextBoxDataInclusao.Size = new Size(129, 32);
            mskTextBoxDataInclusao.TabIndex = 2;
            mskTextBoxDataInclusao.TextAlign = HorizontalAlignment.Right;
            mskTextBoxDataInclusao.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
<<<<<<< HEAD
            label4.Location = new Point(671, 64);
=======
            label4.Location = new Point(587, 48);
>>>>>>> 08f6633fea46c002b740d62a388b6d698d443675
            label4.Name = "label4";
            label4.Size = new Size(267, 25);
            label4.TabIndex = 11;
            label4.Text = "Data de emissão (ddmmaa) ->";
            // 
            // mskTextBoxDataVencimento
            // 
            mskTextBoxDataVencimento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
<<<<<<< HEAD
            mskTextBoxDataVencimento.Location = new Point(947, 112);
            mskTextBoxDataVencimento.Margin = new Padding(3, 4, 3, 4);
=======
            mskTextBoxDataVencimento.Location = new Point(829, 84);
>>>>>>> 08f6633fea46c002b740d62a388b6d698d443675
            mskTextBoxDataVencimento.Mask = "00/00/0000";
            mskTextBoxDataVencimento.Name = "mskTextBoxDataVencimento";
            mskTextBoxDataVencimento.RightToLeft = RightToLeft.No;
            mskTextBoxDataVencimento.Size = new Size(129, 32);
            mskTextBoxDataVencimento.TabIndex = 4;
            mskTextBoxDataVencimento.TextAlign = HorizontalAlignment.Right;
            mskTextBoxDataVencimento.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
<<<<<<< HEAD
            label5.Location = new Point(601, 117);
=======
            label5.Location = new Point(526, 88);
>>>>>>> 08f6633fea46c002b740d62a388b6d698d443675
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
            groupBox1.Location = new Point(103, 159);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
<<<<<<< HEAD
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1201, 351);
=======
            groupBox1.Size = new Size(1051, 263);
>>>>>>> 08f6633fea46c002b740d62a388b6d698d443675
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parâmetros de entrada";
            // 
            // checkBoxEnviaSeuNum
            // 
            checkBoxEnviaSeuNum.AutoSize = true;
            checkBoxEnviaSeuNum.ForeColor = Color.Red;
            checkBoxEnviaSeuNum.Location = new Point(375, 68);
            checkBoxEnviaSeuNum.Margin = new Padding(3, 4, 3, 4);
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
            Leaute.Location = new Point(105, 164);
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
            comboLeiaute.Location = new Point(211, 157);
            comboLeiaute.Margin = new Padding(3, 4, 3, 4);
            comboLeiaute.Name = "comboLeiaute";
            comboLeiaute.Size = new Size(156, 33);
            comboLeiaute.Sorted = true;
            comboLeiaute.TabIndex = 17;
            // 
            // textBoxDiretorioDestino
            // 
            textBoxDiretorioDestino.Location = new Point(265, 271);
            textBoxDiretorioDestino.Margin = new Padding(3, 4, 3, 4);
            textBoxDiretorioDestino.Name = "textBoxDiretorioDestino";
            textBoxDiretorioDestino.Size = new Size(627, 32);
            textBoxDiretorioDestino.TabIndex = 7;
            textBoxDiretorioDestino.TextChanged += textBoxDiretorioDestino_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(23, 275);
            label10.Name = "label10";
            label10.Size = new Size(249, 25);
            label10.TabIndex = 16;
            label10.Text = "Diretório destino arquivo ->";
            // 
            // groupBox2
            // 
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
            groupBox2.Location = new Point(103, 560);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
<<<<<<< HEAD
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1201, 253);
=======
            groupBox2.Size = new Size(1051, 190);
>>>>>>> 08f6633fea46c002b740d62a388b6d698d443675
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados do Cedente";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // labelCodCliente
            // 
            labelCodCliente.AutoSize = true;
            labelCodCliente.Location = new Point(13, 43);
            labelCodCliente.Name = "labelCodCliente";
            labelCodCliente.Size = new Size(190, 25);
            labelCodCliente.TabIndex = 16;
            labelCodCliente.Text = "Código do Cliente ->";
            // 
            // textBoxCodCliente
            // 
            textBoxCodCliente.Location = new Point(208, 40);
            textBoxCodCliente.Margin = new Padding(3, 4, 3, 4);
            textBoxCodCliente.MaxLength = 8;
            textBoxCodCliente.Name = "textBoxCodCliente";
            textBoxCodCliente.Size = new Size(114, 32);
            textBoxCodCliente.TabIndex = 13;
            textBoxCodCliente.TextAlign = HorizontalAlignment.Right;
            textBoxCodCliente.TextChanged += textBoxCodCliente_TextChanged;
            // 
            // labelCarteira
            // 
            labelCarteira.AutoSize = true;
<<<<<<< HEAD
            labelCarteira.Location = new Point(825, 151);
=======
            labelCarteira.Location = new Point(722, 113);
>>>>>>> 08f6633fea46c002b740d62a388b6d698d443675
            labelCarteira.Name = "labelCarteira";
            labelCarteira.Size = new Size(105, 25);
            labelCarteira.TabIndex = 15;
            labelCarteira.Text = "Carteira ->";
            // 
            // mskTextBoxCarteira
            // 
<<<<<<< HEAD
            mskTextBoxCarteira.Location = new Point(938, 151);
            mskTextBoxCarteira.Margin = new Padding(3, 4, 3, 4);
=======
            mskTextBoxCarteira.Location = new Point(821, 113);
>>>>>>> 08f6633fea46c002b740d62a388b6d698d443675
            mskTextBoxCarteira.Mask = "000";
            mskTextBoxCarteira.Name = "mskTextBoxCarteira";
            mskTextBoxCarteira.Size = new Size(114, 32);
            mskTextBoxCarteira.TabIndex = 13;
            mskTextBoxCarteira.TextAlign = HorizontalAlignment.Right;
            mskTextBoxCarteira.ValidatingType = typeof(int);
            // 
            // labelBcoCobrador
            // 
            labelBcoCobrador.AutoSize = true;
            labelBcoCobrador.Location = new Point(111, 151);
            labelBcoCobrador.Name = "labelBcoCobrador";
            labelBcoCobrador.Size = new Size(90, 25);
            labelBcoCobrador.TabIndex = 13;
            labelBcoCobrador.Text = "Banco ->";
            // 
            // mskBancoCobrador
            // 
            mskBancoCobrador.Location = new Point(208, 147);
            mskBancoCobrador.Margin = new Padding(3, 4, 3, 4);
            mskBancoCobrador.Mask = "000";
            mskBancoCobrador.Name = "mskBancoCobrador";
            mskBancoCobrador.Size = new Size(114, 32);
            mskBancoCobrador.TabIndex = 12;
            mskBancoCobrador.TextAlign = HorizontalAlignment.Right;
            mskBancoCobrador.ValidatingType = typeof(int);
            mskBancoCobrador.MaskInputRejected += mskBancoCobrador_MaskInputRejected;
            // 
            // mskTextBoxNumDocCedente
            // 
<<<<<<< HEAD
            mskTextBoxNumDocCedente.Location = new Point(938, 91);
            mskTextBoxNumDocCedente.Margin = new Padding(3, 4, 3, 4);
=======
            mskTextBoxNumDocCedente.Location = new Point(821, 68);
>>>>>>> 08f6633fea46c002b740d62a388b6d698d443675
            mskTextBoxNumDocCedente.Mask = "00000000000000";
            mskTextBoxNumDocCedente.Name = "mskTextBoxNumDocCedente";
            mskTextBoxNumDocCedente.RightToLeft = RightToLeft.No;
            mskTextBoxNumDocCedente.Size = new Size(175, 32);
            mskTextBoxNumDocCedente.TabIndex = 11;
            mskTextBoxNumDocCedente.TextAlign = HorizontalAlignment.Right;
            mskTextBoxNumDocCedente.MaskInputRejected += mskTextBoxNumDocCedente_MaskInputRejected;
            // 
            // label11
            // 
            label11.AutoSize = true;
<<<<<<< HEAD
            label11.Location = new Point(713, 95);
=======
            label11.Location = new Point(624, 71);
>>>>>>> 08f6633fea46c002b740d62a388b6d698d443675
            label11.Name = "label11";
            label11.Size = new Size(220, 25);
            label11.TabIndex = 9;
            label11.Text = "Número Doc Cedente ->";
            label11.Click += label11_Click;
            // 
            // mskTextBoxAgCedente
            // 
            mskTextBoxAgCedente.Location = new Point(208, 200);
            mskTextBoxAgCedente.Margin = new Padding(3, 4, 3, 4);
            mskTextBoxAgCedente.Mask = "00";
            mskTextBoxAgCedente.Name = "mskTextBoxAgCedente";
            mskTextBoxAgCedente.RightToLeft = RightToLeft.No;
            mskTextBoxAgCedente.Size = new Size(114, 32);
            mskTextBoxAgCedente.TabIndex = 14;
            mskTextBoxAgCedente.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 203);
            label9.Name = "label9";
            label9.Size = new Size(181, 25);
            label9.TabIndex = 7;
            label9.Text = "Agência Cedente ->";
            // 
            // mskTextBoxContaCedente
            // 
            mskTextBoxContaCedente.Location = new Point(208, 95);
            mskTextBoxContaCedente.Margin = new Padding(3, 4, 3, 4);
            mskTextBoxContaCedente.Mask = "0000000000";
            mskTextBoxContaCedente.Name = "mskTextBoxContaCedente";
            mskTextBoxContaCedente.RightToLeft = RightToLeft.No;
            mskTextBoxContaCedente.Size = new Size(114, 32);
            mskTextBoxContaCedente.TabIndex = 10;
            mskTextBoxContaCedente.TextAlign = HorizontalAlignment.Right;
            mskTextBoxContaCedente.MaskInputRejected += mskTextBoxContaCedente_MaskInputRejected;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 99);
            label8.Name = "label8";
            label8.Size = new Size(190, 25);
            label8.TabIndex = 5;
            label8.Text = "Conta do Cedente ->";
            // 
            // mskTextBoxConvenio
            // 
<<<<<<< HEAD
            mskTextBoxConvenio.Location = new Point(938, 44);
            mskTextBoxConvenio.Margin = new Padding(3, 4, 3, 4);
=======
            mskTextBoxConvenio.Location = new Point(821, 33);
>>>>>>> 08f6633fea46c002b740d62a388b6d698d443675
            mskTextBoxConvenio.Mask = "000000000000";
            mskTextBoxConvenio.Name = "mskTextBoxConvenio";
            mskTextBoxConvenio.RightToLeft = RightToLeft.No;
            mskTextBoxConvenio.Size = new Size(175, 32);
            mskTextBoxConvenio.TabIndex = 9;
            mskTextBoxConvenio.TextAlign = HorizontalAlignment.Right;
            mskTextBoxConvenio.MaskInputRejected += mskTextBoxConvenio_MaskInputRejected;
            // 
            // label7
            // 
            label7.AutoSize = true;
<<<<<<< HEAD
            label7.Location = new Point(677, 49);
=======
            label7.Location = new Point(592, 37);
>>>>>>> 08f6633fea46c002b740d62a388b6d698d443675
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
            btnSair.Location = new Point(949, 853);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(157, 65);
            btnSair.TabIndex = 22;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // comboConvenios
            // 
            comboConvenios.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboConvenios.FormattingEnabled = true;
            comboConvenios.Location = new Point(360, 83);
            comboConvenios.Margin = new Padding(3, 4, 3, 4);
            comboConvenios.Name = "comboConvenios";
            comboConvenios.Size = new Size(557, 33);
            comboConvenios.TabIndex = 18;
            comboConvenios.SelectedIndexChanged += comboConvenios_SelectedIndexChanged;
            // 
            // labelConvenios
            // 
            labelConvenios.AutoSize = true;
            labelConvenios.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelConvenios.Location = new Point(101, 83);
            labelConvenios.Name = "labelConvenios";
            labelConvenios.Size = new Size(232, 25);
            labelConvenios.TabIndex = 19;
            labelConvenios.Text = "Convênios cadastrados ->";
            // 
            // bnBuscarDados
            // 
            bnBuscarDados.FlatStyle = FlatStyle.Popup;
            bnBuscarDados.Location = new Point(946, 65);
            bnBuscarDados.Margin = new Padding(3, 4, 3, 4);
            bnBuscarDados.Name = "bnBuscarDados";
            bnBuscarDados.Size = new Size(157, 65);
            bnBuscarDados.TabIndex = 20;
            bnBuscarDados.Text = "Buscar Dados";
            bnBuscarDados.UseVisualStyleBackColor = true;
            bnBuscarDados.Click += bnBuscarDados_Click;
            // 
            // Soap
            // 
            Soap.BackColor = Color.LightGreen;
            Soap.FlatStyle = FlatStyle.Popup;
            Soap.Location = new Point(290, 853);
            Soap.Margin = new Padding(3, 4, 3, 4);
            Soap.Name = "Soap";
            Soap.Size = new Size(157, 65);
            Soap.TabIndex = 21;
            Soap.Text = "Criar lote via Soap";
            Soap.UseVisualStyleBackColor = false;
            Soap.Click += Soap_Click;
            // 
            // btnConfigServerWs
            // 
            btnConfigServerWs.FlatStyle = FlatStyle.Popup;
            btnConfigServerWs.Location = new Point(478, 853);
            btnConfigServerWs.Margin = new Padding(3, 4, 3, 4);
            btnConfigServerWs.Name = "btnConfigServerWs";
            btnConfigServerWs.Size = new Size(157, 65);
            btnConfigServerWs.TabIndex = 23;
            btnConfigServerWs.Text = "Configurações Servidor WS";
            btnConfigServerWs.UseVisualStyleBackColor = true;
            btnConfigServerWs.Click += btnConfigServerWs_Click;
            // 
            // btnTesteTelaBord
            // 
            btnTesteTelaBord.Enabled = false;
<<<<<<< HEAD
            btnTesteTelaBord.Location = new Point(696, 872);
            btnTesteTelaBord.Margin = new Padding(3, 4, 3, 4);
            btnTesteTelaBord.Name = "btnTesteTelaBord";
            btnTesteTelaBord.Size = new Size(86, 47);
=======
            btnTesteTelaBord.Location = new Point(609, 654);
            btnTesteTelaBord.Name = "btnTesteTelaBord";
            btnTesteTelaBord.Size = new Size(75, 35);
>>>>>>> 08f6633fea46c002b740d62a388b6d698d443675
            btnTesteTelaBord.TabIndex = 24;
            btnTesteTelaBord.Text = "Teste tela Bord";
            btnTesteTelaBord.UseVisualStyleBackColor = true;
            btnTesteTelaBord.Visible = false;
            btnTesteTelaBord.Click += btnTesteTelaBord_Click;
            // 
<<<<<<< HEAD
            // groupBox3
            // 
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(LabelSdBloq);
            groupBox3.Controls.Add(txtBxSaldoDisponivel);
            groupBox3.Controls.Add(txtBoxSaldoBloqJud);
            groupBox3.Controls.Add(txtBoxSaldoBloq);
            groupBox3.Location = new Point(1345, 176);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(342, 261);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Saldos";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 155);
            label12.Name = "label12";
            label12.Size = new Size(121, 20);
            label12.TabIndex = 5;
            label12.Text = "Saldo Disponível";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 107);
            label6.Name = "label6";
            label6.Size = new Size(151, 20);
            label6.TabIndex = 4;
            label6.Text = "Saldo Bloq. Jud/ADM";
            // 
            // LabelSdBloq
            // 
            LabelSdBloq.AutoSize = true;
            LabelSdBloq.Location = new Point(21, 57);
            LabelSdBloq.Name = "LabelSdBloq";
            LabelSdBloq.Size = new Size(124, 20);
            LabelSdBloq.TabIndex = 3;
            LabelSdBloq.Text = "Saldo Bloqueado";
            // 
            // txtBxSaldoDisponivel
            // 
            txtBxSaldoDisponivel.Location = new Point(178, 148);
            txtBxSaldoDisponivel.Margin = new Padding(3, 4, 3, 4);
            txtBxSaldoDisponivel.MaxLength = 20;
            txtBxSaldoDisponivel.Name = "txtBxSaldoDisponivel";
            txtBxSaldoDisponivel.ReadOnly = true;
            txtBxSaldoDisponivel.Size = new Size(145, 27);
            txtBxSaldoDisponivel.TabIndex = 2;
            txtBxSaldoDisponivel.TextChanged += txtBxSaldoDisponivel_TextChanged;
            // 
            // txtBoxSaldoBloqJud
            // 
            txtBoxSaldoBloqJud.Location = new Point(178, 101);
            txtBoxSaldoBloqJud.Margin = new Padding(3, 4, 3, 4);
            txtBoxSaldoBloqJud.MaxLength = 20;
            txtBoxSaldoBloqJud.Name = "txtBoxSaldoBloqJud";
            txtBoxSaldoBloqJud.ReadOnly = true;
            txtBoxSaldoBloqJud.Size = new Size(145, 27);
            txtBoxSaldoBloqJud.TabIndex = 1;
            txtBoxSaldoBloqJud.TextChanged += txtBoxSaldoBloqJud_TextChanged;
            // 
            // txtBoxSaldoBloq
            // 
            txtBoxSaldoBloq.Location = new Point(178, 50);
            txtBoxSaldoBloq.Margin = new Padding(3, 4, 3, 4);
            txtBoxSaldoBloq.MaxLength = 20;
            txtBoxSaldoBloq.Name = "txtBoxSaldoBloq";
            txtBoxSaldoBloq.ReadOnly = true;
            txtBoxSaldoBloq.Size = new Size(145, 27);
            txtBoxSaldoBloq.TabIndex = 0;
            txtBoxSaldoBloq.TextChanged += txtBoxSaldoBloq_TextChanged;
            // 
=======
>>>>>>> 08f6633fea46c002b740d62a388b6d698d443675
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
<<<<<<< HEAD
            ClientSize = new Size(1874, 997);
            Controls.Add(groupBox3);
=======
            ClientSize = new Size(1162, 748);
>>>>>>> 08f6633fea46c002b740d62a388b6d698d443675
            Controls.Add(btnTesteTelaBord);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Gerador de Remessa Cliente ";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
        private Button btnTesteTelaBord;
<<<<<<< HEAD
        private GroupBox groupBox3;
        private TextBox txtBoxSaldoBloq;
        private TextBox txtBxSaldoDisponivel;
        private TextBox txtBoxSaldoBloqJud;
        private Label label12;
        private Label label6;
        private Label LabelSdBloq;
=======
>>>>>>> 08f6633fea46c002b740d62a388b6d698d443675
    }
}