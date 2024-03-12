namespace Gerador_de_Remessa_Cliente
{
    partial class FormListaHistoricos
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
            dataGridView1 = new DataGridView();
            Column1CodHist = new DataGridViewTextBoxColumn();
            Column2DescricaoHist = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1CodHist, Column2DescricaoHist });
            dataGridView1.Location = new Point(133, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(515, 461);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1CodHist
            // 
            Column1CodHist.HeaderText = "Cód. Histórico";
            Column1CodHist.MaxInputLength = 4;
            Column1CodHist.MinimumWidth = 50;
            Column1CodHist.Name = "Column1CodHist";
            Column1CodHist.ReadOnly = true;
            Column1CodHist.Width = 115;
            // 
            // Column2DescricaoHist
            // 
            Column2DescricaoHist.HeaderText = "Descrição Histórico";
            Column2DescricaoHist.MaxInputLength = 100;
            Column2DescricaoHist.MinimumWidth = 50;
            Column2DescricaoHist.Name = "Column2DescricaoHist";
            Column2DescricaoHist.ReadOnly = true;
            Column2DescricaoHist.Width = 350;
            // 
            // FormListaHistoricos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 572);
            Controls.Add(dataGridView1);
            Name = "FormListaHistoricos";
            Text = "Consulta Históricos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1CodHist;
        private DataGridViewTextBoxColumn Column2DescricaoHist;
    }
}