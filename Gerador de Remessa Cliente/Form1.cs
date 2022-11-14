namespace Gerador_de_Remessa_Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = String.Format("Gerador de Remessa Cliente - Letsbank (Versão {0})", version);
            

            LeitorArquivoParametros leitor = new LeitorArquivoParametros();
            List<string> lista = new List<string>();
            lista = leitor.BuscaParametros();
            mskTextBoxSequencialArq.Text = lista[0].ToString();
            mskTextBoxSeuNumero.Text = lista[1].ToString();
            mskTextBoxDataInclusao.Text = lista[2].ToString();
            mskTextBoxDataVencimento.Text = lista[3].ToString();
            mskTextBoxLinhasArquivo.Text = lista[4].ToString();
            mskTextBoxQtdArquivos.Text = lista[5].ToString();            
            mskTextBoxConvenio.Text = lista[6].ToString();
            mskTextBoxContaCedente.Text = lista[7].ToString();
            mskTextBoxAgCedente.Text = lista[8].ToString();
            textBoxDiretorioDestino.Text = lista[9].ToString();
            mskTextBoxNumDocCedente.Text = lista[10].ToString();
        }

        private void btnGerarArquivo_Click(object sender, EventArgs e)
        {
            MontaArquivo ma = new MontaArquivo();
            //ma.GravaArquivo();            
            ma.GravaArquivoV2(Int32.Parse(mskTextBoxDataInclusao.Text.ToString()),                
                Convert.ToInt64(mskTextBoxSeuNumero.Text),
                Int32.Parse(mskTextBoxDataVencimento.Text.ToString()),
                Int32.Parse(mskTextBoxLinhasArquivo.Text.ToString()),
                Int32.Parse(mskTextBoxSequencialArq.Text.ToString()),
                Int32.Parse(mskTextBoxQtdArquivos.Text.ToString()),
                mskTextBoxConvenio.Text.ToString(),
                mskTextBoxContaCedente.Text.ToString(),
                mskTextBoxAgCedente.Text.ToString(),
                textBoxDiretorioDestino.Text.ToString(),
                Convert.ToInt64(mskTextBoxNumDocCedente.Text.ToString()));

            LeitorArquivoParametros leitor = new LeitorArquivoParametros();
            List<string> lista = new List<string>();
            lista = leitor.BuscaParametros();
            mskTextBoxSequencialArq.Text = lista[0].ToString();
            mskTextBoxSeuNumero.Text = lista[1].ToString();
            mskTextBoxDataInclusao.Text = lista[2].ToString();
            mskTextBoxDataVencimento.Text = lista[3].ToString();
            mskTextBoxLinhasArquivo.Text = lista[4].ToString();
            mskTextBoxQtdArquivos.Text = lista[5].ToString();
            mskTextBoxConvenio.Text = lista[6].ToString();
            mskTextBoxContaCedente.Text = lista[7].ToString();
            mskTextBoxAgCedente.Text = lista[8].ToString();
            textBoxDiretorioDestino.Text = lista[9].ToString();
            mskTextBoxNumDocCedente.Text = lista[10].ToString();
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
    }
}