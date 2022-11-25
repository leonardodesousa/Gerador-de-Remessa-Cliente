using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Remessa_Cliente
{
    internal class MontaArquivo
    {
        public void GravaArquivoV2(DateTime DataRecebimento, long SeuNUmero, DateTime DataVencimento, int linhasPorArquivo, int numeroArquivo, int quantidadeDeArquivos, String Convenio, String Conta, String AgenciaCedente, String diretorio, long numeroDocumentoCedente)
        {
            // dataRecebimento ddmmaa
            // dataVencimento ddmmaa

            string dataRecebimentoFormatada = DateTime.Parse(DataRecebimento.ToString()).ToString("ddMMyy");
            string dataVencimentoFormatada = DateTime.Parse(DataVencimento.ToString()).ToString("ddMMyy");


            Console.WriteLine("GravaArquivo");
            //long numeroDocumentoCedente = 59579284000165;
            int identificadorTipoDocumento; // 1=cnpj; 2=cpf 
            BigInteger Valor; // 7525 = 75,25 Reais 
            int Linha = 2; //linha do arquivo            
            Random randNum = new Random();
            Valor = randNum.Next(500,1000000); // Boleto mínimo 5 reais; máximo 10.000 reais
            //diretorio = diretorio + "\\";

            if (numeroDocumentoCedente.ToString().Length > 11)
            {
                identificadorTipoDocumento = 1;
            } else
            {
                identificadorTipoDocumento = 2;
            }


            //System.Windows.Forms.MessageBox.Show("Diretorio recebe " + diretorio.Substring(diretorio.Length - 4, 4));
            if (diretorio.Substring(diretorio.Length - 2, 2) != "\\\\")
            {
                diretorio = diretorio + "\\";
            }
            

            for (int j = 0; j < quantidadeDeArquivos; j++)
            {
                String path = @diretorio +"r00" + numeroArquivo + ".rem";

                String Header = "01REMESSA01COBRANCA       " + Convenio + "        Tech 2 Market T2m             653BANCO SMARTBANK"
                              + dataRecebimentoFormatada + "                                      " +
                              "                                                          " +
                              "                                                          " +
                              "                                                          " +
                              "                                                                             00000000001";
                // if (!File.Exists(path))
                //{
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(Header);
                    // while aqui 
                    for (int i = 0; i < linhasPorArquivo; i++)
                    {
                        sw.WriteLine("10"+ identificadorTipoDocumento.ToString() + numeroDocumentoCedente.ToString().PadLeft(14,'0') + AgenciaCedente + Conta + "                                         " + SeuNUmero.ToString().PadLeft(12, '0')
                        + "                         101" + SeuNUmero.ToString().PadLeft(10, '0') + dataVencimentoFormatada + "000" + Valor.ToString().PadLeft(10, '0')
                        + "6300000001N" + dataRecebimentoFormatada
                        + "000000000030000000000000000000000000000000000000000000000000100100006067139995Felipe de Liz Martins                   Rua Antonio Pietruza                                80610320Curitiba       PR                                        0010"
                        + Linha.ToString().PadLeft(5, '0'));
                        //Valor = Valor + 125; //2025
                        Valor = randNum.Next(500, 1000000);
                        Linha++;
                        SeuNUmero++;
                    }
                    sw.WriteLine("9                                                                                                                                       " +
                        "                                                                                                                                                 " +
                        "                                                                                                                 0" + Linha.ToString().PadLeft(5, '0'));
                    numeroArquivo++;
                    // fim do while                        
                }
                //}
                Linha = 2;

            }
            //String path2 = @"c:\Temp\rem\info_" + DateTime.Now.ToString("dd-MM-yyyyHH-mm-ss") + ".txt";
            String path2 = @"C:\TotalBanco\Crediblaster\GeraRem\GeraRem.ini";
            using (StreamWriter sw = File.CreateText(path2))
            {                
                sw.WriteLine("NUMERO_ARQUIVO=" + numeroArquivo);
                sw.WriteLine("SEU_NUMERO=" + SeuNUmero.ToString().PadLeft(10, '0'));
                sw.WriteLine("DATA_RECEBIMENTO=" + DateTime.Parse(DataRecebimento.ToString()).ToString("dd/MM/yyyy")); 
                sw.WriteLine("DATA_VENCIMENTO=" + DateTime.Parse(DataVencimento.ToString()).ToString("dd/MM/yyyy")); 
                sw.WriteLine("LINHAS_POR_ARQUIVO=" + linhasPorArquivo.ToString());
                sw.WriteLine("QUANTIDADE_DE_ARQUIVOS=" + quantidadeDeArquivos.ToString());
                sw.WriteLine("CONVENIO=" + Convenio.ToString());
                sw.WriteLine("CONTA_CEDENTE=" + Conta.ToString());
                sw.WriteLine("AGENCIA_CEDENTE=" + AgenciaCedente.ToString());
                sw.WriteLine("DIRETORIO_DESTINO=" + diretorio.ToString());
                sw.WriteLine("DOCUMENTO_CEDENTE=" + numeroDocumentoCedente.ToString());

            }
            System.Windows.Forms.MessageBox.Show("Terminou!");
        }
        public void GravaArquivo()
        {
            Console.WriteLine("GravaArquivo");
            int DataRecebimento = 160922;
            int SeuNUmero = 45777282;
            int DataVencimento = 171022;
            BigInteger Valor = 7525; //000 zeros a esquerda 
            String Convenio = "019011650001";
            String Conta = "9011650001";
            int AgenciaCedente = 36;
            int Linha = 2;
            int cont = 20; // número de linhas por arquivo
            int numeroArquivo = 450;
            int quantidadeDeArquivos = 10;

            for (int j = 0; j < quantidadeDeArquivos; j++)
            {
                String path = @"c:\Temp\rem\r00" + numeroArquivo + ".rem";

                String Header = "01REMESSA01COBRANCA       " + Convenio + "        Tech 2 Market T2m             653BANCO SMARTBANK"
                              + DataRecebimento + "                                      " +
                              "                                                          " +
                              "                                                          " +
                              "                                                          " +
                              "                                                                             00000000001";
               // if (!File.Exists(path))
                //{
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine(Header);
                        // while aqui 
                        for (int i = 0; i < cont; i++)
                        {
                            sw.WriteLine("10100006067139995" + AgenciaCedente + Conta + "                                         " + SeuNUmero.ToString().PadLeft(12, '0')
                            + "                         101" + SeuNUmero.ToString().PadLeft(10, '0') + DataVencimento + "000" + Valor.ToString().PadLeft(10, '0')
                            + "6300000001N" + DataRecebimento
                            + "000000000030000000000000000000000000000000000000000000000000100100006067139995Felipe de Liz Martins                   Rua Antonio Pietruza                                80610320Curitiba       PR                                        0010"
                            + Linha.ToString().PadLeft(5, '0'));
                            Valor = Valor + 125; //2025
                            Linha++;
                            SeuNUmero++;
                        }
                        sw.WriteLine("9                                                                                                                                       " +
                            "                                                                                                                                                 " +
                            "                                                                                                                 0" + Linha.ToString().PadLeft(5, '0'));
                        numeroArquivo++;
                        // fim do while                        
                    }
                //}
                Linha = 2;
               
            }
            //String path2 = @"c:\Temp\rem\info_" + DateTime.Now.ToString("dd-MM-yyyyHH-mm-ss") + ".txt";
            String path2 = @"C:\TotalBanco\Crediblaster\GeraRem\GeraRem.ini";
            using (StreamWriter sw = File.CreateText(path2))
            {                
                sw.WriteLine("NUMERO_ARQUIVO=" + numeroArquivo);
                sw.WriteLine("SEU_NUMERO=" + SeuNUmero.ToString().PadLeft(10, '0'));
                sw.WriteLine("DATA_RECEBIMENTO=" + DataRecebimento.ToString());
                sw.WriteLine("DATA_VENCIMENTO=" + DataVencimento.ToString());
                sw.WriteLine("LINHAS_POR_ARQUIVO=" + cont.ToString());
                sw.WriteLine("QUANTIDADE_DE_ARQUIVOS=" + quantidadeDeArquivos.ToString());                
            }
            System.Windows.Forms.MessageBox.Show("Terminou!");
        }

    }
}
