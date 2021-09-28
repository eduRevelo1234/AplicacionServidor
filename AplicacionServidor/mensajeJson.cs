using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionServidor
{
    public class MensajeJson
    {
    }
    public class Device
    {
        public string id { get; set; }
    }

    public class BaseStation
    {
        public string id { get; set; }
    }

    public class Rinfo
    {
        public BaseStation baseStation { get; set; }
        public double delay { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
    }

    public class Root
    {
        public Device device { get; set; }
        public string time { get; set; }
        public string data { get; set; }
        public string rolloverCounter { get; set; }
        public int seqNumber { get; set; }
        public List<Rinfo> rinfos { get; set; }
        public List<object> satInfos { get; set; }
        public string nbFrames { get; set; }
        public string operatorR { get; set; }
        public string country { get; set; }
        public string lqi { get; set; }
    }

    public class Paging
    {
    }

    public class ResultadoMensaje
    {
        public List<Root> data { get; set; }
        public Paging paging { get; set; }
    }
}