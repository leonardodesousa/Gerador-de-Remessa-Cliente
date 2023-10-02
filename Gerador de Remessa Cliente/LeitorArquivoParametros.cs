using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_Remessa_Cliente
{
    internal class LeitorArquivoParametros
    {
        public List<String> buscaConvenios()
        {
            List<String> ListaConvenios = new List<string>();
            String convenio;
            String cliente;            

            String path = @"C:\TotalBanco\Crediblaster\GeraRem\Clientes\Convenios\Convenios.ini";

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
                        if(ln.Length > 0)
                        {
                            convenio = ln.Substring(0, 12);
                            cliente = ln.Substring(13, ln.Length - 13);
                            ListaConvenios.Add(convenio + " - " + cliente);
                            //System.Windows.Forms.MessageBox.Show(convenio + " - " + cliente);
                            convenio = null;
                            cliente = null;
                            //ListaConvenios.Add(ln);

                        }
                        counter++;
                        //System.Windows.Forms.MessageBox.Show(counter.ToString());

                    }
                }
            }

            return ListaConvenios;
        }

        public List<String> BuscaParametroConveniado(String conveniado)
        {
            List<String> ListaParametros = new List<string>();
            String numeroArquivo;
            String seuNumero;
            String dataRecebimento;
            String dataVencimento;
            String linhasPorArquivo;
            String quantidadeArquivos;
            String convenio;
            String contaCedente;
            String agenciaCedente;
            String diretorioDestino;
            String bancoCobrador;
            String carteira;
            String codCliente;
            //String path = @"C:\TotalBanco\Crediblaster\GeraRem\GeraRem.ini";
            String path = @"C:\TotalBanco\Crediblaster\GeraRem\Clientes\Convenios\" +conveniado+ ".ini";
        
            //StreamWriter sw = new StreamWriter(path);
            Console.WriteLine("Entrei no leitor de arquivos");
            if (File.Exists(path))
            {
                //using (StreamReader file = new StreamReader(path, Encoding.GetEncoding(CultureInfo.GetCultureInfo("pt-BR").TextInfo.ANSICodePage)))
                using (StreamReader file = new StreamReader(path))
                {
                    // implementar aqui método de busca dos parametros
                    string ln;
                    while ((ln = file.ReadLine()) != null)
                    {
                        if (ln.Length > 14 && ln.Substring(0, 14) == "NUMERO_ARQUIVO")
                        {
                            //System.Windows.Forms.MessageBox.Show("NUMERO_ARQUIVO recebe " + ln.Substring(14, ln.Length - 14) +"espaço");
                            numeroArquivo = ln.Substring(15, ln.Length - 15);
                            ListaParametros.Add(ln.Trim());
                        } 
                        if (ln.Length > 10 && ln.Substring(0, 10) == "SEU_NUMERO")
                        {
                            seuNumero = ln.Substring(10, ln.Length - 10);
                            ListaParametros.Add(seuNumero);
                        }
                        if (ln.Length > 16 && ln.Substring(0, 16) == "DATA_RECEBIMENTO")
                        {
                            dataRecebimento = ln.Substring(17, ln.Length - 17);
                            ListaParametros.Add(dataRecebimento);
                        }
                        if (ln.Length > 15 && ln.Substring(0, 15) == "DATA_VENCIMENTO")
                        {
                            dataVencimento = ln.Substring(15, ln.Length - 15);
                            ListaParametros.Add(dataVencimento);
                        }
                        //System.Windows.Forms.MessageBox.Show("LINHAS_POR_ARQUIVO recebe " + ln/*.Substring(15, ln.Length - 15)*/);
                        if (ln.Length > 17 && ln.Substring(0, 18) == "LINHAS_POR_ARQUIVO")
                        {
                            linhasPorArquivo = ln.Substring(18, ln.Length - 18);
                            ListaParametros.Add(linhasPorArquivo);
                        }
                        if (ln.Length > 22 && ln.Substring(0, 22) == "QUANTIDADE_DE_ARQUIVOS")
                        {
                            quantidadeArquivos = ln.Substring(22, ln.Length - 22);
                            ListaParametros.Add(quantidadeArquivos);
                        }
                        if (ln.Length > 8 && ln.Substring(0, 8) == "CONVENIO")
                        {
                            convenio = ln.Substring(8, ln.Length - 8);
                            ListaParametros.Add(convenio);
                        }
                        if (ln.Length > 13 && ln.Substring(0, 13) == "CONTA_CEDENTE")
                        {
                            contaCedente = ln.Substring(13, ln.Length - 13);
                            ListaParametros.Add(contaCedente);
                        }
                        if (ln.Length > 15 && ln.Substring(0, 15) == "AGENCIA_CEDENTE")
                        {
                            agenciaCedente = ln.Substring(15, ln.Length - 15);
                            ListaParametros.Add(agenciaCedente);
                        }
                        if (ln.Length > 16 && ln.Substring(0, 17) == "DIRETORIO_DESTINO")
                        {
                            //System.Windows.Forms.MessageBox.Show("DIRETORIO_DESTINO recebe " + ln.Substring(18, ln.Length - 18));
                            diretorioDestino = ln.Substring(18, ln.Length - 18);
                            ListaParametros.Add(diretorioDestino);
                        }
                        if (ln.Length > 16 && ln.Substring(0, 17) == "DOCUMENTO_CEDENTE")
                        {
                            //System.Windows.Forms.MessageBox.Show("DIRETORIO_DESTINO recebe " + ln.Substring(18, ln.Length - 18));
                            diretorioDestino = ln.Substring(18, ln.Length - 18);
                            ListaParametros.Add(diretorioDestino);
                        }
                        if (ln.Length > 14 && ln.Substring(0, 14) == "BANCO_COBRADOR")
                        {                            
                            bancoCobrador = ln.Substring(15, ln.Length - 15).Trim();
                            ListaParametros.Add(bancoCobrador);
                        }
                        if (ln.Length > 8 && ln.Substring(0, 8) == "CARTEIRA")
                        {                            
                            carteira = ln.Substring(9, ln.Length - 9).Trim();
                            ListaParametros.Add(carteira);
                        }

                        if (ln.Length > 8 && ln.Substring(0, 11) == "COD_CLIENTE")
                        {
                            codCliente = ln.Substring(12, ln.Length - 12).Trim();
                            ListaParametros.Add(codCliente);
                        }

                    }
                }
                while (ListaParametros.Count < 14)
                {
                    ListaParametros.Add(" ");
                }
            }
            return ListaParametros;

        }


        public List<String> BuscaParametrosWs()
        {
            List<String>ListaParametros = new List<string>();
            String servidor;
            String token;
            
            String path = @"C:\TotalBanco\Crediblaster\GeraRem\GeraRem.ini";
            //StreamWriter sw = new StreamWriter(path);
            Console.WriteLine("Entrei no leitor de arquivos");            
            if (File.Exists(path))
            {
                //using (StreamReader file = new StreamReader(path, Encoding.GetEncoding(CultureInfo.GetCultureInfo("pt-BR").TextInfo.ANSICodePage)))
                using (StreamReader file = new StreamReader(path))
                {
                    // implementar aqui método de busca dos parametros
                    string ln;
                    while ((ln = file.ReadLine()) != null)
                    {
                        if (ln.Length > 8 && ln.Substring(0, 8) == "SERVIDOR")
                        {
                            //System.Windows.Forms.MessageBox.Show("NUMERO_ARQUIVO recebe " + ln.Substring(14, ln.Length - 14) +"espaço");
                            servidor = ln.Substring(9, ln.Length-9);
                            ListaParametros.Add(servidor.Trim());
                        }
                        if (ln.Length > 5 && ln.Substring(0, 5) == "TOKEN")
                        {
                            token = ln.Substring(6, ln.Length - 6);
                            ListaParametros.Add(token.Trim());
                        }
                        while (ListaParametros.Count < 1)
                        {
                            ListaParametros.Add(" ");

                        }
                    }
                }
            }
            return ListaParametros;

        }
    }
}

