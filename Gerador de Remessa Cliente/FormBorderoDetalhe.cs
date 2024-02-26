using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Gerador_de_Remessa_Cliente
{
    public partial class FormBorderoDetalhe : Form
    {
        public FormBorderoDetalhe()
        {
            InitializeComponent();
            //String path2 = @"C:\TotalBanco\Crediblaster\GeraRem\GeraRem.ini";
            //string diretorio = @"C:\\TotalBanco\\Crediblaster\\GeraRem\\xml\\CalcularBordero22022024164620_response.xml";
            String diretorio = null;

            String path = @"C:\\TotalBanco\\Crediblaster\\GeraRem\\Geraremsoap.dll";

            if (File.Exists(path))
            {
                //using (StreamReader file = new StreamReader(path, Encoding.GetEncoding(CultureInfo.GetCultureInfo("pt-BR").TextInfo.ANSICodePage)))
                using (StreamReader file = new StreamReader(path))
                {
                    // implementar aqui método de busca dos parametros
                    int counter = 0;
                    string ln;
                    while ((ln = file.ReadLine()) != null)
                    {
                        if (ln.Length > 0)
                        {
                            diretorio = ln;
                        }
                    }
                }
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(diretorio);

            int cont = 0;

            List<string> dataEmissao = new List<string>();
            List<string> dataVencimento = new List<string>();
            List<string> seuNumero = new List<string>();
            List<string> valor = new List<string>();
            List<string> docPagador = new List<string>();
            string lote = null;
            string contrato = null;
            string valorTotal = null;



            XmlNodeList elemList2 = doc.GetElementsByTagName("dataEmissaoTitulo");
            for (int i = 0; i < elemList2.Count; i++)
            {
                //dataEmissao = (elemList2[i].InnerXml);
                dataEmissao.Add((elemList2[i].InnerXml));
                //dataGridView1.Rows[0].Cells[1].Value = (elemList2[i].InnerXml);
                cont++;

            }

            XmlNodeList elemList3 = doc.GetElementsByTagName("dataVencimento");
            for (int i = 0; i < elemList3.Count; i++)
            {
                dataVencimento.Add(elemList3[i].InnerXml);
                //dataGridView1.Rows[0].Cells[2].Value = (elemList3[i].InnerXml);

            }

            XmlNodeList elemList4 = doc.GetElementsByTagName("seuNumero");
            for (int i = 0; i < elemList4.Count; i++)
            {
                seuNumero.Add(elemList4[i].InnerXml);
                //seuNumero = (elemList4[i].InnerXml);
                //dataGridView1.Rows[0].Cells[3].Value = (elemList4[i].InnerXml);

            }

            XmlNodeList elemList5 = doc.GetElementsByTagName("valorTitulo");
            for (int i = 0; i < elemList5.Count; i++)
            {
                valor.Add(elemList5[i].InnerXml);
                //valor = (elemList5[i].InnerXml);
                //dataGridView1.Rows[0].Cells[4].Value = (elemList5[i].InnerXml);

            }

            XmlNodeList elemList6 = doc.GetElementsByTagName("numeroDocumentoEfetivo");
            for (int i = 0; i < elemList6.Count; i++)
            {
                docPagador.Add(elemList6[i].InnerXml);
                //docPagador = (elemList4[i].InnerXml);
                //dataGridView1.Rows[0].Cells[5].Value = (elemList6[i].InnerXml);
            }

            XmlNodeList elemList7 = doc.GetElementsByTagName("numeroLote");
            for (int i = 0; i < elemList7.Count; i++)
            {
                lote = (elemList7[i].InnerXml);
                //docPagador = (elemList4[i].InnerXml);
                //dataGridView1.Rows[0].Cells[5].Value = (elemList6[i].InnerXml);
            }

            XmlNodeList elemList8 = doc.GetElementsByTagName("numeroContrato");
            for (int i = 0; i < elemList8.Count; i++)
            {
                contrato = (elemList8[i].InnerXml);
                //docPagador = (elemList4[i].InnerXml);
                //dataGridView1.Rows[0].Cells[5].Value = (elemList6[i].InnerXml);
            }

            XmlNodeList elemList9 = doc.GetElementsByTagName("valorTotal");
            for (int i = 0; i < elemList9.Count; i++)
            {
                valorTotal = (elemList9[i].InnerXml);
                //docPagador = (elemList4[i].InnerXml);
                //dataGridView1.Rows[0].Cells[5].Value = (elemList6[i].InnerXml);
            }


            txtBoxLote.Text = lote.ToString();
            txtBoxContrato.Text = contrato.ToString();
            txtBoxTotal.Text = valorTotal.ToString();

            for (int i = 0; i < cont; i++)
            {
                dataGridView1.Rows.Add();
                //DialogResult dialogo3 = MessageBox.Show(dataEmissao[i], "Informação", MessageBoxButtons.OK);

                dataGridView1.Rows[i].Cells[0].Value = DateTime.Parse(dataEmissao[i]).ToString("dd/MM/yyyy");
                dataGridView1.Rows[i].Cells[1].Value = DateTime.Parse(dataVencimento[i]).ToString("dd/MM/yyyy");
                dataGridView1.Rows[i].Cells[2].Value = seuNumero[i];
                dataGridView1.Rows[i].Cells[3].Value = Convert.ToDouble(valor[i]).ToString("C");
                dataGridView1.Rows[i].Cells[4].Value = docPagador[i];

            }

            /*
            string mensagem = "Numero de lançamentos: " + cont;
            DialogResult dialogo3 = MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK);
            */

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBoxLote_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxContrato_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

