namespace Gerador_de_Remessa_Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = String.Format("Gerador de Remessa Cliente (Versão {0})", version);           

            LeitorArquivoParametros leitor = new LeitorArquivoParametros();

            List<String> comboCvns = new List<String>();
            comboCvns = leitor.buscaConvenios();            

            for (int i = 0; i < comboCvns.Count; i++)
            {
                comboConvenios.Items.Add(comboCvns[i]);                
            }            

          
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
            }

            //mskTextBoxSequencialArq.Text = lista[0].Trim().ToString().PadLeft(5,'0');
           
        }

        private void btnGerarArquivo_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (/*String.IsNullOrEmpty(mskTextBoxSequencialArq.Text.Trim().ToString()) ||*/ String.IsNullOrEmpty(mskTextBoxSeuNumero.Text.Trim().ToString()) ||
                String.IsNullOrEmpty(mskTextBoxDataInclusao.Text.Trim().ToString()) || String.IsNullOrEmpty(mskTextBoxDataVencimento.Text.ToString()) ||
                 mskTextBoxDataVencimento.Text.ToString() == "  /  /" || mskTextBoxDataInclusao.Text.ToString() == "  /  /" ||
                String.IsNullOrEmpty(mskTextBoxLinhasArquivo.Text.Trim().ToString()) || String.IsNullOrEmpty(mskTextBoxQtdArquivos.Text.Trim().ToString()) ||
                String.IsNullOrEmpty(mskTextBoxConvenio.Text.Trim().ToString()) || String.IsNullOrEmpty(mskTextBoxContaCedente.Text.Trim().ToString()) ||
                String.IsNullOrEmpty(mskTextBoxAgCedente.Text.Trim().ToString()) || String.IsNullOrEmpty(textBoxDiretorioDestino.Text.Trim().ToString()) ||
                String.IsNullOrEmpty(mskTextBoxNumDocCedente.Text.Trim().ToString()))
            {
                DialogResult dialogResult = MessageBox.Show("Verifique se TODOS os campos foram preenchidos!",
                   "Campos obrigatórios não preenchidos!", MessageBoxButtons.OK);

            } else
            {
                if (comboLeiaute.Text == "TotalBanco" || check == 0)
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
                        Convert.ToInt64(mskTextBoxNumDocCedente.Text.ToString()));

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

                    comboLeiaute.SelectedIndex = -1;
                    check = 1;
                    

                }
                if (comboLeiaute.Text == "Itaú" || check == 0)
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
                        Convert.ToInt64(mskTextBoxNumDocCedente.Text.ToString()));

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

                    comboLeiaute.SelectedIndex = -1;
                    check = 1;
                    

                } else if(check == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Selecione um Layout" ,
                   "Campos obrigatórios não preenchidos!", MessageBoxButtons.OK);
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

            DialogResult dialogResult = MessageBox.Show(comboConvenios.Text.ToString(),
                   "Convênio Selecionado", MessageBoxButtons.OK);

            String conveniado = comboConvenios.Text.ToString().Substring(0,12);
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



        }
    }
}