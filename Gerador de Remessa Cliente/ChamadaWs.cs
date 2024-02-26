using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Globalization;
using Gerador_de_Remessa_Cliente.Model;
using System.Numerics;
using Gerador_de_Remessa_Cliente.Repository;
using System.Drawing;

namespace Gerador_de_Remessa_Cliente
{
    public class ChamadaWs
    {
        public string BuscarTitularAgenciaWs(XmlDocument soapEnvelopeXmlBuscarTitularAgencia)
        {
            ServidorAcesso servidorAcesso = new ServidorAcesso();

            List<String> ListaParametros = new List<string>();

            ListaParametros = servidorAcesso.getServidorEToken();


            //var _url = "http://poa-cb-dev40.poa01.local:7070/tfs-credito-service/OperacaoService/Operacao?wsdl";
            //var _token = "bearer 1b63e37e-cef9-48bf-8718-4dc80f6dabc6";

            var _url = ListaParametros[0] + "/tfs-credito-service/BackOfficeService/BackOffice?wsdl";
            var _token = "bearer " + ListaParametros[1];


            XmlDocument soapEnvelopeDocument = new XmlDocument();

            var sucesso = 1;
            string mensagem;
            string numeroLote = "0";
            string numeroContrato = "0";
            string valorTotalCalculado = "0";

            //XmlDocument soapEnvelopeXml = CreateSoapEnvelope();            
            //XmlDocument soapEnvelopeXml = CreateSoapEnvelope();            
            HttpWebRequest webRequest = CreateWebRequest(_url, _token);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXmlBuscarTitularAgencia, webRequest);

            // Começa a chamada assincrona da requisição
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

            //Suspende a thread até a chamada estar completa.
            asyncResult.AsyncWaitHandle.WaitOne();

            // get the response from the completed web request.
            // Armazenar a resposta da requisição
            string soapResult;

            /*
            string nomeArquivoRequest = "BuscarTitularAgencia" + DateTime.Now.ToString("ddMMyyyyHHmmss");
            string diretorioRequest = @"C:\\TotalBanco\\Crediblaster\\GeraRem\\xml\\" + nomeArquivoRequest + "_request.xml";

            using (StreamWriter sw = File.CreateText(diretorioRequest))
            {
                sw.WriteLine(soapEnvelopeXmlBuscarTitularAgencia.ToString());
            }
            */

            string nomeArquivo = "BuscarTitularAgencia" + DateTime.Now.ToString("ddMMyyyyHHmmss");
            string diretorio = @"C:\\TotalBanco\\Crediblaster\\GeraRem\\xml\\" + nomeArquivo + "_response.xml";

            try
            {
                using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
                {
                    using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                    {

                        soapResult = rd.ReadToEnd();
                        soapEnvelopeDocument.LoadXml(soapResult);
                    }
                    Console.Write(soapResult);
                    //DialogResult dialogo2 = MessageBox.Show(soapResult, "Retorno", MessageBoxButtons.OK);

                    //string nomeArquivo = "incluirBorderoCapaLote"+ DateTime.Now.ToString("ddMMyyyyHHmmss");
                    //string diretorio = @"C:\\TotalBanco\\Crediblaster\\GeraRem\\xml\\" + nomeArquivo + "_response.xml";

                    using (StreamWriter sw = File.CreateText(diretorio))
                    {
                        sw.WriteLine(soapResult.ToString());
                    }

                    XmlDocument doc = new XmlDocument();
                    doc.Load(diretorio);
                    String dataProcessamento;
                    DateTime dataFormatada;


                    XmlNodeList elemList = doc.GetElementsByTagName("dataProximoProcessamento");
                    for (int i = 0; i < elemList.Count; i++)
                    {
                        numeroLote = (elemList[i].InnerXml);

                    }                    

                    //valorTotalCalculado

                    //Bordero bordero = new Bordero(Int32.Parse(numeroLote), Int32.Parse(numeroContrato));
                    //DialogResult dialogo2 = MessageBox.Show(text: "Data Processamento atual: " + dataFormatada, caption: "Retorno", buttons: MessageBoxButtons.OK);




                }
            }
            catch (System.Net.WebException ex)
            {
                Console.WriteLine(ex.Message);
                DialogResult dialogo = MessageBox.Show(ex.Message, "Ocorreu um erro ao acessar webservice remoto", MessageBoxButtons.OK);
                sucesso = 0;
            }

            if (sucesso == 0)
            {
                mensagem = "Ocorreu um erro ao acessar o servidor remoto BuscarTitularAgencia. Verifique os logs";
            }
            

            
            return diretorio;

        }

        public string CallWebService_(XmlDocument soapEnvelopeXml, string webService)
        {
            ServidorAcesso servidorAcesso = new ServidorAcesso();

            List<String> ListaParametros = new List<string>();

            ListaParametros = servidorAcesso.getServidorEToken();


            //var _url = "http://poa-cb-dev40.poa01.local:7070/tfs-credito-service/OperacaoService/Operacao?wsdl";
            //var _token = "bearer 1b63e37e-cef9-48bf-8718-4dc80f6dabc6";

            var _url = ListaParametros[0] + "/tfs-credito-service/OperacaoService/Operacao?wsdl";
            var _token = "bearer " + ListaParametros[1];


            XmlDocument soapEnvelopeDocument = new XmlDocument();

            var sucesso = 1;
            string mensagem;
            string numeroLote = "0";
            string numeroContrato = "0";
            string valorTotalCalculado = "0";
            string numeroLancamento;
            string emissao;
            string vencimento;
            string seuNumero;
            double valor;
            string docPagador;
            int codCobrador;

            
            BorderoDetalhe borderoDetalhe = new BorderoDetalhe();
            List<BorderoDetalhe> borderos = new List<BorderoDetalhe>();

            //XmlDocument soapEnvelopeXml = CreateSoapEnvelope();            
            //XmlDocument soapEnvelopeXml = CreateSoapEnvelope();            
            HttpWebRequest webRequest = CreateWebRequest(_url, _token);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

            // Começa a chamada assincrona da requisição
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);
    
