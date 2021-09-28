using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using AplicacionServidor;
using System.Web.Http.Cors;

namespace AplicaciónServidor.Controllers
{
    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class MensajeController : ApiController
    {
        
        BdAplicacionServidor bdAplicacionServidor = new BdAplicacionServidor();
        ClienteApiRestSigFox clienteApi = new ClienteApiRestSigFox();
        tbl_Mensaje mensaje;
        List<tbl_Mensaje> listaMensajes = new List<tbl_Mensaje>();
        
        [HttpGet]
        public IEnumerable<tbl_Mensaje> Get()
        {
            getMensajesSigFox();
            var mensajes = (from iter in bdAplicacionServidor.mensajes
                            select iter);
            return mensajes;
        }
        [HttpGet]
        public IEnumerable<tbl_Mensaje> Get(int id)
        {
            getMensajesSigFox();

            var mensajesDiagrama = bdAplicacionServidor.mensajes.ToList().Where(x => x.idDiagrma == id);
            
            return mensajesDiagrama;
        }

        private void getMensajesSigFox()
        {
            listaMensajes.Clear();
            List<tbl_Mensaje> mensajeRepetidos = new List<tbl_Mensaje>();
            var mensajes = (from iter in bdAplicacionServidor.mensajes
                            select iter);
            
            var respuesta = clienteApi.GetMensajes("https://api.sigfox.com/v2/device-types/5f245690e833d90362aa8d87/messages");
             
            
            foreach (var a in respuesta.data)
            {
                try
                {
                    char delimitador = '/';
                    int contador = 0;
                    string datosMensaje = a.data;
                    string datosACII = ConvertHex(datosMensaje);
                    string[] datos = datosACII.Split(delimitador);
                    var dispositivo = a.device.id;
                    int idDispositivo = 1;
                    int seqNumber = a.seqNumber;
                    string fechaMensaje = a.time;
                    int LQI = Convert.ToInt32(a.lqi);
                    int idDiagrama = Convert.ToInt32(datos[0]);
                    foreach (var i in mensajes)
                    {
                        if (a.seqNumber == i.seqNumber)
                        {
                            contador++;
                        }
                    }
                    if (contador == 0)
                    {
                        mensaje = new tbl_Mensaje(seqNumber, fechaMensaje, datosACII, LQI, idDispositivo, idDiagrama);
                        //listaMensajes.Add(mensaje);
                        bdAplicacionServidor.mensajes.InsertOnSubmit(mensaje);
                        bdAplicacionServidor.SubmitChanges();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                
            }
        }
        public static string ConvertHex(string hexString)
        {
            try
            {
                string ascii = string.Empty;

                for (int i = 0; i < hexString.Length; i += 2)
                {
                    string hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                    ulong decval = Convert.ToUInt64(hs, 16);
                    long deccc = Convert.ToInt64(hs, 16);
                    char character = Convert.ToChar(deccc);
                    ascii += character;

                }
                Console.WriteLine(ascii);
                return ascii;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            return string.Empty;
        }
    }

}
