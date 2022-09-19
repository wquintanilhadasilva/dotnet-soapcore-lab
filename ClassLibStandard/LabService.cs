using ClassLibStandard.Contracts;
using System;
using System.ServiceModel;

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

    }
}
