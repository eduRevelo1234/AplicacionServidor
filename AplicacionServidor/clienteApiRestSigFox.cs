using Newtonsoft.Json;
using RestSharp;
using RestSharp.Extensions;
using System.IO;
using System.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace AplicacionServidor
{
    public class ClienteApiRestSigFox
    {
        public dynamic GetMensajes(string url)
        {
            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(url);
            myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";
            myWebRequest.Credentials = new NetworkCredential("5f357d4725643258bc5e86e4", "abae22e78428f22a9b094e68e0c29f82");
            myWebRequest.Proxy = null;
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
            Stream myStream = myHttpWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myStream);
            string Datos = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd());
            var data = JsonConvert.DeserializeObject<ResultadoMensaje>(Datos);
            return data;
        }


        public dynamic GetDispositivos(string url)
        {
            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(url);
            myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";
            myWebRequest.Credentials = new NetworkCredential("5f357d4725643258bc5e86e4", "abae22e78428f22a9b094e68e0c29f82");
            myWebRequest.Proxy = null;
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
            Stream myStream = myHttpWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myStream);
            string Datos = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd());
            var data = JsonConvert.DeserializeObject<ResultadoDispositivos>(Datos);
            return data;
        }
    }
}