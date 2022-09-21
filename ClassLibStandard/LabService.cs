using ClassLibStandard.Contracts;
using System;
using System.ServiceModel;
using System.Xml;

namespace ClassLibStandard
{
    public class LabService
    {

        public void Testar()
        {
            var binding = new BasicHttpBinding();
            var serverAddress = "http://localhost:5000/Service.svc";
            //var endpoint = new EndpointAddress(new Uri(string.Format("http://{0}:5001/Service.svc", Environment.MachineName)));
            var endpoint = new EndpointAddress(new Uri(serverAddress));
            var channelFactory = new ChannelFactory<TesteContract>(binding, endpoint);
            var serviceClient = channelFactory.CreateChannel();
            var result = serviceClient.Ping("hey");
            Console.WriteLine("Ping method result: {0}", result);
        }

        public void lerXml()
        {
            XmlDocument document = new XmlDocument();
            document.Load(@".\\acervo.xml");

            opcao1(document);
            opcao2(document);
            opcao3(document);
            opcao4(document);
            opcao5(document);
            Console.WriteLine("Concluído!");
            Console.ReadKey();

        }

        private void opcao1(XmlDocument document)
        {
            XmlNodeList livros = document.SelectNodes("acervo/livros/livro");

            Console.WriteLine("Livros");
            foreach (XmlNode livro in livros)
            {
                Console.WriteLine("\t" + livro.OuterXml);
            }
            Console.WriteLine("Filmes");
            XmlNodeList filmes = document.SelectNodes("acervo/filmes/filme");
            foreach (XmlNode filme in filmes)
            {
                string titulo = filme["titulo"].InnerText;
                string ano = filme["ano"].InnerText;
                Console.WriteLine($"\tTitulo : {titulo} Ano : {ano}");
            }
            Console.ReadKey();
        }

        private void opcao2(XmlDocument document)
        {
            XmlNode livro = document.SelectSingleNode("//livro");
            Console.WriteLine("Livro");
            Console.WriteLine("\t" + livro.OuterXml);
            Console.WriteLine("Filme");
            XmlNode filme = document.SelectSingleNode("//filme");
            string titulo = filme["titulo"].InnerText;
            string ano = filme["ano"].InnerText;
            Console.WriteLine($"\tTitulo : {titulo} Ano : {ano}");
            Console.ReadKey();
        }

        private void opcao3(XmlDocument document)
        {
            // Obter apenas os livros e filmes com o atributo verificado igual a n

            XmlNodeList resultado =
                document.SelectNodes("acervo/livros/livro[@verificado ='n'] | acervo/filmes/filme[@verificado ='n']");
            foreach (XmlNode item in resultado)
            {
                Console.WriteLine(item.OuterXml + Environment.NewLine);
            }
            Console.ReadKey();
        }

        private void opcao4(XmlDocument document)
        {
            // Obter qualquer elemento com o atributo verificado igual a n

            XmlNodeList resultado = document.SelectNodes("acervo//*[@verificado='n']");

            foreach (XmlNode item in resultado)
            {
                Console.WriteLine(item.OuterXml + Environment.NewLine);
            }
            Console.ReadKey();
        }

        private void opcao5(XmlDocument document)
        {
            // exibir apenas os atributos 's' ou 'n' de cada elemento livro

            XmlNodeList livros = document.SelectNodes("//livro");

            foreach (XmlNode livro in livros)
            {
                var atributos = livro.Attributes;
                foreach (XmlAttribute attr in atributos)
                {
                    Console.WriteLine(attr.Value + Environment.NewLine);
                }
            }
            Console.ReadKey();
        }

    }
}
