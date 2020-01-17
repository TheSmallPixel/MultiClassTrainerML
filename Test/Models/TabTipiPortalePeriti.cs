using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabTipiPortalePeriti
    {
        public int KeyTipoPortalePeriti { get; set; }
        public int IdTipoPortalePeriti { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
        public string FlgTipoPortalePeriti { get; set; }
        public string ChiaveConfigUrl { get; set; }
        public string Password { get; set; }
        public string Utenza { get; set; }
        public string ProxyPassword { get; set; }
        public string ProxyUsername { get; set; }
        public string RamiTecniciAmmessi { get; set; }
        public int? NumeroTentativiAmmessi { get; set; }
        public string FlgDisabilitaFiduciarioSino { get; set; }
        public string ChiaveConfigPassword { get; set; }
        public string ChiaveConfigProxyPw { get; set; }
    }
}
