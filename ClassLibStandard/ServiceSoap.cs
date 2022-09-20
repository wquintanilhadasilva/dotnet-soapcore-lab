using ClassLibStandard.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ClassLibStandard
{
    public class ServiceSoap
    {

        private const string URL = "https://endereco.web.service.br/sei/ws/SeiWS.php";

        public async Task<RetornoInclusaoDocumento> IncluirDoc()
        {
            Documento documento = new Documento();
            // SETTER ....
            HttpResponseMessage response = await PostXmlRequest(URL, documento.ToSoapEnvelop());
            string content = await response.Content.ReadAsStringAsync();
            var retornoInclusaoDocumento = DeserializeInnerSoapObject(content);
            return retornoInclusaoDocumento;
        }

        public static async Task<HttpResponseMessage> PostXmlRequest(string baseUrl, string xmlString)
        {
            using (var httpClient = new HttpClient())
            {
                var httpContent = new StringContent(xmlString, Encoding.UTF8, "text/xml");
                httpContent.Headers.Add("SeiAction", string.Concat(baseUrl,"?op=incluirDocumento"));
                return await httpClient.PostAsync(baseUrl, httpContent);
            }
        }

        private static RetornoInclusaoDocumento DeserializeInnerSoapObject(string soapResponse)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(soapResponse);
            var soapBody = xmlDocument.GetElementsByTagName("parametros");
            var xmlOuter = soapBody[0].ChildNodes;
            RetornoInclusaoDocumento retornoInclusaoDocumento = new RetornoInclusaoDocumento();
            foreach (var item in xmlOuter)
            {
                var valor = item as XmlNode;
                switch (valor.Name)
                {
                    case "IdDocumento" :
                        retornoInclusaoDocumento.IdDocumento = valor.InnerText;
                        break;
                    case "DocumentoFormatado":
                        retornoInclusaoDocumento.DocumentoFormatado = valor.InnerText;
                        break;
                    case "LinkAcesso":
                        retornoInclusaoDocumento.LinkAcesso = valor.InnerText;
                        break;
                    default:
                        break;
                }
            }
            return retornoInclusaoDocumento;
        }
    }
}
