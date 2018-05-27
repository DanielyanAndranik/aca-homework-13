using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;

using System.Text;
using System.Threading.Tasks;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = null;
            try
            {
                //Base Address for StudentService
                Uri httpBaseAddress = new Uri("http://localhost:4500/BookStore");

                //Instantiate ServiceHost
                host = new ServiceHost(typeof(BookStoreService.Store), httpBaseAddress);

                //Add Endpoint to Host
                host.AddServiceEndpoint(typeof(BookStoreService.IStore), new BasicHttpBinding(), httpBaseAddress);

                //Metadata Exchange
                ServiceMetadataBehavior serviceBehavior = new ServiceMetadataBehavior();
                serviceBehavior.HttpGetEnabled = true;
                host.Description.Behaviors.Add(serviceBehavior);

                host.Open();

                Console.WriteLine("The service is ready at {0}", httpBaseAddress);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }
            catch (Exception ex)
            {
                host = null;
                Console.WriteLine("There is an issue with StudentService" +ex.Message);
                Console.ReadLine();
            }
        }
    }
}
