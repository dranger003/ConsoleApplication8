using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace ClassLibrary1
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string Ping();

        //[OperationContract]
        //bool Send(byte[] data);
    }

    [ServiceContract]
    public interface IService2
    {
        [OperationContract]
        string Ping2();
    }

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single)]
    public class Service : IService, IService2
    {
        //private bool _firstRun = true;
        //private DateTime _start;
        //private int _bytes;

        public string Ping()
        {
            Console.WriteLine("Ping()");
            return "OK";
        }

        public string Ping2()
        {
            Console.WriteLine("Ping2()");
            return "OK2";
        }

        //public bool Send(byte[] data)
        //{
        //    if (_firstRun)
        //    {
        //        _firstRun = false;
        //        _start = DateTime.Now;
        //        _bytes = 0;
        //    }

        //    _bytes += data.Length;

        //    Console.Write("\r                                     \r{0} bytes, {1:N2} MiB/s", _bytes, _bytes / (DateTime.Now - _start).TotalSeconds / 1048576.0);

        //    return true;
        //}
    }
}
