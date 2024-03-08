namespace Gerador_de_Remessa_Cliente
{
    partial class FormMovimentoCC
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
            textBoxConta = new TextBox();
            SuspendLayout();
            // 
            // textBoxConta
            // 
            textBoxConta.Location = new Point(135, 164);
            textBoxConta.MaxLength = 12;
            textBoxConta.Name = "textBoxConta";
            textBoxConta.Size = new Size(100, 23);
            textBoxConta.TabIndex = 0;
            // 
            // FormMovimentoCC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxConta);
            Name = "FormMovimentoCC";
            Text = "FormMovimentoCC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxConta;
    }
}