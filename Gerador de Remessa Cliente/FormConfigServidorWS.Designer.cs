namespace Gerador_de_Remessa_Cliente
{
    partial class FormConfigServidorWS
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
            this.textBoxEnderecoServer = new System.Windows.Forms.TextBox();
            this.enderecoPorta = new System.Windows.Forms.Label();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.labelToken = new System.Windows.Forms.Label();
            this.btnAtualizaServer = new System.Windows.Forms.Button();
            this.textBoxCurl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEnderecoServer
            // 
            this.textBoxEnderecoServer.Location = new System.Drawing.Point(243, 99);
            this.textBoxEnderecoServer.MaxLength = 60;
            this.textBoxEnderecoServer.Name = "textBoxEnderecoServer";
            this.textBoxEnderecoServer.Size = new System.Drawing.Size(290, 23);
            this.textBoxEnderecoServer.TabIndex = 0;
            this.textBoxEnderecoServer.TextChanged += new System.EventHandler(this.textBoxEnderecoServer_TextChanged);
            // 
            // enderecoPorta
            // 
            this.enderecoPorta.AutoSize = true;
            this.enderecoPorta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enderecoPorta.Location = new System.Drawing.Point(93, 101);
            this.enderecoPorta.Name = "enderecoPorta";
            this.enderecoPorta.Size = new System.Drawing.Size(126, 21);
            this.enderecoPorta.TabIndex = 1;
            this.enderecoPorta.Text = "Endereço e Porta";
            // 
            // textBoxToken
            // 
            this.textBoxToken.Location = new System.Drawing.Point(243, 149);
            this.textBoxToken.MaxLength = 60;
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.Size = new System.Drawing.Size(290, 23);
            this.textBoxToken.TabIndex = 2;
            this.textBoxToken.TextChanged += new System.EventHandler(this.textBoxToken_TextChanged);
            // 
            // labelToken
            // 
            this.labelToken.AutoSize = true;
            this.labelToken.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelToken.Location = new System.Drawing.Point(120, 151);
            this.labelToken.Name = "labelToken";
            this.labelToken.Size = new System.Drawing.Size(99, 21);
            this.labelToken.TabIndex = 3;
            this.labelToken.Text = "Token Bearer";
            // 
            // btnAtualizaServer
            // 
            this.btnAtualizaServer.Location = new System.Drawing.Point(243, 257);
            this.btnAtualizaServer.Name = "btnAtualizaServer";
            this.btnAtualizaServer.Size = new System.Drawing.Size(116, 37);
            this.btnAtualizaServer.TabIndex = 4;
            this.btnAtualizaServer.Text = "Salvar";
            this.btnAtualizaServer.UseVisualStyleBackColor = true;
            this.btnAtualizaServer.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxCurl
            // 
            this.textBoxCurl.Location = new System.Drawing.Point(243, 194);
            this.textBoxCurl.MaxLength = 60;
            this.textBoxCurl.Name = "textBoxCurl";
            this.textBoxCurl.Size = new System.Drawing.Size(458, 23);
            this.textBoxCurl.TabIndex = 5;
            this.textBoxCurl.TextChanged += new System.EventHandler(this.textBoxCurl_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(117, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Exemplo Curl";
            // 
            // FormConfigServidorWS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCurl);
            this.Controls.Add(this.btnAtualizaServer);
            this.Controls.Add(this.labelToken);
            this.Controls.Add(this.textBoxToken);
            this.Controls.Add(this.enderecoPorta);
            this.Controls.Add(this.textBoxEnderecoServer);
            this.Name = "FormConfigServidorWS";
            this.Text = "Configuração Servidor WS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxEnderecoServer;
        private Label enderecoPorta;
        private TextBox textBoxToken;
        private Label labelToken;
        private Button btnAtualizaServer;
        private TextBox textBoxCurl;
        private Label label1;
    }
}