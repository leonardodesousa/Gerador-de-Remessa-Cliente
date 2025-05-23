using Gerador_de_Remessa_Cliente.Framework;
using Gerador_de_Remessa_Cliente.Model;
using Gerador_de_Remessa_Cliente.Repository;
using System.Windows.Forms;

namespace Gerador_de_Remessa_Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = String.Format("Gerador de Remessa Cliente (Vers�o {0})", version);
            ConexaoBD conexao = new ConexaoBD();
            conexao.testaConexao();

            LeitorArquivoParametros leitor = new LeitorArquivoParametros();

            List<String> comboCvns = new List<String>();
            comboCvns = leitor.buscaConvenios();

            for (int i = 0; i < comboCvns.Count; i++)
            {
                comboConvenios.Items.Add(comboCvns[i]);
            }

            /*          
            List<string> lista = new List<string>();
            lista = leitor.BuscaParametros();
            if (lista.Count > 0)
            {
                mskTextBoxSeuNumero.Text = lista[1].ToString();
                mskTextBoxDataInclusao.Text = lista[2].ToString();
                mskTextBoxDataVencimento.Text = lista[3].ToString();
                mskTextBoxLinhasArquivo.Text = lista[4].ToString().Trim().PadLeft(6, '0');
                mskTextBoxQtdArquivos.Text = lista[5].ToString().PadLeft(6, '0');
                mskTextBoxConvenio.Text = lista[6].ToString();
                mskTextBoxContaCedente.Text = lista[7].ToString();
                mskTextBoxAgCedente.Text = lista[8].ToString();
                textBoxDiretorioDestino.Text = lista[9].ToString();
                mskTextBoxNumDocCedente.Text = lista[10].ToString();
                mskBancoCobrador.Text = lista[11].ToString();
                mskTextBoxCarteira.Text = lista[12].ToString();
            }
            */
            //mskTextBoxSequencialArq.Text = lista[0].Trim().ToString().PadLeft(5,'0');

        }

        private void btnGerarArquivo_Click(object sender, EventArgs e)
        {
            int check = 0;
            Boolean informaSeuNumero;
            if (checkBoxEnviaSeuNum.Checked)
            {
                //System.Windows.Forms.MessageBox.Show("Informa seu n�mero est� marcado");
                informaSeuNumero = false;
            }
            else
            {
                //System.Windows.Forms.MessageBox.Show("Informa seu n�mero N�O est� marcado");
                informaSeuNumero = true;
            }

            if (/*String.IsNullOrEmpty(mskTextBoxSequencialArq.Text.Trim().ToString()) ||*/ String.IsNullOrEmpty(mskTextBoxSeuNumero.Text.Trim().ToString()) ||
                String.IsNullOrEmpty(mskTextBoxDataInclusao.Text.Trim().ToString()) || String.IsNullOrEmpty(mskTextBoxDataVencimento.Text.ToString()) ||
                 mskTextBoxDataVencimento.Text.ToString() == "  /  /" || mskTextBoxDataInclusao.Text.ToString() == "  /  /" ||
                String.IsNullOrEmpty(mskTextBoxLinhasArquivo.Text.Trim().ToString()) || String.IsNullOrEmpty(mskTextBoxQtdArquivos.Text.Trim().ToString()) ||
                String.IsNullOrEmpty(mskTextBoxConvenio.Text.Trim().ToString()) || String.IsNullOrEmpty(mskTextBoxContaCedente.Text.Trim().ToString()) ||
                String.IsNullOrEmpty(mskTextBoxAgCedente.Text.Trim().ToString()) || String.IsNullOrEmpty(textBoxDiretorioDestino.Text.Trim().ToString()) ||
                String.IsNullOrEmpty(mskTextBoxNumDocCedente.Text.Trim().ToString()))
            {
                DialogResult dialogResult = MessageBox.Show("Verifique se TODOS os campos foram preenchidos!",
                   "Campos obrigat�rios n�o preenchidos!", MessageBoxButtons.OK);

            }
            else
            {
                if (comboLeiaute.Text == "TotalBanco" && check == 0)
                {
                    MontaArquivo ma = new MontaArquivo();
                    //ma.GravaArquivo();            
                    ma.GravaArquivoV2(/*Int32.Parse(mskTextBoxDataInclusao.Text.ToString())*/ DateTime.Parse(mskTextBoxDataInclusao.Text),
                        Convert.ToInt64(mskTextBoxSeuNumero.Text),
                        /*Int32.Parse(mskTextBoxDataVencimento.Text.ToString())*/ DateTime.Parse(mskTextBoxDataVencimento.Text),
                        Int32.Parse(mskTextBoxLinhasArquivo.Text.ToString()),
                        //Int32.Parse(mskTextBoxSequencialArq.Text.ToString()),
                        Int32.Parse(mskTextBoxQtdArquivos.Text.ToString()),
                        mskTextBoxConvenio.Text.ToString(),
                        mskTextBoxContaCedente.Text.ToString(),
                        mskTextBoxAgCedente.Text.ToString(),
                        textBoxDiretorioDestino.Text.ToString(),
                        Convert.ToInt64(mskTextBoxNumDocCedente.Text.ToString()),
                        mskBancoCobrador.Text.ToString(),
                        mskTextBoxCarteira.Text.ToString(),
                        textBoxCodCliente.Text.ToString(),
                        mskTextBoxEmpresa.Text.ToString());

                    String conveniado = comboConvenios.Text.ToString().Substring(0, 12);
                    LeitorArquivoParametros leitor = new LeitorArquivoParametros();
                    List<string> lista = new List<string>();
                    lista = leitor.BuscaParametroConveniado(conveniado);
                    //mskTextBoxSequencialArq.Text = lista[0].Trim().ToString().PadLeft(5,'0');
                    mskTextBoxSeuNumero.Text = lista[1].ToString();
                    mskTextBoxDataInclusao.Text = lista[2].ToString();
                    mskTextBoxDataVencimento.Text = lista[3].ToString();
                    mskTextBoxLinhasArquivo.Text = lista[4].ToString().Trim().PadLeft(6, '0');
                    mskTextBoxQtdArquivos.Text = lista[5].ToString().PadLeft(6, '0');
                    mskTextBoxConvenio.Text = lista[6].ToString();
                    mskTextBoxContaCedente.Text = lista[7].ToString();
                    mskTextBoxAgCedente.Text = lista[8].ToString();
                    textBoxDiretorioDestino.Text = lista[9].ToString();
                    mskTextBoxNumDocCedente.Text = lista[10].ToString();
                    mskBancoCobrador.Text = lista[11].ToString();
                    mskTextBoxCarteira.Text = lista[12].ToString();

                    comboLeiaute.SelectedIndex = -1;
                    check = 1;


                }
                if (comboLeiaute.Text == "Bradesco" && check == 0)
                {
                    MontaArquivo ma = new MontaArquivo();
                    //ma.GravaArquivo();            
                    ma.GravaArquivoLtBradesco(/*Int32.Parse(mskTextBoxDataInclusao.Text.ToString())*/ DateTime.Parse(mskTextBoxDataInclusao.Text),
                        Convert.ToInt64(mskTextBoxSeuNumero.Text),
                        /*Int32.Parse(mskTextBoxDataVencimento.Text.ToString())*/ DateTime.Parse(mskTextBoxDataVencimento.Text),
                        Int32.Parse(mskTextBoxLinhasArquivo.Text.ToString()),
                        //Int32.Parse(mskTextBoxSequencialArq.Text.ToString()),
                        Int32.Parse(mskTextBoxQtdArquivos.Text.ToString()),
                        mskTextBoxConvenio.Text.ToString(),
                        mskTextBoxContaCedente.Text.ToString(),
                        mskTextBoxAgCedente.Text.ToString(),
                        textBoxDiretorioDestino.Text.ToString(),
                        Convert.ToInt64(mskTextBoxNumDocCedente.Text.ToString()),
                        mskBancoCobrador.Text.ToString(),
                        mskTextBoxCarteira.Text.ToString(),
                        informaSeuNumero,
                        textBoxCodCliente.Text.ToString(),
                        mskTextBoxEmpresa.Text.ToString());

                    String conveniado = comboConvenios.Text.ToString().Substring(0, 12);
                    LeitorArquivoParametros leitor = new LeitorArquivoParametros();
                    List<string> lista = new List<string>();
                    lista = leitor.BuscaParametroConveniado(conveniado);
                    //mskTextBoxSequencialArq.Text = lista[0].Trim().ToString().PadLeft(5,'0');
                    mskTextBoxSeuNumero.Text = lista[1].ToString();
                    mskTextBoxDataInclusao.Text = lista[2].ToString();
                    mskTextBoxDataVencimento.Text = lista[3].ToString();
                    mskTextBoxLinhasArquivo.Text = lista[4].ToString().Trim().PadLeft(6, '0');
                    mskTextBoxQtdArquivos.Text = lista[5].ToString().PadLeft(6, '0');
                    mskTextBoxConvenio.Text = lista[6].ToString();
                    mskTextBoxContaCedente.Text = lista[7].ToString();
                    mskTextBoxAgCedente.Text = lista[8].ToString();
                    textBoxDiretorioDestino.Text = lista[9].ToString();
                    mskTextBoxNumDocCedente.Text = lista[10].ToString();
                    mskBancoCobrador.Text = lista[11].ToString();

                    comboLeiaute.SelectedIndex = -1;
                    check = 1;


                }
                if (comboLeiaute.Text == "Ita�" && check == 0)
                {
                    MontaArquivo ma = new MontaArquivo();
                    //ma.GravaArquivo();            
                    ma.GravaArquivoLtItau(/*Int32.Parse(mskTextBoxDataInclusao.Text.ToString())*/ DateTime.Parse(mskTextBoxDataInclusao.Text),
                        Convert.ToInt64(mskTextBoxSeuNumero.Text),
                        /*Int32.Parse(mskTextBoxDataVencimento.Text.ToString())*/ DateTime.Parse(mskTextBoxDataVencimento.Text),
                        Int32.Parse(mskTextBoxLinhasArquivo.Text.ToString()),
                        /*Int32.Parse(mskTextBoxSequencialArq.Text.ToString()),*/
                        Int32.Parse(mskTextBoxQtdArquivos.Text.ToString()),
                        mskTextBoxConvenio.Text.ToString(),
                        mskTextBoxContaCedente.Text.ToString(),
                        mskTextBoxAgCedente.Text.ToString(),
                        textBoxDiretorioDestino.Text.ToString(),
                        Convert.ToInt64(mskTextBoxNumDocCedente.Text.ToString()),
                        mskBancoCobrador.Text.ToString(),
                        mskTextBoxCarteira.Text.ToString(),
                        textBoxCodCliente.Text.ToString(),
                        mskTextBoxEmpresa.Text.ToString());

                    String conveniado = comboConvenios.Text.ToString().Substring(0, 12);
                    LeitorArquivoParametros leitor = new LeitorArquivoParametros();
                    List<string> lista = new List<string>();
                    lista = leitor.BuscaParametroConveniado(conveniado);
                    //mskTextBoxSequencialArq.Text = lista[0].Trim().ToString().PadLeft(5,'0');
                    mskTextBoxSeuNumero.Text = lista[1].ToString();
                    mskTextBoxDataInclusao.Text = lista[2].ToString();
                    mskTextBoxDataVencimento.Text = lista[3].ToString();
                    mskTextBoxLinhasArquivo.Text = lista[4].ToString().Trim().PadLeft(6, '0');
                    mskTextBoxQtdArquivos.Text = lista[5].ToString().PadLeft(6, '0');
                    mskTextBoxConvenio.Text = lista[6].ToString();
                    mskTextBoxContaCedente.Text = lista[7].ToString();
                    mskTextBoxAgCedente.Text = lista[8].ToString();
                    textBoxDiretorioDestino.Text = lista[9].ToString();
                    mskTextBoxNumDocCedente.Text = lista[10].ToString();
                    mskBancoCobrador.Text = lista[11].ToString();
                    mskTextBoxCarteira.Text = lista[12].ToString();

                    comboLeiaute.SelectedIndex = -1;
                    check = 1;


                }
                else if (check == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Selecione um Layout",
                   "Campos obrigat�rios n�o preenchidos!", MessageBoxButtons.OK);
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mskTextBoxSeuNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDiretorioDestino_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void mskTextBoxNumDocCedente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskTextBoxConvenio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskTextBoxContaCedente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskTextBoxSequencialArq_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboConvenios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bnBuscarDados_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show(comboConvenios.SelectedIndex.ToString());
            //System.Windows.Forms.MessageBox.Show(comboConvenios.Text.ToString());

            if (String.IsNullOrEmpty(comboConvenios.Text.Trim().ToString()))
            {
                DialogResult dialogo = MessageBox.Show("Selecione um Conv�nio", "Verifique o campo Conv�nios Cadastrados", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(comboConvenios.Text.ToString(),
                  "Conv�nio Selecionado", MessageBoxButtons.OK);

                String conveniado = comboConvenios.Text.ToString().Substring(0, 12);
                LeitorArquivoParametros leitor = new LeitorArquivoParametros();

                BuscaDadosBd buscaDados = new BuscaDadosBd();

                List<string> lista = new List<string>();
                lista = leitor.BuscaParametroConveniado(conveniado);
                //mskTextBoxSequencialArq.Text = lista[0].Trim().ToString().PadLeft(5,'0');
                mskTextBoxSeuNumero.Text = lista[1].ToString();
                mskTextBoxDataInclusao.Text = lista[2].ToString();
                mskTextBoxDataVencimento.Text = lista[3].ToString();
                mskTextBoxLinhasArquivo.Text = lista[4].ToString().Trim().PadLeft(6, '0');
                mskTextBoxQtdArquivos.Text = lista[5].ToString().PadLeft(6, '0');
                mskTextBoxConvenio.Text = lista[6].ToString();
                mskTextBoxContaCedente.Text = lista[7].ToString();
                mskTextBoxAgCedente.Text = lista[8].ToString();
                textBoxDiretorioDestino.Text = lista[9].ToString();
                mskTextBoxNumDocCedente.Text = lista[10].ToString();
                mskBancoCobrador.Text = lista[11].ToString();
                mskTextBoxCarteira.Text = lista[12].ToString();
                textBoxCodCliente.Text = lista[13].ToString();
                mskTextBoxEmpresa.Text = lista[14].ToString();

                ConexaoBD conexao = new ConexaoBD();

                //conexao.testaConexao();

                Conta conta = new Conta();
                conta = buscaDados.buscaConta(mskTextBoxContaCedente.Text, 36);
                txtBoxSaldoBloq.Text = conta.saldoBloqueado.ToString();
                txtBoxSaldoBloqJud.Text = conta.saldoBloqueadoJudAdm.ToString("C");
                txtBxSaldoDisponivel.Text = conta.saldoDisponivel.ToString("C");
                //System.Windows.Forms.MessageBox.Show("Saldo Disp: " + conta.saldoDisponivel.ToString("C"));

                List<ExtratoConta> extratoContas = new List<ExtratoConta>();


                extratoContas = buscaDados.buscaExtrato(mskTextBoxContaCedente.Text, Convert.ToInt32(mskTextBoxAgCedente.Text));

                dataGridViewExtrato.Rows.Clear();


                //System.Windows.Forms.MessageBox.Show("Tamanho do array: " + extratoContas.Count);

                //System.Windows.Forms.MessageBox.Show("data lan�amento da posi��o 1: " + extratoContas[1].dataLancamento);



                for (int i = 0; i < extratoContas.Count; i++)
                {
                    dataGridViewExtrato.Rows.Add();
                    dataGridViewExtrato.Rows[i].Cells[0].Value = extratoContas[i].dataLancamento.ToString("dd/MM/yyyy");
                    dataGridViewExtrato.Rows[i].Cells[1].Value = extratoContas[i].valorLancado.ToString("C");
                    dataGridViewExtrato.Rows[i].Cells[2].Value = extratoContas[i].valorSaldo.ToString("C");
                    dataGridViewExtrato.Rows[i].Cells[3].Value = extratoContas[i].descricaoHistorico;
                }



                comboLeiaute.SelectedIndex = -1;

            }
        }

        private void mskBancoCobrador_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Soap_Click(object sender, EventArgs e)
        {
            if (/*String.IsNullOrEmpty(mskTextBoxSequencialArq.Text.Trim().ToString()) ||*/ String.IsNullOrEmpty(mskTextBoxSeuNumero.Text.Trim().ToString()) ||
                String.IsNullOrEmpty(mskTextBoxDataInclusao.Text.Trim().ToString()) || String.IsNullOrEmpty(mskTextBoxDataVencimento.Text.ToString()) ||
                 mskTextBoxDataVencimento.Text.ToString() == "  /  /" || mskTextBoxDataInclusao.Text.ToString() == "  /  /" ||
                String.IsNullOrEmpty(mskTextBoxLinhasArquivo.Text.Trim().ToString()) || String.IsNullOrEmpty(mskTextBoxQtdArquivos.Text.Trim().ToString()) ||
                String.IsNullOrEmpty(mskTextBoxConvenio.Text.Trim().ToString()) || String.IsNullOrEmpty(mskTextBoxContaCedente.Text.Trim().ToString()) ||
                String.IsNullOrEmpty(mskTextBoxAgCedente.Text.Trim().ToString()) || String.IsNullOrEmpty(textBoxDiretorioDestino.Text.Trim().ToString()) ||
                String.IsNullOrEmpty(mskTextBoxNumDocCedente.Text.Trim().ToString()))
            {
                DialogResult dialogResult = MessageBox.Show("Verifique se TODOS os campos foram preenchidos!",
                   "Campos obrigat�rios n�o preenchidos!", MessageBoxButtons.OK);
            }
            else
            {
                ChamadaWs cws = new ChamadaWs();
                //cws.CallWebService();
                cws.CreateSoapEnvelopeBorderoCapaLote(DateTime.Parse(mskTextBoxDataInclusao.Text),
                    textBoxCodCliente.Text.ToString()
                    , Int32.Parse(mskTextBoxLinhasArquivo.Text.ToString())
                    ,/*900.5,*/ Int32.Parse(mskTextBoxSeuNumero.Text.ToString()), DateTime.Parse(mskTextBoxDataVencimento.Text)
                    , Int32.Parse(mskTextBoxAgCedente.Text)
                    , Int32.Parse(mskTextBoxEmpresa.Text));
                MontaArquivo mv = new MontaArquivo();
                mv.GravaArquivo(DateTime.Parse(mskTextBoxDataInclusao.Text),
                            Convert.ToInt64(mskTextBoxSeuNumero.Text),
                            DateTime.Parse(mskTextBoxDataVencimento.Text),
                            Int32.Parse(mskTextBoxLinhasArquivo.Text.ToString()),
                            Int32.Parse(mskTextBoxQtdArquivos.Text.ToString()),
                            mskTextBoxConvenio.Text.ToString(),
                            mskTextBoxContaCedente.Text.ToString(),
                            mskTextBoxAgCedente.Text.ToString(),
                            textBoxDiretorioDestino.Text.ToString(),
                            Convert.ToInt64(mskTextBoxNumDocCedente.Text.ToString()),
                            mskBancoCobrador.Text.ToString(),
                            mskTextBoxCarteira.Text.ToString(),
                            textBoxCodCliente.Text.ToString(),
                            mskTextBoxEmpresa.Text.ToString());


                String conveniado = comboConvenios.Text.ToString().Substring(0, 12);
                LeitorArquivoParametros leitor = new LeitorArquivoParametros();

                List<string> lista = new List<string>();
                lista = leitor.BuscaParametroConveniado(conveniado);
                //mskTextBoxSequencialArq.Text = lista[0].Trim().ToString().PadLeft(5,'0');
                mskTextBoxSeuNumero.Text = lista[1].ToString();
                mskTextBoxDataInclusao.Text = lista[2].ToString();
                mskTextBoxDataVencimento.Text = lista[3].ToString();
                mskTextBoxLinhasArquivo.Text = lista[4].ToString().Trim().PadLeft(6, '0');
                mskTextBoxQtdArquivos.Text = lista[5].ToString().PadLeft(6, '0');
                mskTextBoxConvenio.Text = lista[6].ToString();
                mskTextBoxContaCedente.Text = lista[7].ToString();
                mskTextBoxAgCedente.Text = lista[8].ToString();
                textBoxDiretorioDestino.Text = lista[9].ToString();
                mskTextBoxNumDocCedente.Text = lista[10].ToString();
                mskBancoCobrador.Text = lista[11].ToString();
                mskTextBoxCarteira.Text = lista[12].ToString();
                textBoxCodCliente.Text = lista[13].ToString();
                mskTextBoxEmpresa.Text = lista[14].ToString();

                comboLeiaute.SelectedIndex = -1;

            }
        }

        private void textBoxCodCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnConfigServerWs_Click(object sender, EventArgs e)
        {
            FormConfigServidorWS formConfigServidorWS = new FormConfigServidorWS();
            formConfigServidorWS.ShowDialog();
        }

        private void btnTesteTelaBord_Click(object sender, EventArgs e)
        {
            FormBorderoDetalhe formBorderoDetalhe = new FormBorderoDetalhe();
            formBorderoDetalhe.ShowDialog();

        }


        private void txtBoxSaldoBloq_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxSaldoBloqJud_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBxSaldoDisponivel_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewExtrato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxValorLancado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLancarValor_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxValorLancado.Text.Trim().ToString()) || String.IsNullOrEmpty(textBoxHistorico.Text.Trim().ToString()) ||
                String.IsNullOrEmpty(textBoxValorLancado.Text.Trim().ToString()))
            {
                DialogResult dialogResult = MessageBox.Show("Verifique se TODOS os campos foram preenchidos!",
                   "Campos obrigat�rios n�o preenchidos!", MessageBoxButtons.OK);

            }
            else
            {
                bool persistiu;

                string numeroConta = mskTextBoxContaCedente.Text.ToString();
                int historico = Convert.ToInt32(textBoxHistorico.Text);
                double valorLancado = Convert.ToDouble(textBoxValorLancado.Text);
                string numeroDoc = textBoxNumDoc.Text.ToString();
                int agencia = Convert.ToInt32(mskTextBoxAgCedente.Text);

                PersisteDadosBd persisteDadosBd = new PersisteDadosBd();
                persistiu = persisteDadosBd.insereMovimentoConta(agencia, numeroConta, historico, valorLancado, numeroDoc);

                if (persistiu == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Lan�amento realizado com sucesso!",
                       "Informa��o", MessageBoxButtons.OK);

                    BuscaDadosBd buscaDados = new BuscaDadosBd();
                    ConexaoBD conexao = new ConexaoBD();

                    //conexao.testaConexao();

                    Conta conta = new Conta();
                    conta = buscaDados.buscaConta(mskTextBoxContaCedente.Text, Convert.ToInt32(mskTextBoxAgCedente.Text));
                    txtBoxSaldoBloq.Text = conta.saldoBloqueado.ToString("C");
                    txtBoxSaldoBloqJud.Text = conta.saldoBloqueadoJudAdm.ToString("C");
                    txtBxSaldoDisponivel.Text = conta.saldoDisponivel.ToString("C");


                    List<ExtratoConta> extratoContas = new List<ExtratoConta>();

                    extratoContas = buscaDados.buscaExtrato(mskTextBoxContaCedente.Text, Convert.ToInt32(mskTextBoxAgCedente.Text));

                    dataGridViewExtrato.Rows.Clear();
                    textBoxValorLancado.Clear();
                    //System.Windows.Forms.MessageBox.Show("Tamanho do array: " + extratoContas.Count);
                    //System.Windows.Forms.MessageBox.Show("data lan�amento da posi��o 1: " + extratoContas[1].dataLancamento);

                    for (int i = 0; i < extratoContas.Count; i++)
                    {
                        dataGridViewExtrato.Rows.Add();
                        dataGridViewExtrato.Rows[i].Cells[0].Value = extratoContas[i].dataLancamento.ToString("dd/MM/yyyy");
                        dataGridViewExtrato.Rows[i].Cells[1].Value = extratoContas[i].valorLancado.ToString("C");
                        dataGridViewExtrato.Rows[i].Cells[2].Value = extratoContas[i].valorSaldo.ToString("C");
                        dataGridViewExtrato.Rows[i].Cells[3].Value = extratoContas[i].descricaoHistorico;
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Informa��o",
                       "Ocorreu um erro ao realizar o lan�amento", MessageBoxButtons.OK);

                }
            }

        }


        private void linkLabelHistorico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormListaHistoricos historicos = new FormListaHistoricos();

            historicos.ShowDialog();
        }

        private void btnConfigModalidade_Click(object sender, EventArgs e)
        {
            FormConfigModalidade formConfigModalidade = new FormConfigModalidade();
            formConfigModalidade.ShowDialog();
        }

        private void mskTextBoxAgCedente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            v formCliente = new v();
            formCliente.ShowDialog();
        }

        private void mskTextBoxEmpresa_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
