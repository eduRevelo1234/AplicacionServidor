using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionServidor
{
    public class DispositivoJson
    {
    }
    public class Location
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }

    public class DeviceType
    {
        public string id { get; set; }
    }

    public class Group
    {
        public string id { get; set; }
    }

    public class Token
    {
        public int state { get; set; }
        public string detailMessage { get; set; }
        public long end { get; set; }
    }

    public class Contract
    {
        public string id { get; set; }
    }

    public class ModemCertificate
    {
        public string id { get; set; }
    }

    public class ProductCertificate
    {
        public string id { get; set; }
    }

    public class RootD
    {
        public string id { get; set; }
        public string name { get; set; }
        public bool satelliteCapable { get; set; }
        public string lastCom { get; set; }
        public string state { get; set; }
        public string comState { get; set; }
        public Location location { get; set; }
        public DeviceType deviceType { get; set; }
        public Group group { get; set; }
        public int lqi { get; set; }
        public long activationTime { get; set; }
        public Token token { get; set; }
        public Contract contract { get; set; }
        public long creationTime { get; set; }
        public ModemCertificate modemCertificate { get; set; }
        public bool prototype { get; set; }
        public ProductCertificate productCertificate { get; set; }
        public bool automaticRenewal { get; set; }
        public int automaticRenewalStatus { get; set; }
        public string createdBy { get; set; }
        public long lastEditionTime { get; set; }
        public string lastEditedBy { get; set; }
        public bool activable { get; set; }
    }

    public class PagingD
    {
    }

    public class ResultadoDispositivos
    {
        public List<RootD> data { get; set; }
        public Paging paging { get; set; }
    }
}