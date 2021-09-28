using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace AplicacionServidor
{
    [Table(Name = "tblDispositivo")]
    public class tblDispositivo
    {
        [Column(IsPrimaryKey = true, AutoSync = AutoSync.OnInsert, IsDbGenerated = true)]
        public int idDispositivo;
        [Column]
        public string idDisSigFox;
        [Column]
        public string nombreDispositivo;
        [Column]
        public string estadoDispositivo;
        [Column]
        public string ultimoMensaje;

        public int IdDispositivo { get => idDispositivo; set => idDispositivo = value; }
        public string NombreDispositivo { get => nombreDispositivo; set => nombreDispositivo = value; }
        public string EstadoDispositivo { get => estadoDispositivo; set => estadoDispositivo = value; }
        public string UltimoMensaje { get => ultimoMensaje; set => ultimoMensaje = value; }
        public string IdDisSigFox { get => idDisSigFox; set => idDisSigFox = value; }

        public tblDispositivo(string idDisSigFox, string nombreDispositivo, string estadoDispositivo, string ultimoMensaje, double lat, double lng)
        {
            this.idDisSigFox = idDisSigFox;
            this.nombreDispositivo = nombreDispositivo;
            this.estadoDispositivo = estadoDispositivo;
            this.ultimoMensaje = ultimoMensaje;
        }
        public tblDispositivo()
        {
        }
    }
}