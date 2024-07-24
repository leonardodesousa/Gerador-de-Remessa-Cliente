namespace Gerador_de_Remessa_Cliente
{
    partial class FormConfigModalidade
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
            comboModalidade = new ComboBox();
            btnBuscarModalidade = new Button();
            label1 = new Label();
            label2 = new Label();
            btnSalvar = new Button();
            comboTipoTitulo = new ComboBox();
            txtBoxFormaAte30Dias = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtBoxTaxaMesAte30Dias = new TextBox();
            label5 = new Label();
            txtBoxIdDiasAte30Dias = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            txtBoxFormaMais30Dias = new TextBox();
            txtBoxIdDiasMais30Dias = new TextBox();
            label8 = new Label();
            txtBoxTaxaMesMais30Dias = new TextBox();
            groupBox3 = new GroupBox();
            label13 = new Label();
            label12 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtBoxQuantidadeDias = new TextBox();
            txtBoxBase = new TextBox();
            label11 = new Label();
            txtBoxPercentualMulta = new TextBox();
            comboConvenios = new ComboBox();
            labelConvenios = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // comboModalidade
            // 
            comboModalidade.FormattingEnabled = true;
            comboModalidade.Location = new Point(201, 71);
            comboModalidade.Name = "comboModalidade";
            comboModalidade.Size = new Size(386, 23);
            comboModalidade.TabIndex = 0;
            comboModalidade.SelectedIndexChanged += comboModalidade_SelectedIndexChanged;
            // 
            // btnBuscarModalidade
            // 
            btnBuscarModalidade.Location = new Point(837, 67);
            btnBuscarModalidade.Name = "btnBuscarModalidade";
            btnBuscarModalidade.Size = new Size(79, 29);
            btnBuscarModalidade.TabIndex = 1;
            btnBuscarModalidade.Text = "Buscar ";
            btnBuscarModalidade.UseVisualStyleBackColor = true;
            btnBuscarModalidade.Click += btnBuscarModalidade_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 79);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 2;
            label1.Text = "Modalidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 393);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Título";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(565, 400);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(79, 29);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // comboTipoTitulo
            // 
            comboTipoTitulo.FormattingEnabled = true;
            comboTipoTitulo.Location = new Point(135, 385);
            comboTipoTitulo.Name = "comboTipoTitulo";
            comboTipoTitulo.Size = new Size(277, 23);
            comboTipoTitulo.TabIndex = 6;
            comboTipoTitulo.SelectedIndexChanged += comboTipoTitulo_SelectedIndexChanged;
            // 
            // txtBoxFormaAte30Dias
            // 
            txtBoxFormaAte30Dias.Location = new Point(84, 36);
            txtBoxFormaAte30Dias.MaxLength = 15;
            txtBoxFormaAte30Dias.Name = "txtBoxFormaAte30Dias";
            txtBoxFormaAte30Dias.ReadOnly = true;
            txtBoxFormaAte30Dias.Size = new Size(100, 23);
            txtBoxFormaAte30Dias.TabIndex = 7;
            txtBoxFormaAte30Dias.TextChanged += txtBoxFormaAte30Dias_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 39);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 8;
            label3.Text = "Forma";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 68);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 10;
            label4.Text = "Taxa Mês";
            // 
            // txtBoxTaxaMesAte30Dias
            // 
            txtBoxTaxaMesAte30Dias.Location = new Point(84, 65);
            txtBoxTaxaMesAte30Dias.MaxLength = 15;
            txtBoxTaxaMesAte30Dias.Name = "txtBoxTaxaMesAte30Dias";
            txtBoxTaxaMesAte30Dias.ReadOnly = true;
            txtBoxTaxaMesAte30Dias.Size = new Size(100, 23);
            txtBoxTaxaMesAte30Dias.TabIndex = 9;
            txtBoxTaxaMesAte30Dias.TextChanged += txtBoxTaxaMesAte30Dias_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 97);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 12;
            label5.Text = "Dias";
            // 
            // txtBoxIdDiasAte30Dias
            // 
            txtBoxIdDiasAte30Dias.Location = new Point(84, 94);
            txtBoxIdDiasAte30Dias.MaxLength = 15;
            txtBoxIdDiasAte30Dias.Name = "txtBoxIdDiasAte30Dias";
            txtBoxIdDiasAte30Dias.ReadOnly = true;
            txtBoxIdDiasAte30Dias.Size = new Size(100, 23);
            txtBoxIdDiasAte30Dias.TabIndex = 11;
            txtBoxIdDiasAte30Dias.TextChanged += txtBoxIdDiasAte30Dias_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtBoxFormaAte30Dias);
            groupBox1.Controls.Add(txtBoxIdDiasAte30Dias);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBoxTaxaMesAte30Dias);
            groupBox1.Location = new Point(48, 178);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(242, 152);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Até 30 dias";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtBoxFormaMais30Dias);
            groupBox2.Controls.Add(txtBoxIdDiasMais30Dias);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtBoxTaxaMesMais30Dias);
            groupBox2.Location = new Point(305, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(242, 152);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mais de 30 dias";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 68);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 10;
            label6.Text = "Taxa Mês";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 97);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 12;
            label7.Text = "Dias";
            // 
            // txtBoxFormaMais30Dias
            // 
            txtBoxFormaMais30Dias.Location = new Point(84, 36);
            txtBoxFormaMais30Dias.MaxLength = 15;
            txtBoxFormaMais30Dias.Name = "txtBoxFormaMais30Dias";
            txtBoxFormaMais30Dias.ReadOnly = true;
            txtBoxFormaMais30Dias.Size = new Size(100, 23);
            txtBoxFormaMais30Dias.TabIndex = 7;
            // 
            // txtBoxIdDiasMais30Dias
            // 
            txtBoxIdDiasMais30Dias.Location = new Point(84, 94);
            txtBoxIdDiasMais30Dias.MaxLength = 15;
            txtBoxIdDiasMais30Dias.Name = "txtBoxIdDiasMais30Dias";
            txtBoxIdDiasMais30Dias.ReadOnly = true;
            txtBoxIdDiasMais30Dias.Size = new Size(100, 23);
            txtBoxIdDiasMais30Dias.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 39);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 8;
            label8.Text = "Forma";
            // 
            // txtBoxTaxaMesMais30Dias
            // 
            txtBoxTaxaMesMais30Dias.Location = new Point(84, 65);
            txtBoxTaxaMesMais30Dias.MaxLength = 15;
            txtBoxTaxaMesMais30Dias.Name = "txtBoxTaxaMesMais30Dias";
            txtBoxTaxaMesMais30Dias.ReadOnly = true;
            txtBoxTaxaMesMais30Dias.Size = new Size(100, 23);
            txtBoxTaxaMesMais30Dias.TabIndex = 9;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txtBoxQuantidadeDias);
            groupBox3.Controls.Add(txtBoxBase);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtBoxPercentualMulta);
            groupBox3.Location = new Point(565, 178);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(271, 152);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Multa";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(160, 39);
            label13.Name = "label13";
            label13.Size = new Size(80, 15);
            label13.TabIndex = 14;
            label13.Text = "Dias de atraso";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(160, 73);
            label12.Name = "label12";
            label12.Size = new Size(51, 15);
            label12.TabIndex = 13;
            label12.Text = "% Multa";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 68);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 10;
            label9.Text = "Cobrar";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 97);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 12;
            label10.Text = "Base";
            // 
            // txtBoxQuantidadeDias
            // 
            txtBoxQuantidadeDias.Location = new Point(83, 36);
            txtBoxQuantidadeDias.MaxLength = 15;
            txtBoxQuantidadeDias.Name = "txtBoxQuantidadeDias";
            txtBoxQuantidadeDias.ReadOnly = true;
            txtBoxQuantidadeDias.Size = new Size(70, 23);
            txtBoxQuantidadeDias.TabIndex = 7;
            // 
            // txtBoxBase
            // 
            txtBoxBase.Location = new Point(83, 94);
            txtBoxBase.MaxLength = 15;
            txtBoxBase.Name = "txtBoxBase";
            txtBoxBase.ReadOnly = true;
            txtBoxBase.Size = new Size(153, 23);
            txtBoxBase.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 39);
            label11.Name = "label11";
            label11.Size = new Size(34, 15);
            label11.TabIndex = 8;
            label11.Text = "Após";
            // 
            // txtBoxPercentualMulta
            // 
            txtBoxPercentualMulta.Location = new Point(83, 65);
            txtBoxPercentualMulta.MaxLength = 15;
            txtBoxPercentualMulta.Name = "txtBoxPercentualMulta";
            txtBoxPercentualMulta.ReadOnly = true;
            txtBoxPercentualMulta.Size = new Size(71, 23);
            txtBoxPercentualMulta.TabIndex = 9;
            // 
            // comboConvenios
            // 
            comboConvenios.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboConvenios.FormattingEnabled = true;
            comboConvenios.Location = new Point(201, 20);
            comboConvenios.Name = "comboConvenios";
            comboConvenios.Size = new Size(622, 28);
            comboConvenios.TabIndex = 19;
            comboConvenios.SelectedIndexChanged += comboConvenios_SelectedIndexChanged;
            // 
            // labelConvenios
            // 
            labelConvenios.AutoSize = true;
            labelConvenios.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelConvenios.Location = new Point(12, 23);
            labelConvenios.Name = "labelConvenios";
            labelConvenios.Size = new Size(181, 20);
            labelConvenios.TabIndex = 20;
            labelConvenios.Text = "Convênios cadastrados ->";
            // 
            // FormConfigModalidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 567);
            Controls.Add(labelConvenios);
            Controls.Add(comboConvenios);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(comboTipoTitulo);
            Controls.Add(btnSalvar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBuscarModalidade);
            Controls.Add(comboModalidade);
            Name = "FormConfigModalidade";
            Text = "FormConfigModalidade";
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

        private ComboBox comboModalidade;
        private Button btnBuscarModalidade;
        private Label label1;
        private Label label2;
        private Button btnSalvar;
        private ComboBox comboTipoTitulo;
        private TextBox txtBoxFormaAte30Dias;
        private Label label3;
        private Label label4;
        private TextBox txtBoxTaxaMesAte30Dias;
        private Label label5;
        private TextBox txtBoxIdDiasAte30Dias;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label7;
        private TextBox txtBoxFormaMais30Dias;
        private TextBox txtBoxIdDiasMais30Dias;
        private Label label8;
        private TextBox txtBoxTaxaMesMais30Dias;
        private GroupBox groupBox3;
        private Label label13;
        private Label label12;
        private Label label9;
        private Label label10;
        private TextBox txtBoxQuantidadeDias;
        private TextBox txtBoxBase;
        private Label label11;
        private TextBox txtBoxPercentualMulta;
        private ComboBox comboConvenios;
        private Label labelConvenios;
    }
}