            //Suspende a thread até a chamada estar completa.
            asyncResult.AsyncWaitHandle.WaitOne();

            // get the response from the completed web request.
            // Armazenar a resposta da requisição
            string soapResult;

            string nomeArquivo = "CalcularBordero" + DateTime.Now.ToString("ddMMyyyyHHmmss");
            string diretorio = @"C:\\TotalBanco\\Crediblaster\\GeraRem\\xml\\" + nomeArquivo + "_response.xml";

            try
            {
                using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
                {
                    using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                    {
                        
                        soapResult = rd.ReadToEnd();
                        soapEnvelopeDocument.LoadXml(soapResult);
                    }
                    Console.Write(soapResult);
                    //DialogResult dialogo2 = MessageBox.Show(soapResult, "Retorno", MessageBoxButtons.OK);

                    //string nomeArquivo = "incluirBorderoCapaLote"+ DateTime.Now.ToString("ddMMyyyyHHmmss");
                    //string diretorio = @"C:\\TotalBanco\\Crediblaster\\GeraRem\\xml\\" + nomeArquivo + "_response.xml";

                    using (StreamWriter sw = File.CreateText(diretorio))
                    {
                        sw.WriteLine(soapResult.ToString());
                    }

                    XmlDocument doc = new XmlDocument();
                    doc.Load(diretorio);
                    String dataProcessamento;
                    DateTime dataFormatada;
                    

                    XmlNodeList elemList = doc.GetElementsByTagName("numeroLote");
                    for (int i = 0; i < elemList.Count; i++)
                    {                        
                        numeroLote = (elemList[i].InnerXml);
                        
                    }

                    XmlNodeList elemList2 = doc.GetElementsByTagName("numeroContrato");
                    for (int i = 0; i < elemList2.Count; i++)
                    {
                        numeroContrato = (elemList2[i].InnerXml);

                    }

                    XmlNodeList elemList3 = doc.GetElementsByTagName("valorTotalCalculado");
                    for (int i = 0; i < elemList3.Count; i++)
                    {
                        valorTotalCalculado = (elemList3[i].InnerXml);

                    }                   
                    
                    
                    //valorTotalCalculado

                    Bordero bordero = new Bordero(Int32.Parse(numeroLote), Int32.Parse(numeroContrato));
                    //DialogResult dialogo2 = MessageBox.Show(text: "Data Processamento atual: " + dataFormatada, caption: "Retorno", buttons: MessageBoxButtons.OK);




                } 
            }catch (System.Net.WebException ex){
                Console.WriteLine(ex.Message);
                DialogResult dialogo = MessageBox.Show(ex.Message, "Ocorreu um erro ao acessar webservice remoto", MessageBoxButtons.OK);
                sucesso = 0;
            }

            if(sucesso == 1)
            {
                String path2 = @"C:\TotalBanco\Crediblaster\GeraRem\Geraremsoap.dll";
                using (StreamWriter sw = File.CreateText(path2))
                {
                    sw.WriteLine(diretorio);
                }
                //DialogResult dialogo3 = MessageBox.Show("Capa de lote cadastrada com sucesso", "Sucesso!", MessageBoxButtons.OK);
                mensagem = "Lote de borderô enviado com sucesso. Número do lote: " + numeroLote + ". Valor total: " + valorTotalCalculado;
                FormBorderoDetalhe formBorderoDetalhe = new FormBorderoDetalhe();                
                //C:\TotalBanco\Crediblaster\GeraCompe\GeraCompesoap.dll                
                
                formBorderoDetalhe.ShowDialog();

            }
            else
            {
                mensagem = "Ocorreu um erro ao acessar o servidor remoto. Verifique os logs";
            }

