using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq;
using AplicacionServidor;

namespace AplicaciónServidor
{
    public class BdAplicacionServidor : DataContext
    {
        public BdAplicacionServidor() : base(@"Data Source=DESKTOP-V65BFOG\SQLEXPRESS;Initial Catalog=BD_AplicacionServidor;Integrated Security=True") { }
        public Table<tbl_Mensaje> mensajes;
        public Table<tbl_Diagrama> diagramas;
        public Table<tblDispositivo> dispositivos;
    }
}