using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace AplicacionServidor
{
    [Table(Name = "tbl_Mensaje")]
    public class tbl_Mensaje
    {
        [Column(IsPrimaryKey = true, AutoSync = AutoSync.OnInsert, IsDbGenerated = true)]
        public int idMensaje;
        [Column]
        public int seqNumber;
        [Column]
        public string fechaMensaje;
        [Column]
        public string datosMensaje;
        [Column]
        public int lqi;
        [Column]
        public int idDispositivo;
        [Column]
        public int idDiagrma;
        public tbl_Mensaje()
        {
        }

        public tbl_Mensaje(int seqNumber, string fechaMensaje, string datosMensaje, int LQI, int idDispositivo, int idDiagrama)
        {
            this.seqNumber = seqNumber;
            this.fechaMensaje = fechaMensaje;
            this.datosMensaje = datosMensaje;
            this.lqi = LQI;
            this.idDispositivo = idDispositivo;
            this.idDiagrma = idDiagrama;
        }
    

        public int IdMensaje { get => idMensaje; set => idMensaje = value; }
        public string FechaMensaje { get => fechaMensaje; set => fechaMensaje = value; }
        public string DatosMensaje { get => datosMensaje; set => datosMensaje = value; }
        public int IdDispositivo { get => idDispositivo; set => idDispositivo = value; }
        public int SeqNumber { get => seqNumber; set => seqNumber = value; }
        public int Lqi { get => lqi; set => lqi = value; }
    }
}