using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabCarrozzerieConvenzionate
    {
        public int KeyCarrozzeriaConvenzionata { get; set; }
        public int IdCarrozzeriaConvenzionata { get; set; }
        public int? IdNetwork { get; set; }
        public int IdAnagrafica { get; set; }
        public int IdIndirizzo { get; set; }
        public string RagioneSociale { get; set; }
        public string Cld { get; set; }
        public string CodCld { get; set; }
        public string RegioneCld { get; set; }
        public string Area { get; set; }
        public string InviareMail { get; set; }
        public string ReferenteZona { get; set; }
        public string CodAge { get; set; }
        public string DecodificaAge { get; set; }
        public string Reale { get; set; }
        public string Italiana { get; set; }
        public string Convenz { get; set; }
        public string Axa { get; set; }
        public string Ubicazione { get; set; }
        public string CodUtenzaPortale { get; set; }
        public string Software { get; set; }
        public string Iso14001 { get; set; }
        public string TrasmTel { get; set; }
        public string CasaAutomobilistica { get; set; }
        public string ConvenzioneAltreComp { get; set; }
        public string SupCoperta { get; set; }
        public string SupScoperta { get; set; }
        public string CostoOrarioRmaNoIva { get; set; }
        public string CostoOrarioArsNoIva { get; set; }
        public string Delta2010 { get; set; }
        public string Delta2011 { get; set; }
        public string Delta2012 { get; set; }
        public string Delta2013 { get; set; }
        public string Delta2014 { get; set; }
        public string ScontiRicambiNazionali { get; set; }
        public string ScontiRicambiEsteri { get; set; }
        public string ScontiRicambiEquiv { get; set; }
        public string ExtraScontoImponFat { get; set; }
        public string Rebate { get; set; }
        public string MinimiGarantiti { get; set; }
        public string AutoSostitutiva { get; set; }
        public string PresaERiconsegnaVeicolo { get; set; }
        public string Traino { get; set; }
        public string VerniceAdAcqua { get; set; }
        public DateTime? DtInizioRapporto { get; set; }
        public DateTime? DtInizioArs { get; set; }
        public DateTime? DtRinnovoConv2010 { get; set; }
        public DateTime? DtRinnovoConv2011 { get; set; }
        public DateTime? DtRinnovoConv2012 { get; set; }
        public DateTime? DtRinnovoConv2013 { get; set; }
        public DateTime? DtEliminazione { get; set; }
        public string DerogaProgettoArs { get; set; }
        public string Note { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public int IdUtente { get; set; }
    }
}
