namespace Gerador_de_Remessa_Cliente
{
    partial class v
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
            textBoxCnpj = new TextBox();
            btnGerarCnpj = new Button();
            labelCnpj = new Label();
            checkBoxFormatCnpj = new CheckBox();
            textBoxCpf = new TextBox();
            LabelCpf = new Label();
            checkBoxFormatCpf = new CheckBox();
            btnGerarCpf = new Button();
            labelVisa = new Label();
            textBoxVisa = new TextBox();
            textBoxCvv = new TextBox();
            labelCvv = new Label();
            btnGerarVisa = new Button();
            txtBoxDataVencVisa = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxCnpj
            // 
            textBoxCnpj.Location = new Point(136, 93);
            textBoxCnpj.MaxLength = 11;
            textBoxCnpj.Name = "textBoxCnpj";
            textBoxCnpj.Size = new Size(261, 27);
            textBoxCnpj.TabIndex = 0;
            textBoxCnpj.TextChanged += textBoxCnpj_TextChanged;
            // 
            // btnGerarCnpj
            // 
            btnGerarCnpj.Location = new Point(759, 93);
            btnGerarCnpj.Name = "btnGerarCnpj";
            btnGerarCnpj.Size = new Size(140, 40);
            btnGerarCnpj.TabIndex = 1;
            btnGerarCnpj.Text = "Gerar CNPJ";
            btnGerarCnpj.UseVisualStyleBackColor = true;
            btnGerarCnpj.Click += btnGerarCnpj_Click;
            // 
            // labelCnpj
            // 
            labelCnpj.AutoSize = true;
            labelCnpj.Location = new Point(58, 96);
            labelCnpj.Name = "labelCnpj";
            labelCnpj.Size = new Size(41, 20);
            labelCnpj.TabIndex = 2;
            labelCnpj.Text = "CNPJ";
            // 
            // checkBoxFormatCnpj
            // 
            checkBoxFormatCnpj.AutoSize = true;
            checkBoxFormatCnpj.Location = new Point(424, 96);
            checkBoxFormatCnpj.Name = "checkBoxFormatCnpj";
            checkBoxFormatCnpj.Size = new Size(127, 24);
            checkBoxFormatCnpj.TabIndex = 3;
            checkBoxFormatCnpj.Text = "Formatar CNPJ";
            checkBoxFormatCnpj.UseVisualStyleBackColor = true;
            // 
            // textBoxCpf
            // 
            textBoxCpf.Location = new Point(136, 155);
            textBoxCpf.MaxLength = 7;
            textBoxCpf.Name = "textBoxCpf";
            textBoxCpf.Size = new Size(261, 27);
            textBoxCpf.TabIndex = 4;
            textBoxCpf.TextChanged += textBoxCpf_TextChanged;
            // 
            // LabelCpf
            // 
            LabelCpf.AutoSize = true;
            LabelCpf.Location = new Point(58, 162);
            LabelCpf.Name = "LabelCpf";
            LabelCpf.Size = new Size(33, 20);
            LabelCpf.TabIndex = 5;
            LabelCpf.Text = "CPF";
            // 
            // checkBoxFormatCpf
            // 
            checkBoxFormatCpf.AutoSize = true;
            checkBoxFormatCpf.Location = new Point(424, 158);
            checkBoxFormatCpf.Name = "checkBoxFormatCpf";
            checkBoxFormatCpf.Size = new Size(119, 24);
            checkBoxFormatCpf.TabIndex = 6;
            checkBoxFormatCpf.Text = "Formatar CPF";
            checkBoxFormatCpf.UseVisualStyleBackColor = true;
            checkBoxFormatCpf.CheckedChanged += checkBoxFormatCpf_CheckedChanged;
            // 
            // btnGerarCpf
            // 
            btnGerarCpf.Location = new Point(759, 158);
            btnGerarCpf.Name = "btnGerarCpf";
            btnGerarCpf.Size = new Size(140, 40);
            btnGerarCpf.TabIndex = 7;
            btnGerarCpf.Text = "Gerar CPF";
            btnGerarCpf.UseVisualStyleBackColor = true;
            btnGerarCpf.Click += btnGerarCpf_Click;
            // 
            // labelVisa
            // 
            labelVisa.AutoSize = true;
            labelVisa.Location = new Point(7, 46);
            labelVisa.Name = "labelVisa";
            labelVisa.Size = new Size(36, 20);
            labelVisa.TabIndex = 8;
            labelVisa.Text = "Visa";
            // 
            // textBoxVisa
            // 
            textBoxVisa.Location = new Point(85, 43);
            textBoxVisa.MaxLength = 16;
            textBoxVisa.Name = "textBoxVisa";
            textBoxVisa.Size = new Size(261, 27);
            textBoxVisa.TabIndex = 9;
            textBoxVisa.TextChanged += textBoxVisa_TextChanged;
            // 
            // textBoxCvv
            // 
            textBoxCvv.ImeMode = ImeMode.NoControl;
            textBoxCvv.Location = new Point(415, 46);
            textBoxCvv.MaxLength = 3;
            textBoxCvv.Name = "textBoxCvv";
            textBoxCvv.Size = new Size(77, 27);
            textBoxCvv.TabIndex = 10;
            textBoxCvv.TextChanged += textBoxCvv_TextChanged;
            // 
            // labelCvv
            // 
            labelCvv.AutoSize = true;
            labelCvv.Location = new Point(373, 50);
            labelCvv.Name = "labelCvv";
            labelCvv.Size = new Size(36, 20);
            labelCvv.TabIndex = 11;
            labelCvv.Text = "CVV";
            // 
            // btnGerarVisa
            // 
            btnGerarVisa.Location = new Point(715, 36);
            btnGerarVisa.Name = "btnGerarVisa";
            btnGerarVisa.Size = new Size(140, 40);
            btnGerarVisa.TabIndex = 12;
            btnGerarVisa.Text = "Gerar Cartão Visa";
            btnGerarVisa.UseVisualStyleBackColor = true;
            btnGerarVisa.Click += btnGerarVisa_Click;
            // 
            // txtBoxDataVencVisa
            // 
            txtBoxDataVencVisa.ImeMode = ImeMode.NoControl;
            txtBoxDataVencVisa.Location = new Point(591, 46);
            txtBoxDataVencVisa.MaxLength = 8;
            txtBoxDataVencVisa.Name = "txtBoxDataVencVisa";
            txtBoxDataVencVisa.Size = new Size(111, 27);
            txtBoxDataVencVisa.TabIndex = 13;
            txtBoxDataVencVisa.TextChanged += txtBoxDataVencVisa_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(509, 50);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 14;
            label1.Text = "Válido até";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxVisa);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(labelVisa);
            groupBox1.Controls.Add(txtBoxDataVencVisa);
            groupBox1.Controls.Add(textBoxCvv);
            groupBox1.Controls.Add(btnGerarVisa);
            groupBox1.Controls.Add(labelCvv);
            groupBox1.Location = new Point(44, 248);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(911, 107);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Embossing";
            // 
            // v
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnGerarCpf);
            Controls.Add(checkBoxFormatCpf);
            Controls.Add(LabelCpf);
            Controls.Add(textBoxCpf);
            Controls.Add(checkBoxFormatCnpj);
            Controls.Add(labelCnpj);
            Controls.Add(btnGerarCnpj);
            Controls.Add(textBoxCnpj);
            Name = "v";
            Text = "Clientes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCnpj;
        private Button btnGerarCnpj;
        private Label labelCnpj;
        private CheckBox checkBoxFormatCnpj;
        private TextBox textBoxCpf;
        private Label LabelCpf;
        private CheckBox checkBoxFormatCpf;
        private Button btnGerarCpf;
        private Label labelVisa;
        private TextBox textBoxVisa;
        private TextBox textBoxCvv;
        private Label labelCvv;
        private Button btnGerarVisa;
        private TextBox txtBoxDataVencVisa;
        private Label label1;
        private GroupBox groupBox1;
    }
}