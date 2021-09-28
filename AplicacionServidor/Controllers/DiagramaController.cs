using AplicaciónServidor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AplicacionServidor.Controllers
{
    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class DiagramaController : ApiController
    {
        BdAplicacionServidor bdAplicacionServidor = new BdAplicacionServidor();

        [HttpGet]
        public IEnumerable<tbl_Diagrama> Get()
        {
            var diagramas = bdAplicacionServidor.diagramas.ToList();
            return diagramas;
        }

        [HttpPost()]
        public String Post( [FromUri]string nombre, [FromBody]  string plano)
        {
            tbl_Diagrama diagrama = new tbl_Diagrama(nombre, plano);
            
            
            bdAplicacionServidor.diagramas.InsertOnSubmit(diagrama);
            bdAplicacionServidor.SubmitChanges();
            return plano;
        }

        // PUT api/values/5  
        
        [HttpPut()]
        public void Put([FromUri] int id, [FromUri] string nombre,[FromBody]string plano)
        {
            var diagrama = (from i in bdAplicacionServidor.diagramas
                            where i.idDiagrma == id
                            select i).FirstOrDefault();

            diagrama.nombre = nombre;
            diagrama.plano = plano;
            bdAplicacionServidor.SubmitChanges();
        }


        [HttpDelete()]
        public void Delete([FromUri]  int id)
        {
            var diagrama = (from i in bdAplicacionServidor.diagramas
                            where i.idDiagrma == id
                            select i).FirstOrDefault();
            if (diagrama != null)
            {
                
                bdAplicacionServidor.diagramas.DeleteOnSubmit(diagrama);
                bdAplicacionServidor.SubmitChanges();
            }
        }


    }
}