            DialogResult dialogo3 = MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK);

            //DialogResult dialogo4 = MessageBox.Show(soapEnvelopeDocument.ToString(), "Informação", MessageBoxButtons.OK);

            //XmlDocument soapEnvelopeDocument = new XmlDocument();
            //soapEnvelopeDocument.LoadXml(webResponse.ToString());///////////////////////////
            return diretorio;
                        
        }

        public void PersistirBordero(XmlDocument soapEnvelopeXml, string webService, DateTime dataEmissao, String codigoCedente, int quantidadeTitulos, 
            double valorTotalDoLote, int seuNumeroInicial, DateTime dataVencimento, List<String> titulosXml, string dataProcessamentoFormatado)
        {
            ServidorAcesso servidorAcesso = new ServidorAcesso();

            List<String> ListaParametros = new List<string>();

            ListaParametros = servidorAcesso.getServidorEToken();


            //var _url = "http://poa-cb-dev40.poa01.local:7070/tfs-credito-service/OperacaoService/Operacao?wsdl";
            //var _token = "bearer 1b63e37e-cef9-48bf-8718-4dc80f6dabc6";

            var _url = ListaParametros[0] + "/tfs-credito-service/OperacaoService/Operacao?wsdl";
            var _token = "bearer " + ListaParametros[1];

            XmlDocument soapEnvelopeDocument = new XmlDocument();

            var sucesso = 1;
            string mensagem;
            string numeroLote = "0";
            string numeroContrato = "0";

            //XmlDocument soapEnvelopeXml = CreateSoapEnvelope();            
            //XmlDocument soapEnvelopeXml = CreateSoapEnvelope();            
            HttpWebRequest webRequest = CreateWebRequest(_url, _token);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

            // Começa a chamada assincrona da requisição
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

            //Suspende a thread até a chamada estar completa.
            asyncResult.AsyncWaitHandle.WaitOne();

            // get the response from the completed web request.
            // Armazenar a resposta da requisição
            string soapResult;

            string nomeArquivo = webService + DateTime.Now.ToString("ddMMyyyyHHmmss");
            string diretorio = @"C:\\TotalBanco\\Crediblaster\\GeraRem\\xml\\" + nomeArquivo + "_response.xml";


            try
            {
                using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
                {
                    using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                    {

                        soapResult = rd.ReadToEnd();
                        soapEnvelopeDocument.LoadXml(soapResult);
                    }
                    Console.Write(soapResult);
                    
                    using (StreamWriter sw = File.CreateText(diretorio))
                    {
                        sw.WriteLine(soapResult.ToString());
                    }

                    XmlDocument doc = new XmlDocument();
                    doc.Load(diretorio);
                    String dataProcessamento;
                    DateTime dataFormatada;

                    XmlNodeList elemList = doc.GetElementsByTagName("numeroLote");
                    for (int i = 0; i < elemList.Count; i++)
                    {
                        numeroLote = (elemList[i].InnerXml);

                    }

                    XmlNodeList elemList2 = doc.GetElementsByTagName("numeroContrato");
                    for (int i = 0; i < elemList2.Count; i++)
                    {
                        numeroContrato = (elemList2[i].InnerXml);

                    }

                }
            }
            catch (System.Net.WebException ex)
            {
                Console.WriteLine(ex.Message);
                DialogResult dialogo = MessageBox.Show(ex.Message, "Ocorreu um erro ao acessar webservice remoto", MessageBoxButtons.OK);
                sucesso = 0;
            }

            if (sucesso == 1)
            {
                //DialogResult dialogo3 = MessageBox.Show("Capa de lote cadastrada com sucesso", "Sucesso!", MessageBoxButtons.OK);
                mensagem = "Capa de lote cadastrada com sucesso. Número do lote: " + numeroLote.ToString();

            }
            else
            {
                mensagem = "Ocorreu um erro ao acessar o servidor remoto. Verifique os logs";
            }

            //DialogResult dialogo3 = MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK);

            //DialogResult dialogo4 = MessageBox.Show(soapEnvelopeDocument.ToString(), "Informação", MessageBoxButtons.OK);

            //XmlDocument soapEnvelopeDocument = new XmlDocument();
            //soapEnvelopeDocument.LoadXml(webResponse.ToString());///////////////////////////
            //return diretorio;

            //this.CreateSoapEnvelopeCalcularBordero(dataEmissao, codigoCedente, quantidadeTitulos, valorTotalDoLote, numeroLote, numeroContrato);
            CreateSoapEnvelopeCalcularBordero(dataEmissao, codigoCedente, quantidadeTitulos, valorTotalDoLote
                , Int32.Parse(numeroLote), Int32.Parse(numeroContrato), seuNumeroInicial, dataVencimento, titulosXml, dataProcessamentoFormatado);

        }


        private static HttpWebRequest CreateWebRequest(string url, string token)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            //webRequest.Headers.Add("SOAPAction", action);
            webRequest.Headers.Add("Authorization", token);
            webRequest.ContentType = "text/xml;charset=UTF-8";
            //webRequest.Accept = "text/xml";
            webRequest.Accept = "accept - encoding =[gzip, deflate";
            webRequest.Method = "POST";
            //XDocument xdoc = XDocument.Load(webRequest);
                return webRequest;
        }

        private static XmlDocument CreateSoapEnvelope()
        {
            XmlDocument soapEnvelopeDocument = new XmlDocument();

            String soapEnvelopeName = "<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:bac=\"backoffice.credito.tfs.totvs.com\">\r\n                <soapenv:Header/>\r                <soapenv:Body>\r                    <bac:buscarTitularAgencia>         \r                        <buscar>            \r                            <codigoEmpresa>36</codigoEmpresa>            \r                            <codigoUnidade>36</codigoUnidade>\r                        </buscar>\r                    </bac:buscarTitularAgencia>\r                </soapenv:Body>\r                </soapenv:Envelope>";

            soapEnvelopeDocument.LoadXml(soapEnvelopeName);

            /*soapEnvelopeDocument.LoadXml(
            @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:bac=""backoffice.credito.tfs.totvs.com"">
                <soapenv:Header/>
                <soapenv:Body>
                    <bac:buscarTitularAgencia>         
                        <buscar>            
                            <codigoEmpresa>36</codigoEmpresa>            
                            <codigoUnidade>36</codigoUnidade>
                        </buscar>
                    </bac:buscarTitularAgencia>
                </soapenv:Body>
                </soapenv:Envelope>");*/
            return soapEnvelopeDocument;
        }

        public XmlDocument CreateSoapEnvelopeBorderoCapaLote(DateTime dataEmissao, String codigoCedente, int quantidadeTitulos
            , /*double valorTotalDoLote,*/ int seuNumeroIncial, DateTime dataVencimento)
        {
            List <String> listaTitulosXml = new List<string>();
            StringBuilder titulosXml = new StringBuilder();
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            //valorTotalDoLote.ToString(nfi);

            int codigoCedenteConvertido = +Int32.Parse(codigoCedente);

            string dataEmissaoFormatada = DateTime.Parse(dataEmissao.ToString()).ToString("yyyy-MM-dd");
            string dataVencimentoFormatada = DateTime.Parse(dataVencimento.ToString()).ToString("yyyy-MM-dd");


            // implementando o incremental dos títulos
            double valorTotalDoLote = 0;
            double valorDoTitulo;
            Random randNum = new Random();
            int numeroLancamento = 1;
            //valorTitulo = randNum.Next(10, 3000); // Boleto mínimo 10 reais; máximo 3.000 reais

            //montando o xml para buscar o titular agencia
            MontaXml montaXml = new MontaXml();

            XmlDocument buscarTitularAgenciaXml = new XmlDocument();
            buscarTitularAgenciaXml = montaXml.buscarTituarAgencia(36, 36);

            String diretorioBuscarTitularAgenciaRequest = BuscarTitularAgenciaWs(buscarTitularAgenciaXml);


            XmlDocument doc = new XmlDocument();
            doc.Load(diretorioBuscarTitularAgenciaRequest);
            //String dataProcessamento;
            DateTime dataProcessamento = dataEmissao;

            XmlNodeList elemList = doc.GetElementsByTagName("dataProximoProcessamento");
            for (int i = 0; i < elemList.Count; i++)
            {
                dataProcessamento = (DateTime.Parse(elemList[i].InnerXml));

            }

            string dataProcessamentoFormatado = DateTime.Parse(dataProcessamento.ToString()).ToString("yyyy-MM-dd");




            for (int i = 0; i< quantidadeTitulos; i++)
            {
                valorDoTitulo = randNum.Next(10, 3000); // Boleto mínimo 10 reais; máximo 3.000 reais
                valorTotalDoLote = valorTotalDoLote + valorDoTitulo;

                

                titulosXml.Append("<titulos>");
                titulosXml.Append("<codigoUsuarioAtualizador>GERADOR COB</codigoUsuarioAtualizador>");
                titulosXml.Append("<dataHoraAtualizacao>" + DateTime.Now.ToString("yyyy-MM-dd") + "T" + DateTime.Now.ToString("HH:mm:ss") + "</dataHoraAtualizacao>");//////
                titulosXml.Append("<numeroLancamento>" + numeroLancamento + "</numeroLancamento>");
                titulosXml.Append("<tipoTitulo>");
                titulosXml.Append("<codigoUsuarioAtualizador>TB</codigoUsuarioAtualizador>");
                titulosXml.Append("<dataHoraAtualizacao>2007-05-18T11:10:29-03:00</dataHoraAtualizacao>");
                titulosXml.Append("<siglaTipoTitulo>DUP</siglaTipoTitulo>");
                titulosXml.Append("<descricaoTitulo>CAUCAO - DUPLICATAS</descricaoTitulo>");
                titulosXml.Append("</tipoTitulo>");
                titulosXml.Append("<seuNumero>" + seuNumeroIncial.ToString().PadLeft(12, '0') + "</seuNumero>");   ///
                titulosXml.Append("<codigoCliente>" + codigoCedenteConvertido + "</codigoCliente>");
                titulosXml.Append("<tipoDocumentoSacado>CPF</tipoDocumentoSacado>");
                titulosXml.Append("<numeroDocumentoSacado>06067139995</numeroDocumentoSacado>");
                titulosXml.Append("<dataEmissaoTitulo>" + dataEmissaoFormatada + "-03:00</dataEmissaoTitulo>");   //
                titulosXml.Append("<dataVencimento>" + dataVencimentoFormatada + "-03:00</dataVencimento>");
                titulosXml.Append("<aceite>NAO</aceite>");
                titulosXml.Append("<codigoCobrador>653</codigoCobrador>");
                titulosXml.Append("<endereco>false</endereco>");
                titulosXml.Append("<numeroDocumentoEfetivo>06067139995</numeroDocumentoEfetivo>");
                titulosXml.Append("<tipoPessoa>FISICA</tipoPessoa>");
                titulosXml.Append("<valorTitulo>" + valorDoTitulo.ToString(nfi) + "</valorTitulo>"); //
                titulosXml.Append("<saldoDevedor>" + valorDoTitulo.ToString(nfi) + "</saldoDevedor>"); //
                titulosXml.Append("<identificadorCriterioPermanencia>CONFIGURACAO</identificadorCriterioPermanencia>");
                titulosXml.Append("<identificadorCriterioLiquidacao>SEM_LIQUIDACAO</identificadorCriterioLiquidacao>");
                titulosXml.Append("<identificadorCriterioMulta>TITULO</identificadorCriterioMulta>");
                titulosXml.Append("<percentualMulta>2</percentualMulta>");
                titulosXml.Append("<quantidadeDiasMulta>0</quantidadeDiasMulta>");
                titulosXml.Append("<valorTaxaSpread>0</valorTaxaSpread>");
                titulosXml.Append("<baseSpread>DEVEDOR</baseSpread>");
                titulosXml.Append("<identificadorFormatoSpread>CONFIGURACAO</identificadorFormatoSpread>");
                titulosXml.Append("<identificadorCriterioOperacao>NAO_UTILIZA</identificadorCriterioOperacao>");
                titulosXml.Append("<baseCalculoMulta>DEVEDOR</baseCalculoMulta>");
                titulosXml.Append("<taxaLimiteMora>0</taxaLimiteMora>");
                titulosXml.Append("<identificadorTipoLimite>SEM_LIMITE</identificadorTipoLimite>");
                titulosXml.Append("<criterioReembolso>C</criterioReembolso>");
                titulosXml.Append("<criterioProtesto>C</criterioProtesto>");
                titulosXml.Append("<criterioDevolucao>C</criterioDevolucao>");
                titulosXml.Append("<devolucaoAutomatica>NAO_DEVOLVER</devolucaoAutomatica>");
                titulosXml.Append("<situacaoCobranca>EM_DIA</situacaoCobranca>");
                titulosXml.Append("<identificadorConvenioCnab>false</identificadorConvenioCnab>");
                titulosXml.Append("<nomeSacado>FELIPE DE LIZ MARTINS</nomeSacado>");
                titulosXml.Append("<valorJurosADescontar>0</valorJurosADescontar>");
                titulosXml.Append("<valorIOCADescontar>0</valorIOCADescontar>");
                titulosXml.Append("</titulos>");

                listaTitulosXml.Add(titulosXml.ToString());
                titulosXml.Clear();

                //valorTotalDoLote = valorTotalDoLote + valorDoTitulo;
                numeroLancamento++;
                seuNumeroIncial++;
                //DialogResult dialogo4 = MessageBox.Show("Adicionei o titulo no valor de " + valorDoTitulo, "Informação", MessageBoxButtons.OK);
            }
            
            
            

            //valorTotalDoLote = valorTotalDoLote + valorTitulo;

            XmlDocument soapEnvelopeDocument = new XmlDocument();

            //double.Parse(valorTotalDoLote, new CultureInfo("en-US"));

            //NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            //valorTotalDoLote.ToString(nfi);

            //int codigoCedenteConvertido = +Int32.Parse(codigoCedente);

            //string dataEmissaoFormatada = DateTime.Parse(dataEmissao.ToString()).ToString("yyyy-MM-dd");

            StringBuilder envelopeSoapBorderoCapaLote = new StringBuilder();
            envelopeSoapBorderoCapaLote.Append("<soap:Envelope xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\">");
            envelopeSoapBorderoCapaLote.Append("<soap:Body>");
            envelopeSoapBorderoCapaLote.Append("<ns2:incluirBorderoCapaLote xmlns:ns2=\"operacao.credito.tfs.totvs.com\">");
            envelopeSoapBorderoCapaLote.Append("<movimentoContrato>");
            envelopeSoapBorderoCapaLote.Append("<codigoEmpresa>36</codigoEmpresa>");
            envelopeSoapBorderoCapaLote.Append("<codigoUnidade>36</codigoUnidade>");
            envelopeSoapBorderoCapaLote.Append("<dataMovimento>" + dataEmissaoFormatada + "-03:00</dataMovimento>");
            envelopeSoapBorderoCapaLote.Append("<situacaoContrato>FECHADO</situacaoContrato>");
            envelopeSoapBorderoCapaLote.Append("<codigoCliente>" + codigoCedenteConvertido + "</codigoCliente>");
            envelopeSoapBorderoCapaLote.Append("<siglaModalidade>CBSJ</siglaModalidade>");
            envelopeSoapBorderoCapaLote.Append("<codigoCobrador>653</codigoCobrador>");
            envelopeSoapBorderoCapaLote.Append("<siglaLinhaOperacao>COB</siglaLinhaOperacao>");
            envelopeSoapBorderoCapaLote.Append("<dataProcessamentoEfetivo>" + dataProcessamentoFormatado + "-03:00</dataProcessamentoEfetivo>");            
            envelopeSoapBorderoCapaLote.Append("<siglaModulo>CD</siglaModulo>");
            envelopeSoapBorderoCapaLote.Append("<loteComplementar>false</loteComplementar>");
            envelopeSoapBorderoCapaLote.Append("<tipoTitulo>");
            envelopeSoapBorderoCapaLote.Append("<codigoUsuarioAtualizador>TB</codigoUsuarioAtualizador>");
            envelopeSoapBorderoCapaLote.Append("<dataHoraAtualizacao>2007-05-18T11:10:29-03:00</dataHoraAtualizacao>");
            envelopeSoapBorderoCapaLote.Append("<siglaTipoTitulo>DUP</siglaTipoTitulo>");
            envelopeSoapBorderoCapaLote.Append("<descricaoTitulo>CAUCAO - DUPLICATAS</descricaoTitulo>");
            envelopeSoapBorderoCapaLote.Append("</tipoTitulo>");
            envelopeSoapBorderoCapaLote.Append("<dataOperacao>" + dataEmissaoFormatada + "-03:00</dataOperacao>");
            envelopeSoapBorderoCapaLote.Append("<quantidadeTitulos>" +quantidadeTitulos+ "</quantidadeTitulos>");
            envelopeSoapBorderoCapaLote.Append("<aceite>NAO</aceite>");
            envelopeSoapBorderoCapaLote.Append("<codigoGerente>8400</codigoGerente>");
            envelopeSoapBorderoCapaLote.Append("<destinacaoAutomatica>false</destinacaoAutomatica>");
            envelopeSoapBorderoCapaLote.Append("<valorTotal>" + valorTotalDoLote.ToString(nfi) + "</valorTotal>");
            envelopeSoapBorderoCapaLote.Append("<valorTarifaAbertura>0</valorTarifaAbertura>");
            envelopeSoapBorderoCapaLote.Append("<valorTarifaCobranca>0</valorTarifaCobranca>");
            envelopeSoapBorderoCapaLote.Append("<numeroDirecionamentoCredito>A_4500</numeroDirecionamentoCredito>");
            envelopeSoapBorderoCapaLote.Append("<identificadorCriterioLiquidacao>SEM_LIQUIDACAO</identificadorCriterioLiquidacao>");
            envelopeSoapBorderoCapaLote.Append("<reembolsoAutomatico>false</reembolsoAutomatico>");
            envelopeSoapBorderoCapaLote.Append("<quantidadeReembolsoAutomatico>0</quantidadeReembolsoAutomatico>");
            envelopeSoapBorderoCapaLote.Append("<identificadorConvenioCnab>false</identificadorConvenioCnab>");
            envelopeSoapBorderoCapaLote.Append("<alteracaoEncargos>false</alteracaoEncargos>");
            envelopeSoapBorderoCapaLote.Append("<identificadorDiasAte30Dias>CORRIDOS</identificadorDiasAte30Dias>");
            envelopeSoapBorderoCapaLote.Append("<taxaPermanenciaAte30Dias>4</taxaPermanenciaAte30Dias>");
            envelopeSoapBorderoCapaLote.Append("<identificadorFormaAte30Dias>CAPITALIZADO</identificadorFormaAte30Dias>");
            envelopeSoapBorderoCapaLote.Append("<identificadorDiasMais30Dias>CORRIDOS</identificadorDiasMais30Dias>");
            envelopeSoapBorderoCapaLote.Append("<taxaPermanenciaMais30Dias>4</taxaPermanenciaMais30Dias>");
            envelopeSoapBorderoCapaLote.Append("<identificadorFormaAte30Dias>CAPITALIZADO</identificadorFormaAte30Dias>");
            envelopeSoapBorderoCapaLote.Append("<identificadorDiasMais30Dias>CORRIDOS</identificadorDiasMais30Dias>");
            envelopeSoapBorderoCapaLote.Append("<taxaPermanenciaMais30Dias>4</taxaPermanenciaMais30Dias>");
            envelopeSoapBorderoCapaLote.Append("<identificadorformaMais30Dias>LINEAR</identificadorformaMais30Dias>");
            envelopeSoapBorderoCapaLote.Append("<percentualMulta>2</percentualMulta>");
            envelopeSoapBorderoCapaLote.Append("<quantidadeDiasMulta>0</quantidadeDiasMulta>");
            envelopeSoapBorderoCapaLote.Append("<valorTaxaSpread>0</valorTaxaSpread>");
            envelopeSoapBorderoCapaLote.Append("<identificadorBaseSpread>DEVEDOR</identificadorBaseSpread>");
            envelopeSoapBorderoCapaLote.Append("<identificadorFormatoSpread>CONFIGURACAO</identificadorFormatoSpread>");
            envelopeSoapBorderoCapaLote.Append("<identificadorCriterioOperacao>NAO_UTILIZA</identificadorCriterioOperacao>");
            envelopeSoapBorderoCapaLote.Append("<baseCalculoMulta>DEVEDOR</baseCalculoMulta>");
            envelopeSoapBorderoCapaLote.Append("<taxaLimiteMora>0</taxaLimiteMora>");
            envelopeSoapBorderoCapaLote.Append("<identificadorTipoLimite>SEM_LIMITE</identificadorTipoLimite>");            
            envelopeSoapBorderoCapaLote.Append("<titulos>");
            envelopeSoapBorderoCapaLote.Append("<numeroLancamento>" +quantidadeTitulos+ "</numeroLancamento>");
            envelopeSoapBorderoCapaLote.Append("<tipoTitulo>");
            envelopeSoapBorderoCapaLote.Append("<codigoUsuarioAtualizador>TB</codigoUsuarioAtualizador>");
            envelopeSoapBorderoCapaLote.Append("<dataHoraAtualizacao>2007-05-18T11:10:29-03:00</dataHoraAtualizacao>");
            envelopeSoapBorderoCapaLote.Append("<siglaTipoTitulo>DUP</siglaTipoTitulo>");
            envelopeSoapBorderoCapaLote.Append("<descricaoTitulo>CAUCAO - DUPLICATAS</descricaoTitulo>");           
            envelopeSoapBorderoCapaLote.Append("</tipoTitulo>");            
            envelopeSoapBorderoCapaLote.Append("<codigoCliente>"  + codigoCedenteConvertido + "</codigoCliente>");
            envelopeSoapBorderoCapaLote.Append("<dataEmissaoTitulo>" + dataEmissaoFormatada + "-03:00</dataEmissaoTitulo>");
            envelopeSoapBorderoCapaLote.Append("<aceite>NAO</aceite>");
            envelopeSoapBorderoCapaLote.Append("<situacaoCobranca>EM_DIA</situacaoCobranca>");
            envelopeSoapBorderoCapaLote.Append("<identificadorConvenioCnab>false</identificadorConvenioCnab>");
            envelopeSoapBorderoCapaLote.Append("</titulos>");
            envelopeSoapBorderoCapaLote.Append("</movimentoContrato>");
            envelopeSoapBorderoCapaLote.Append("</ns2:incluirBorderoCapaLote>");
            envelopeSoapBorderoCapaLote.Append("</soap:Body>");
            envelopeSoapBorderoCapaLote.Append("</soap:Envelope>");

            soapEnvelopeDocument.LoadXml(envelopeSoapBorderoCapaLote.ToString());

            string nomeArquivoRequest = DateTime.Now.ToString("ddMMyyyyHHmmss");
            string diretorio = @"C:\\TotalBanco\\Crediblaster\\GeraRem\\xml\\" + "incluirBorderoCapaLote" + nomeArquivoRequest + "_request.xml";

            using (StreamWriter sw = File.CreateText(diretorio))
            {
                sw.WriteLine(envelopeSoapBorderoCapaLote.ToString());
            }

            //PersistirBordero(soapEnvelopeDocument, "incluirBorderoCapaLote");
            PersistirBordero(soapEnvelopeDocument, "incluirBorderoCapalote", dataEmissao, codigoCedente, quantidadeTitulos, valorTotalDoLote, seuNumeroIncial, dataVencimento, listaTitulosXml, dataProcessamentoFormatado) ;

            //CreateSoapEnvelopeCalcularBordero(dataEmissao,codigoCedente,quantidadeTitulos,valorTotalDoLote,)


            return soapEnvelopeDocument;
        }



        public XmlDocument CreateSoapEnvelopeCalcularBordero(DateTime dataEmissao, String codigoCedente, int quantidadeTitulos, double valorTotalDoLote
            , int numeroLote, int numeroContrato, int seuNumeroInicial, DateTime dataVencimento, List <String> listaTitulosXml, string dataProcessamentoFormatado)
        {
            

            //seuNumeroInicial = 19746;
            //double valorDoTitulo = 900.50;
            XmlDocument soapEnvelopeDocument = new XmlDocument();

            //double.Parse(valorTotalDoLote, new CultureInfo("en-US"));

            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            //valorTotalDoLote.ToString(nfi);

            int codigoCedenteConvertido = +Int32.Parse(codigoCedente);

            string dataEmissaoFormatada = DateTime.Parse(dataEmissao.ToString()).ToString("yyyy-MM-dd");
            string dataVencimentoFormatada = DateTime.Parse(dataVencimento.ToString()).ToString("yyyy-MM-dd");
            




            //DateTime.Now.ToString("dd-MM-yyyyHH:mm:ss")
            ////DateTime.Now.ToString("HH:mm:ss")

            StringBuilder envelopeSoapCalcularBordero = new StringBuilder();
            envelopeSoapCalcularBordero.Append("<soap:Envelope xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\">");
            envelopeSoapCalcularBordero.Append("<soap:Body>");
            envelopeSoapCalcularBordero.Append("<ns2:calcularBordero xmlns:ns2=\"operacao.credito.tfs.totvs.com\">");
            envelopeSoapCalcularBordero.Append("<movimentoContrato>");
            envelopeSoapCalcularBordero.Append("<codigoUsuarioAtualizador>GERADOR COB</codigoUsuarioAtualizador>");
            envelopeSoapCalcularBordero.Append("<dataHoraAtualizacao>" + DateTime.Now.ToString("yyyy-MM-dd") + "T" + DateTime.Now.ToString("HH:mm:ss") + "-03:00</dataHoraAtualizacao>");
            envelopeSoapCalcularBordero.Append("<codigoEmpresa>36</codigoEmpresa>");
            envelopeSoapCalcularBordero.Append("<codigoUnidade>36</codigoUnidade>");
            envelopeSoapCalcularBordero.Append("<dataMovimento>" + dataEmissaoFormatada + "-03:00</dataMovimento>");
            envelopeSoapCalcularBordero.Append("<numeroLote>" + numeroLote + "</numeroLote>");
            envelopeSoapCalcularBordero.Append("<numeroContrato>" + numeroContrato + "</numeroContrato>");
            envelopeSoapCalcularBordero.Append("<numeroAdlib>0</numeroAdlib>");
            envelopeSoapCalcularBordero.Append("<numeroLancamento>0</numeroLancamento>");
            envelopeSoapCalcularBordero.Append("<situacaoContrato>FECHADO</situacaoContrato>");
            envelopeSoapCalcularBordero.Append("<codigoCliente>" + codigoCedenteConvertido + "</codigoCliente>");
            envelopeSoapCalcularBordero.Append("<siglaModalidade>CBSJ</siglaModalidade>");
            envelopeSoapCalcularBordero.Append("<siglaOrigemInterface>MANUAL</siglaOrigemInterface>");
            envelopeSoapCalcularBordero.Append("<codigoCobrador>653</codigoCobrador>");
            envelopeSoapCalcularBordero.Append("<siglaLinhaOperacao>COB</siglaLinhaOperacao>");
            envelopeSoapCalcularBordero.Append("<dataProcessamentoEfetivo>" + dataProcessamentoFormatado + "-03:00</dataProcessamentoEfetivo>"); 
            envelopeSoapCalcularBordero.Append("<loteComplementar>false</loteComplementar>");
            envelopeSoapCalcularBordero.Append("<tipoTitulo>");
            envelopeSoapCalcularBordero.Append("<codigoUsuarioAtualizador>TB</codigoUsuarioAtualizador>");
            envelopeSoapCalcularBordero.Append("<dataHoraAtualizacao>2007-05-18T11:10:29-03:00</dataHoraAtualizacao>");
            envelopeSoapCalcularBordero.Append("<siglaTipoTitulo>DUP</siglaTipoTitulo>");
            envelopeSoapCalcularBordero.Append("<descricaoTitulo>CAUCAO - DUPLICATAS</descricaoTitulo>");
            envelopeSoapCalcularBordero.Append("</tipoTitulo>");
            envelopeSoapCalcularBordero.Append("<dataOperacao>"+ dataEmissaoFormatada + "-03:00</dataOperacao>");
            envelopeSoapCalcularBordero.Append("<dataHoraInclusaoOperacao>" + DateTime.Now.ToString("yyyy-MM-dd") + "T" + DateTime.Now.ToString("HH:mm:ss") + "-03:00</dataHoraInclusaoOperacao>");
            envelopeSoapCalcularBordero.Append("<quantidadeTitulos>" + quantidadeTitulos + "</quantidadeTitulos>");
            envelopeSoapCalcularBordero.Append("<aceite>NAO</aceite>");
            envelopeSoapCalcularBordero.Append("<quantidadeDigitacaoContrato>0</quantidadeDigitacaoContrato>");
            envelopeSoapCalcularBordero.Append("<quantidadePrivateDatasCalculado>0</quantidadePrivateDatasCalculado>");
            envelopeSoapCalcularBordero.Append("<quantidadeTitulosCalculado>0</quantidadeTitulosCalculado>");
            envelopeSoapCalcularBordero.Append("<codigoGerente>8400</codigoGerente>");
            envelopeSoapCalcularBordero.Append("<destinacaoAutomatica>false</destinacaoAutomatica>");
            envelopeSoapCalcularBordero.Append("<valorTotal>" + valorTotalDoLote.ToString(nfi)  + "</valorTotal>");
            envelopeSoapCalcularBordero.Append("<valorTarifaAbertura>0</valorTarifaAbertura>");
            envelopeSoapCalcularBordero.Append("<valorTarifaCobranca>0</valorTarifaCobranca>");
            envelopeSoapCalcularBordero.Append("<valorPrincipal>0</valorPrincipal>");
            envelopeSoapCalcularBordero.Append("<valorPrincipalCalculado>0</valorPrincipalCalculado>");
            envelopeSoapCalcularBordero.Append("<valorJuros>0</valorJuros>");
            envelopeSoapCalcularBordero.Append("<valorLiquido>0</valorLiquido>");
            envelopeSoapCalcularBordero.Append("<valorAdiantamento>0</valorAdiantamento>");
            envelopeSoapCalcularBordero.Append("<valorTotalCalculado>0</valorTotalCalculado>");
            envelopeSoapCalcularBordero.Append("<valorDesconto>0</valorDesconto>");
            envelopeSoapCalcularBordero.Append("<valorTotalPadrao>0</valorTotalPadrao>");
            envelopeSoapCalcularBordero.Append("<taxaOperacaoCalculada>0</taxaOperacaoCalculada>");
            envelopeSoapCalcularBordero.Append("<taxaOver>0</taxaOver>");
            envelopeSoapCalcularBordero.Append("<taxaOverCalculada>0</taxaOverCalculada>");
            envelopeSoapCalcularBordero.Append("<taxaMedia>0</taxaMedia>");
            envelopeSoapCalcularBordero.Append("<taxaMediaVencimento>0</taxaMediaVencimento>");
            envelopeSoapCalcularBordero.Append("<taxaMediaEfetiva>0</taxaMediaEfetiva>");
            envelopeSoapCalcularBordero.Append("<taxaEfetivaDiasUteis>0</taxaEfetivaDiasUteis>");
            envelopeSoapCalcularBordero.Append("<taxaPeriodo>0</taxaPeriodo>");
            envelopeSoapCalcularBordero.Append("<numeroDirecionamentoCredito>A_4500</numeroDirecionamentoCredito>");
            envelopeSoapCalcularBordero.Append("<prazoVencimentoCorrecao>0</prazoVencimentoCorrecao>");
            envelopeSoapCalcularBordero.Append("<prazoEfetivoCorrido>0</prazoEfetivoCorrido>");
            envelopeSoapCalcularBordero.Append("<prazoEfetivoDiasUteis>0</prazoEfetivoDiasUteis>");
            envelopeSoapCalcularBordero.Append("<prazoPeriodo>0</prazoPeriodo>");
            envelopeSoapCalcularBordero.Append("<coeficienteDiario>0</coeficienteDiario>");
            envelopeSoapCalcularBordero.Append("<identificadorCriterioLiquidacao>SEM_LIQUIDACAO</identificadorCriterioLiquidacao>");
            envelopeSoapCalcularBordero.Append("<reembolsoAutomatico>false</reembolsoAutomatico>");
            envelopeSoapCalcularBordero.Append("<quantidadeReembolsoAutomatico>0</quantidadeReembolsoAutomatico>");
            envelopeSoapCalcularBordero.Append("<identificadorOrigemLote>D</identificadorOrigemLote>");
            envelopeSoapCalcularBordero.Append("<identificadorConvenioCnab>false</identificadorConvenioCnab>");
            envelopeSoapCalcularBordero.Append("<alteracaoEncargos>false</alteracaoEncargos>");
            envelopeSoapCalcularBordero.Append("<alteracaoLiquidacao>false</alteracaoLiquidacao>");
            envelopeSoapCalcularBordero.Append("<alteracaoReembolso>false</alteracaoReembolso>");
            envelopeSoapCalcularBordero.Append("<identificadorTipoCheque>N</identificadorTipoCheque>");
            envelopeSoapCalcularBordero.Append("<identificadorDiasAte30Dias>CORRIDOS</identificadorDiasAte30Dias>");
            envelopeSoapCalcularBordero.Append("<taxaPermanenciaAte30Dias>4</taxaPermanenciaAte30Dias>");
            envelopeSoapCalcularBordero.Append("<identificadorFormaAte30Dias>CAPITALIZADO</identificadorFormaAte30Dias>");
            envelopeSoapCalcularBordero.Append("<identificadorDiasMais30Dias>CORRIDOS</identificadorDiasMais30Dias>");
            envelopeSoapCalcularBordero.Append("<taxaPermanenciaMais30Dias>4</taxaPermanenciaMais30Dias>");
            envelopeSoapCalcularBordero.Append("<identificadorformaMais30Dias>LINEAR</identificadorformaMais30Dias>");
            envelopeSoapCalcularBordero.Append("<percentualMulta>2</percentualMulta>");
            envelopeSoapCalcularBordero.Append("<quantidadeDiasMulta>0</quantidadeDiasMulta>");
            envelopeSoapCalcularBordero.Append("<valorTaxaSpread>0</valorTaxaSpread>");
            envelopeSoapCalcularBordero.Append("<identificadorBaseSpread>DEVEDOR</identificadorBaseSpread>");
            envelopeSoapCalcularBordero.Append("<identificadorFormatoSpread>CONFIGURACAO</identificadorFormatoSpread>");
            envelopeSoapCalcularBordero.Append("<identificadorCriterioOperacao>NAO_UTILIZA</identificadorCriterioOperacao>");
            envelopeSoapCalcularBordero.Append("<baseCalculoMulta>DEVEDOR</baseCalculoMulta>");
            envelopeSoapCalcularBordero.Append("<taxaLimiteMora>0</taxaLimiteMora>");
            envelopeSoapCalcularBordero.Append("<identificadorTipoLimite>SEM_LIMITE</identificadorTipoLimite>");
            envelopeSoapCalcularBordero.Append("<codigoUsuarioCadastrado>GERADOR COB</codigoUsuarioCadastrado>");
            envelopeSoapCalcularBordero.Append("<codigoUsuarioRecebido>GERADOR COB</codigoUsuarioRecebido>");
            envelopeSoapCalcularBordero.Append("<valorJurosADescontar>0</valorJurosADescontar>");
            envelopeSoapCalcularBordero.Append("<valorIOCADescontar>0</valorIOCADescontar>");
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////   
            ///
            //DialogResult dialogo4 = MessageBox.Show(listaTitulosXml.Count.ToString(), "Informação", MessageBoxButtons.OK);
            for (int i = 0; i < listaTitulosXml.Count; i++)
            {

                envelopeSoapCalcularBordero.Append(listaTitulosXml[i]);
                //DialogResult dialogo5 = MessageBox.Show(listaTitulosXml[i].ToString(), "Informação", MessageBoxButtons.OK);
            }          
       
            envelopeSoapCalcularBordero.Append("</movimentoContrato>");
            envelopeSoapCalcularBordero.Append("<persistirBordero>true</persistirBordero>");
            envelopeSoapCalcularBordero.Append("</ns2:calcularBordero>");
            envelopeSoapCalcularBordero.Append("</soap:Body>");
            envelopeSoapCalcularBordero.Append("</soap:Envelope>");

            soapEnvelopeDocument.LoadXml(envelopeSoapCalcularBordero.ToString());

            string nomeArquivoRequest = DateTime.Now.ToString("ddMMyyyyHHmmss");
            string diretorio = @"C:\\TotalBanco\\Crediblaster\\GeraRem\\xml\\" + "CalcularBordero" + nomeArquivoRequest + "_request.xml";

            using (StreamWriter sw = File.CreateText(diretorio))
            {
                sw.WriteLine(envelopeSoapCalcularBordero.ToString());
            }

            /*
            string nomeArquivoResponse = DateTime.Now.ToString("ddMMyyyyHHmmss");
            diretorio = @"C:\\TotalBanco\\Crediblaster\\GeraRem\\xml\\" + "incluirBorderoCapaLote" + nomeArquivoResponse + "_response.xml";

            using (StreamWriter sw = File.CreateText(diretorio))
            {
                sw.WriteLine(soapEnvelopeDocument.ToString());
            }
            */
            CallWebService_(soapEnvelopeDocument, "CalcularBordero");

            return soapEnvelopeDocument;
        }

        private static void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                //DialogResult dialogo4 = MessageBox.Show(stream.ToString(), "Informação", MessageBoxButtons.OK);
                soapEnvelopeXml.Save(stream);
            }   
        }
    }
}
