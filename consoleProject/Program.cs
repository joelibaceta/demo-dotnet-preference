using System; 
using MercadoPago.Resources;
using MercadoPago.DataStructures.Preference; 

using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Net.Security;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Text;
using System.Linq;

namespace consoleProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            MercadoPago.SDK.ClientId = Environment.GetEnvironmentVariable("CLIENT_ID");
            MercadoPago.SDK.ClientSecret = Environment.GetEnvironmentVariable("CLIENT_SECRET");

            Preference preference = new Preference();

            preference.Items.Add(
                new Item()
                {
                    Title = "Dummy Item",
                    Description = "Multicolor Item",
                    Quantity = 1,
                    UnitPrice = (float)10.0
                }
            );

            preference.Save();

            Console.WriteLine("INIT POINT: " + preference.SandboxInitPoint);

        }
    }
}