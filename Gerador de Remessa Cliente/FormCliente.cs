using Gerador_de_Remessa_Cliente.Util;
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
    public partial class v : Form
    {
        public v()
        {
            InitializeComponent();
        }

        private void textBoxCnpj_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGerarCnpj_Click(object sender, EventArgs e)
        {
            bool formatar = false;
            if (checkBoxFormatCnpj.Checked)
            {
                formatar = true;
            }
            GeradorCnpjV2 geradorCnpj = new GeradorCnpjV2();
            textBoxCnpj.Text = geradorCnpj.GerarCNPJ(formatar);
        }

        private void textBoxCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxFormatCpf_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGerarCpf_Click(object sender, EventArgs e)
        {
            bool formatar = false;
            if (checkBoxFormatCpf.Checked)
            {
                formatar = true;
            }
            GeradorCPF geradorCPF = new GeradorCPF();
            textBoxCpf.Text = geradorCPF.GerarCPF(formatar);
        }

        private void textBoxVisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCvv_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGerarVisa_Click(object sender, EventArgs e)
        {
            GeradorCartaoVisa geradorCartaoVisa = new GeradorCartaoVisa();
            textBoxVisa.Text = geradorCartaoVisa.GerarCartaoVisa().NumeroCartao;
            textBoxCvv.Text = geradorCartaoVisa.GerarCartaoVisa().CVV;
            txtBoxDataVencVisa.Text = geradorCartaoVisa.GerarCartaoVisa().DataVencimento.ToString("MM/yyyy");

        }

        private void txtBoxDataVencVisa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
