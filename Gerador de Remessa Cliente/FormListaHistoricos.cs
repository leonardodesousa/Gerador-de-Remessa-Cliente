using Gerador_de_Remessa_Cliente.Model;
using Gerador_de_Remessa_Cliente.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_Remessa_Cliente
{
    public partial class FormListaHistoricos : Form
    {
        public FormListaHistoricos()
        {
            InitializeComponent();
            List<Historico> historicos = new List<Historico>();

            BuscaDadosBd buscaDadosBd = new BuscaDadosBd();

            historicos = buscaDadosBd.buscaHistoricos();

            dataGridView1.Rows.Clear();

            for (int i = 0; i < historicos.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = historicos[i].codigoHistorico;
                dataGridView1.Rows[i].Cells[1].Value = historicos[i].descricaoHistorico;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
