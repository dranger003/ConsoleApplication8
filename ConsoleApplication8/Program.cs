﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;

using ClassLibrary1;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServiceHost se = new ServiceHost(typeof(Service));
                se.Open();

                //Console.WriteLine("\nPress <any key> to continue.");
                while (!Console.KeyAvailable)
                    Application.DoEvents();

                Console.ReadKey(true);

                se.Close();
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
