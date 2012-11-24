using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceReference1.ServiceClient sc = new ServiceReference1.ServiceClient();

                Console.WriteLine(sc.Ping());

                //Console.WriteLine("Sending...");
                //int chunkSize = 16777216;
                //int totalSize = 134217728;
                //byte[] data = new byte[chunkSize];
                //for (int i = 0; i < totalSize; i += chunkSize)
                //    sc.Send(data);
                //Console.WriteLine("Sent.");

                Console.WriteLine("\nPress <any key> to continue.");
                Console.ReadKey(true);

                sc.Close();
            }
            catch (Exception ex)
            {
                while (ex != null)
                {
                    Console.WriteLine(ex.Message);
                    ex = ex.InnerException;
                }

                Console.ReadKey(true);
            }
        }
    }
}
