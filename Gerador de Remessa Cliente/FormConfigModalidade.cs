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
        string siglaEncargo;
        Encargo encargo = new Encargo();
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
                //comboModalidade.Items.Add(comboModalidades[i].siglaModalidade + " - " + comboModalidades[i].descricaoModalidade);
                comboModalidade.Items.Add(comboModalidades[i].siglaModalidade);
            }

            for (int i = 0; i <= comboModalidades.Count; i++)
            {
                comboTipoTitulo.Items.Add(comboTipoTitulos[i].siglaTitpoTitulo + " - " + comboTipoTitulos[i].descricaoTitulo);
            }

            //comboModalidade.SelectedIndex = 0;

            //siglaEncargo = comboModalidades[comboModalidade.SelectedIndex].siglaEncargo;

            /*
            if (comboModalidade.SelectedIndex < 0)
            {
                siglaEncargo = comboModalidades[0].siglaEncargo;
            } else
            {
                siglaEncargo = comboModalidades[comboModalidade.SelectedIndex].siglaEncargo;
            }
            */


        }

        private void comboModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarModalidade_Click(object sender, EventArgs e)
        {
            BuscaDadosBd buscaDadosBd = new BuscaDadosBd();
            //encargo = buscaDadosBd.buscaEncargos(siglaEncargo);

            //String conveniado = comboConvenios.Text.ToString().Substring(0, 12);
            //string modalidade = comboModalidade.SelectedIndex.ToString();

            string modalidade = comboModalidade.Text.ToString().Trim();
            encargo = buscaDadosBd.buscaEncargosPorModalidade(modalidade);
            //System.Windows.Forms.MessageBox.Show("ESTOU ENVIANDO '" + modalidade + "'");            
            //System.Windows.Forms.MessageBox.Show("encargo recebe " + encargo.taxaPermanenciaMais30Dias);            

            //Mora até 30 dias 
            txtBoxFormaAte30Dias.Text = encargo.identificadorFormaAte30Dias;
            txtBoxTaxaMesAte30Dias.Text = encargo.taxaPermanenciaAte30Dias.ToString();
            txtBoxIdDiasAte30Dias.Text = encargo.identificadorDiasAte30Dias;

            //Mora mais de 30 dias
            txtBoxFormaMais30Dias.Text = encargo.identificadorformaMais30Dias;
            txtBoxTaxaMesMais30Dias.Text = encargo.taxaPermanenciaMais30Dias.ToString();
            txtBoxIdDiasMais30Dias.Text = encargo.identificadorDiasMais30Dias;

            //Multa
            txtBoxQuantidadeDias.Text = encargo.quantidadeDiasMulta.ToString();
            txtBoxPercentualMulta.Text = encargo.percentualMulta.ToString();
            txtBoxBase.Text = encargo.baseCalculoMulta;


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

        private void txtBoxFormaAte30Dias_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxTaxaMesAte30Dias_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxIdDiasAte30Dias_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
