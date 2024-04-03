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
            SuspendLayout();
            // 
            // comboModalidade
            // 
            comboModalidade.FormattingEnabled = true;
            comboModalidade.Location = new Point(135, 73);
            comboModalidade.Name = "comboModalidade";
            comboModalidade.Size = new Size(386, 23);
            comboModalidade.TabIndex = 0;
            comboModalidade.SelectedIndexChanged += comboModalidade_SelectedIndexChanged;
            // 
            // btnBuscarModalidade
            // 
            btnBuscarModalidade.Location = new Point(565, 69);
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
            label1.Location = new Point(50, 76);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 2;
            label1.Text = "Modalidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 137);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Título";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(565, 227);
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
            comboTipoTitulo.Location = new Point(135, 129);
            comboTipoTitulo.Name = "comboTipoTitulo";
            comboTipoTitulo.Size = new Size(277, 23);
            comboTipoTitulo.TabIndex = 6;
            comboTipoTitulo.SelectedIndexChanged += comboTipoTitulo_SelectedIndexChanged;
            // 
            // FormConfigModalidade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 299);
            Controls.Add(comboTipoTitulo);
            Controls.Add(btnSalvar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBuscarModalidade);
            Controls.Add(comboModalidade);
            Name = "FormConfigModalidade";
            Text = "FormConfigModalidade";
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
    }
}