using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using SDS_LIB;

namespace SDS_Serv
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8000/");
            ServiceHost selfHost = new ServiceHost(typeof(SDS_service), baseAddress);
            try
            {
                selfHost.AddServiceEndpoint(typeof(ISDS_service), new WSHttpBinding(), "SDS_service");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);
                selfHost.Open();
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <Enter> to terminate the service.");
                Console.ReadLine();
                selfHost.Close();
            }
            catch (Exception ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                selfHost.Abort();
                Console.ReadLine();
            }
        }
    }
}
