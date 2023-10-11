using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Gerador_de_Remessa_Cliente.Repository
{
    internal class MontaXml
    {
        public XmlDocument buscarTituarAgencia(int empresa, int unidade)
        {
            XmlDocument soapEnvelopeDocument = new XmlDocument();                       

            StringBuilder buscarTitularAgenciaXml = new StringBuilder();

            buscarTitularAgenciaXml.Append("<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:bac=\"backoffice.credito.tfs.totvs.com\">");
            buscarTitularAgenciaXml.Append("<soapenv:Header/>");
            buscarTitularAgenciaXml.Append("<soapenv:Body>");
            buscarTitularAgenciaXml.Append("<bac:buscarTitularAgencia>");
            buscarTitularAgenciaXml.Append("<buscar>");
            buscarTitularAgenciaXml.Append("<codigoEmpresa>"+ empresa +"</codigoEmpresa>");
            buscarTitularAgenciaXml.Append("<codigoUnidade>" + unidade +"</codigoUnidade>");
            buscarTitularAgenciaXml.Append("</buscar>");
            buscarTitularAgenciaXml.Append("</bac:buscarTitularAgencia>");
            buscarTitularAgenciaXml.Append("</soapenv:Body>");
            buscarTitularAgenciaXml.Append("</soapenv:Envelope>");

            soapEnvelopeDocument.LoadXml(buscarTitularAgenciaXml.ToString());

            string nomeArquivoRequest = DateTime.Now.ToString("ddMMyyyyHHmmss");
            string diretorio = @"C:\\TotalBanco\\Crediblaster\\GeraRem\\xml\\" + "buscarTituarAgencia" + nomeArquivoRequest + "_request.xml";

            using (StreamWriter sw = File.CreateText(diretorio))
            {
                sw.WriteLine(buscarTitularAgenciaXml.ToString());
            }

            return soapEnvelopeDocument;
        }
    }
}
