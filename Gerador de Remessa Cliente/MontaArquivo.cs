using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Remessa_Cliente
{
    internal class MontaArquivo
    {
        public void GravaArquivoLtBradesco(DateTime DataRecebimento, long SeuNumero, DateTime DataVencimento, int linhasPorArquivo, /*int numeroArquivo,*/ int quantidadeDeArquivos, String Convenio, String Conta, String AgenciaCedente, String diretorio, long numeroDocumentoCedente, String bancoCobrador, String carteira, Boolean informaSeuNumero, string codigoCliente, String empresa)
        {
            // dataRecebimento ddmmaa
            // dataVencimento ddmmaa

            int numeroArquivo = 1;
            String strSeuNumero;

            string dataRecebimentoFormatada = DateTime.Parse(DataRecebimento.ToString()).ToString("ddMMyy");
            string dataVencimentoFormatada = DateTime.Parse(DataVencimento.ToString()).ToString("ddMMyy");


            Console.WriteLine("GravaArquivo");
            //long numeroDocumentoCedente = 59579284000165;
            int identificadorTipoDocumento; // 2=cnpj; 1=cpf 
            BigInteger Valor; // 7525 = 75,25 Reais 
            int Linha = 2; //linha do arquivo            
            Random randNum = new Random();
            Valor = randNum.Next(1000, 300000); // Boleto mínimo 10 reais; máximo 3.000 reais
            //diretorio = diretorio + "\\";

            if (numeroDocumentoCedente.ToString().Length > 11)
            {
                identificadorTipoDocumento = 1;
            }
            else
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
                //String path = @diretorio + "r00" + numeroArquivo + ".rem";
                String path = @diretorio + Conta.Substring(0, 6) + DateTime.Now.ToString("ddMMyyyyHHmmss") + numeroArquivo + ".rem";


                String Header = "01REMESSA01COBRANCA       " + Convenio + "        Layout Bradesco               " + bancoCobrador + "BANCO SMARTBANK"
                              + dataRecebimentoFormatada + "                                       " +
                              "                                                                    " +
                              "                                                                    " +                             
                              "                                                        " +
                              "                                                          00000000001";
                // if (!File.Exists(path))
                //{
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(Header);
                    // while aqui 
                    for (int i = 0; i < linhasPorArquivo; i++)
                    {
                        if(informaSeuNumero == true)
                        {
                            strSeuNumero = SeuNumero.ToString().PadLeft(10, '0');
                        }
                        else
                        {
                            strSeuNumero = "          ";
                        }
                        sw.WriteLine("10" + identificadorTipoDocumento.ToString() + numeroDocumentoCedente.ToString().PadLeft(14, '0') + "0000" + carteira + "00" + AgenciaCedente.PadLeft(3,'0') + Conta.Substring(2, 8).PadLeft(6, '0') + Conta.Substring(0, 6).PadLeft(8, '0') + "                 " + "0002020000000000000000000000001" + "               " + "01" 
                            /*+ SeuNumero.ToString().PadLeft(10, '0')*/
                        + strSeuNumero
                        + dataVencimentoFormatada + "000" + Valor.ToString().PadLeft(10, '0')
                        + "0000000001N" + dataRecebimentoFormatada
                        //+ "000000000030000000000000000000000000000000000000000000000000100100006067139995Felipe de Liz Martins                   Rua Antonio Pietruza                                80610320Curitiba       PR                                        0010"
                        +"000000000000006220000000000000000000000000000000000000000000000100006067139995Felipe de Liz Martins                   Rua Antonio Pietruza                                80610320Curitiba       PR                                        0010"
                        + Linha.ToString().PadLeft(5, '0'));
                        //Valor = Valor + 125; //2025
                        //Valor = randNum.Next(500, 1000000);
                        Valor = randNum.Next(1000, 300000);
                        Linha++;
                        if(informaSeuNumero == true)
                        {
                            SeuNumero++;
                        }                        
                    }
                    sw.WriteLine("9                                                                                                                             " +
                        "                                                                                                                                      " +
                        "                                                                                                                                      0" + Linha.ToString().PadLeft(5, '0'));
                    numeroArquivo++;
                    // fim do while                        
                }
                //}
                Linha = 2;

            }
            //String path2 = @"c:\Temp\rem\info_" + DateTime.Now.ToString("dd-MM-yyyyHH-mm-ss") + ".txt";
            //String path2 = @"C:\TotalBanco\Crediblaster\GeraRem\GeraRem.ini";
            String path2 = @"C:\TotalBanco\Crediblaster\GeraRem\Clientes\Convenios\" + Convenio + ".ini";
            using (StreamWriter sw = File.CreateText(path2))
            {
                sw.WriteLine("NUMERO_ARQUIVO=" + numeroArquivo);
                sw.WriteLine("SEU_NUMERO=" + SeuNumero.ToString().PadLeft(10, '0'));
                sw.WriteLine("DATA_RECEBIMENTO=" + DateTime.Parse(DataRecebimento.ToString()).ToString("dd/MM/yyyy"));
                sw.WriteLine("DATA_VENCIMENTO=" + DateTime.Parse(DataVencimento.ToString()).ToString("dd/MM/yyyy"));
                sw.WriteLine("LINHAS_POR_ARQUIVO=" + linhasPorArquivo.ToString());
                sw.WriteLine("QUANTIDADE_DE_ARQUIVOS=" + quantidadeDeArquivos.ToString());
                sw.WriteLine("CONVENIO=" + Convenio.ToString());
                sw.WriteLine("CONTA_CEDENTE=" + Conta.ToString());
                sw.WriteLine("AGENCIA_CEDENTE=" + AgenciaCedente.ToString());
                sw.WriteLine("DIRETORIO_DESTINO=" + diretorio.ToString());
                sw.WriteLine("DOCUMENTO_CEDENTE=" + numeroDocumentoCedente.ToString());
                sw.WriteLine("BANCO_COBRADOR=" + bancoCobrador.ToString());
                sw.WriteLine("CARTEIRA=" + carteira.ToString());
                sw.WriteLine("COD_CLIENTE=" + codigoCliente.ToString());
                sw.WriteLine("EMPRESA=" + empresa.ToString());


            }
            System.Windows.Forms.MessageBox.Show("Terminou!");
        }

        public void GravaArquivoLtItau(DateTime DataRecebimento, long SeuNUmero, DateTime DataVencimento, int linhasPorArquivo, /*int numeroArquivo,*/ int quantidadeDeArquivos, String Convenio, String Conta, String AgenciaCedente, String diretorio, long numeroDocumentoCedente, String bancoCobrador, String carteira, string codigoCliente, String empresa)
        {
            // dataRecebimento ddmmaa
            // dataVencimento ddmmaa

            int numeroArquivo = 1;

            string dataRecebimentoFormatada = DateTime.Parse(DataRecebimento.ToString()).ToString("ddMMyy");
            string dataVencimentoFormatada = DateTime.Parse(DataVencimento.ToString()).ToString("ddMMyy");


            Console.WriteLine("GravaArquivo");
            //long numeroDocumentoCedente = 59579284000165;
            int identificadorTipoDocumento; // 2=cnpj; 1=cpf 
            BigInteger Valor; // 7525 = 75,25 Reais 
            int Linha = 2; //linha do arquivo            
            Random randNum = new Random();
            Valor = randNum.Next(1000, 300000); // Boleto mínimo 10 reais; máximo 3.000 reais
            //diretorio = diretorio + "\\";

            if (numeroDocumentoCedente.ToString().Length > 11)
            {
                identificadorTipoDocumento = 1;
            }
            else
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
                //String path = @diretorio + "r00" + numeroArquivo + ".rem";
                String path = @diretorio + Conta.Substring(0, 6) + DateTime.Now.ToString("ddMMyyyyHHmmss") + numeroArquivo + ".rem";


                String Header = "01REMESSA01COBRANCA       " + Convenio + "        Layout Itau                   "+ bancoCobrador + "BANCO SMARTBANK"
                              + dataRecebimentoFormatada + "                 " +
                              "                                                                 " +
                              "                                                                 " +
                              "                                                                 " +
                              "                                                                             00000000001";
                // if (!File.Exists(path))
                //{
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(Header);
                    // while aqui 
                    for (int i = 0; i < linhasPorArquivo; i++)
                    {
                        sw.WriteLine("10" + identificadorTipoDocumento.ToString() + numeroDocumentoCedente.ToString().PadLeft(14, '0') + AgenciaCedente.PadLeft(4, '0') + Conta.PadRight(16, ' ') + Conta.Substring(0,6).PadLeft(7,'0') + "                  " + "000000000000000000000"+ carteira + "                     " + "001"  + SeuNUmero.ToString().PadLeft(7, '0')
                        + "   "  + dataVencimentoFormatada + "000" + Valor.ToString().PadLeft(10, '0')
                        + "6300000001N" + dataRecebimentoFormatada
                        + "000000000000000000000000000000000000000000000000000000000000100100006067139995Felipe de Liz Martins                   Rua Antonio Pietruza                                80610320Curitiba       PR                                        0010"
                        + Linha.ToString().PadLeft(5, '0'));
                        //Valor = Valor + 125; //2025
                        //Valor = randNum.Next(500, 1000000);
                        Valor = randNum.Next(1000, 300000);
                        Linha++;
                        SeuNUmero++;
                    }
                    sw.WriteLine("9                                                                                                                                       " +
                        "                                                                                                                                 " +
                        "                                                                                                                                 0" + Linha.ToString().PadLeft(5, '0'));
                    numeroArquivo++;
                    // fim do while                        
                }
                //}
                Linha = 2;

            }
            //String path2 = @"c:\Temp\rem\info_" + DateTime.Now.ToString("dd-MM-yyyyHH-mm-ss") + ".txt";
            //String path2 = @"C:\TotalBanco\Crediblaster\GeraRem\GeraRem.ini";
            String path2 = @"C:\TotalBanco\Crediblaster\GeraRem\Clientes\Convenios\" + Convenio +".ini";
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
                sw.WriteLine("BANCO_COBRADOR=" + bancoCobrador.ToString());
                sw.WriteLine("CARTEIRA=" + carteira.ToString());
                sw.WriteLine("COD_CLIENTE=" + codigoCliente.ToString());
                sw.WriteLine("EMPRESA=" + empresa.ToString());

            }
            System.Windows.Forms.MessageBox.Show("Terminou!");
        }

        public void GravaArquivoV2(DateTime DataRecebimento, long SeuNUmero, DateTime DataVencimento, int linhasPorArquivo, /*int numeroArquivo,*/ int quantidadeDeArquivos, String Convenio, String Conta, String AgenciaCedente, String diretorio, long numeroDocumentoCedente, String bancoCobrador, String carteira, string codigoCliente, String empresa)
        {
            // dataRecebimento ddmmaa
            // dataVencimento ddmmaa
            int numeroArquivo = 1;

            string dataRecebimentoFormatada = DateTime.Parse(DataRecebimento.ToString()).ToString("ddMMyy");
            string dataVencimentoFormatada = DateTime.Parse(DataVencimento.ToString()).ToString("ddMMyy");


            Console.WriteLine("GravaArquivo");
            //long numeroDocumentoCedente = 59579284000165;
            int identificadorTipoDocumento; // 1=cnpj; 2=cpf 
            BigInteger Valor; // 7525 = 75,25 Reais 
            int Linha = 2; //linha do arquivo            
            Random randNum = new Random();
            Valor = randNum.Next(1000, 300000); // Boleto mínimo 5 reais; máximo 3.000 reais
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
                //String path = @diretorio +"r00" + numeroArquivo + ".rem";
                String path = @diretorio + Conta.Substring(0, 6) + DateTime.Now.ToString("ddMMyyyyHHmmss") + numeroArquivo + ".rem";

                String Header = "01REMESSA01COBRANCA       " + Convenio + "        Layout TotalBanco             "+ bancoCobrador + "BANCO SMARTBANK"
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
                        + "                         1"+ carteira.Substring(1,2) + SeuNUmero.ToString().PadLeft(10, '0') + dataVencimentoFormatada + "000" + Valor.ToString().PadLeft(10, '0')
                        + "6300000001N" + dataRecebimentoFormatada
                        + "000000000030000000000000000000000000000000000000000000000000100100006067139995Felipe de Liz Martins                   Rua Antonio Pietruza                                80610320Curitiba       PR                                        0010"
                        + Linha.ToString().PadLeft(5, '0'));
                        //Valor = Valor + 125; //2025
                        Valor = randNum.Next(1000, 300000);
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
            //String path2 = @"C:\TotalBanco\Crediblaster\GeraRem\GeraRem.ini";
            String path2 = @"C:\TotalBanco\Crediblaster\GeraRem\Clientes\Convenios\" + Convenio + ".ini";
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
                sw.WriteLine("BANCO_COBRADOR=" + bancoCobrador.ToString());
                sw.WriteLine("CARTEIRA=" + carteira.ToString());
                sw.WriteLine("COD_CLIENTE=" + codigoCliente.ToString());
                sw.WriteLine("EMPRESA=" + empresa.ToString());

            }
            System.Windows.Forms.MessageBox.Show("Terminou!");
        }
        public void GravaArquivo(DateTime DataRecebimento, long SeuNUmero, DateTime DataVencimento, int linhasPorArquivo, int quantidadeDeArquivos, String Convenio, String Conta, String AgenciaCedente, String diretorio, long numeroDocumentoCedente, String bancoCobrador, String carteira, string codigoCliente, String empresa)
        {
            // dataRecebimento ddmmaa
            // dataVencimento ddmmaa
            int numeroArquivo = 1;

            string dataRecebimentoFormatada = DateTime.Parse(DataRecebimento.ToString()).ToString("ddMMyy");
            string dataVencimentoFormatada = DateTime.Parse(DataVencimento.ToString()).ToString("ddMMyy");


            Console.WriteLine("GravaArquivo");
            //long numeroDocumentoCedente = 59579284000165;
            int identificadorTipoDocumento; // 1=cnpj; 2=cpf 
            BigInteger Valor; // 7525 = 75,25 Reais 
            int Linha = 2; //linha do arquivo            
            Random randNum = new Random();
            Valor = randNum.Next(1000, 300000); // Boleto mínimo 5 reais; máximo 3.000 reais
            //diretorio = diretorio + "\\";

            if (numeroDocumentoCedente.ToString().Length > 11)
            {
                identificadorTipoDocumento = 1;
            }
            else
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
                //String path = @diretorio +"r00" + numeroArquivo + ".rem";
                String path = @diretorio + Conta.Substring(0, 6) + DateTime.Now.ToString("ddMMyyyyHHmmss") + numeroArquivo + ".rem";

                String Header = "01REMESSA01COBRANCA       " + Convenio + "        Layout TotalBanco             " + bancoCobrador + "BANCO SMARTBANK"
                              + dataRecebimentoFormatada + "                                      " +
                              "                                                          " +
                              "                                                          " +
                              "                                                          " +
                              "                                                                             00000000001";                

                SeuNUmero = SeuNUmero + linhasPorArquivo;
            }
            //String path2 = @"c:\Temp\rem\info_" + DateTime.Now.ToString("dd-MM-yyyyHH-mm-ss") + ".txt";
            //String path2 = @"C:\TotalBanco\Crediblaster\GeraRem\GeraRem.ini";
            String path2 = @"C:\TotalBanco\Crediblaster\GeraRem\Clientes\Convenios\" + Convenio + ".ini";
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
                sw.WriteLine("BANCO_COBRADOR=" + bancoCobrador.ToString());
                sw.WriteLine("CARTEIRA=" + carteira.ToString());
                sw.WriteLine("COD_CLIENTE=" + codigoCliente.ToString());
                sw.WriteLine("EMPRESA=" + empresa.ToString());

            }
            //System.Windows.Forms.MessageBox.Show("Terminou!");
        }

    }
}
