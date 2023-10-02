using Gerador_de_Remessa_Cliente.Model;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FormConfigServidorWS : Form
    {
        public FormConfigServidorWS()
        {
            InitializeComponent();
            LeitorArquivoParametros leitor = new LeitorArquivoParametros();

            List<string> lista = new List<string>();
            lista = leitor.BuscaParametrosWs();
            //mskTextBoxSequencialArq.Text = lista[0].Trim().ToString().PadLeft(5,'0');
            textBoxEnderecoServer.Text = lista[0].ToString();
            textBoxToken.Text = lista[1].ToString();

            textBoxCurl.Text = "curl --location --request POST " + "\"" + lista[0].ToString() + "/tfs-credito-service/oauth/token?client_id=totvs-client&client_secret=secret&grant_type=client_credentials\"";
        }

        private void textBoxEnderecoServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxToken_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServidorAcesso servidorAcesso = new ServidorAcesso();

            if (textBoxEnderecoServer.Text.ToString().Trim().Length > 0 && textBoxToken.Text.ToString().Trim().Length > 0)
            {
                bool validaAtualizacao = servidorAcesso.atualizaServidor(textBoxEnderecoServer.Text.ToString().Trim(), textBoxToken.Text.ToString().Trim());

                if (validaAtualizacao == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Servidor atualizado com sucesso! ", "Atualização de servidor", MessageBoxButtons.OK);
                    //Form1 form = new Form1();
                    this.Close();
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Ocorreu um erro ao atualizar o servidor WS ", "Atualização de servidor", MessageBoxButtons.OK);
                }
            }


        }

        private void textBoxCurl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
