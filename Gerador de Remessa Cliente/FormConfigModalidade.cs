using Gerador_de_Remessa_Cliente.Model;
using Gerador_de_Remessa_Cliente.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_Remessa_Cliente
{
    public partial class FormConfigModalidade : Form
    {
        public FormConfigModalidade()
        {
            BuscaDadosBd buscaDadosBd = new BuscaDadosBd();
            InitializeComponent();
            List<Modalidade> comboModalidades = new List<Modalidade>();
            List<TipoTitulo> comboTipoTitulos = new List<TipoTitulo>();

            comboTipoTitulos = buscaDadosBd.buscarTitpoTitulo();
            comboModalidades = buscaDadosBd.buscaModalidadeCobranca();

            for (int i = 0; i < comboModalidades.Count; i++)
            {
                //comboModalidade.Items.Add();
                comboModalidade.Items.Add(comboModalidades[i].siglaModalidade + " - " + comboModalidades[i].descricaoModalidade);
            }

            for (int i = 0; i <= comboModalidades.Count; i++)
            {
                comboTipoTitulo.Items.Add(comboTipoTitulos[i].siglaTitpoTitulo + " - " + comboTipoTitulos[i].descricaoTitulo);
            }
        }

        private void comboModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarModalidade_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboTipoTitulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
