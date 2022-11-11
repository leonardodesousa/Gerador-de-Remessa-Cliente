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
        public List<String> BuscaParametros()
        {
            List<String>ListaParametros = new List<string>();
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
                        if (ln.Substring(0, 14) == "NUMERO_ARQUIVO" && ln.Length > 1)
                        {                            
                            numeroArquivo = ln.Substring(15,ln.Length-15);
                            ListaParametros.Add(ln);
                        }
                        if (ln.Substring(0, 10) == "SEU_NUMERO" && ln.Length > 1)
                        {                            
                            seuNumero = ln.Substring(10, ln.Length - 10);
                            ListaParametros.Add(seuNumero);
                        }
                        if (ln.Substring(0, 16) == "DATA_RECEBIMENTO" && ln.Length > 1)
                        {                            
                            dataRecebimento = ln.Substring(17, ln.Length - 17);
                            ListaParametros.Add(dataRecebimento);
                        }
                        if (ln.Substring(0, 15) == "DATA_VENCIMENTO" && ln.Length > 1)
                        {                         
                            dataVencimento = ln.Substring(15, ln.Length - 15);
                            ListaParametros.Add(dataVencimento);
                        }
                        if (ln.Substring(0, 18) == "LINHAS_POR_ARQUIVO" && ln.Length > 1)
                        {                         
                            linhasPorArquivo = ln.Substring(18, ln.Length - 18);
                            ListaParametros.Add(linhasPorArquivo);
                        }            
                        if (ln.Length >= 22 && ln.Substring(0, 22) == "QUANTIDADE_DE_ARQUIVOS" )
                        {                         
                            quantidadeArquivos = ln.Substring(22, ln.Length - 22);
                            ListaParametros.Add(quantidadeArquivos);
                        }
                        if (ln.Length > 1 && ln.Substring(0, 8) == "CONVENIO")
                        {                         
                            convenio = ln.Substring(8, ln.Length - 8);
                            ListaParametros.Add(convenio);
                        }
                        if (ln.Length > 1 && ln.Substring(0, 13) == "CONTA_CEDENTE")
                        {                            
                            contaCedente = ln.Substring(13, ln.Length - 13);
                            ListaParametros.Add(contaCedente);
                        }
                        if (ln.Length > 1 && ln.Substring(0, 15) == "AGENCIA_CEDENTE")
                        {                               
                            agenciaCedente = ln.Substring(15, ln.Length - 15);
                            ListaParametros.Add(agenciaCedente);
                        }
                        if (ln.Length > 1 && ln.Substring(0, 17) == "DIRETORIO_DESTINO")
                        {
                            //System.Windows.Forms.MessageBox.Show("DIRETORIO_DESTINO recebe " + ln.Substring(18, ln.Length - 18));
                            diretorioDestino = ln.Substring(18, ln.Length - 18);
                            ListaParametros.Add(diretorioDestino);
                        }
                    }
                }
            }
            return ListaParametros;

        }
    }
}

