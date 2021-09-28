using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace AplicacionServidor
{
    [Table(Name = "tbl_Diagrama")]
    public class tbl_Diagrama
    {
        [Column(IsPrimaryKey = true, AutoSync = AutoSync.OnInsert, IsDbGenerated = true)]
        public int idDiagrma;
        [Column]
        public string nombre;
        [Column]
        public string plano;

        public int IdDiagrma { get => idDiagrma; set => idDiagrma = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Plano { get => plano; set => plano = value; }

        public tbl_Diagrama() 
        {
        }

        public tbl_Diagrama(string nombre, string plano)
        {
            this.nombre = nombre;
            this.plano = plano;
        }


    }
}