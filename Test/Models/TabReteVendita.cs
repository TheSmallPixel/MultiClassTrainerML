using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabReteVendita
    {
        public decimal KeyRetevendita { get; set; }
        public decimal IdRetevendita { get; set; }
        public decimal? IdRetevenditaSup { get; set; }
        public decimal? IdRetevenditaPrincipale { get; set; }
        public string CodReteVendita { get; set; }
        public string CodGestione { get; set; }
        public string FlgTipoGestione { get; set; }
        public decimal? IdDescrizione { get; set; }
        public decimal? IdAnagrafica { get; set; }
        public DateTime? DtIniRapporto { get; set; }
        public DateTime? DtFinRapporto { get; set; }
        public string FlgTipoPeriodicita { get; set; }
        public string FlgTipoReteVendita { get; set; }
        public string FlgTipoVenditore { get; set; }
        public decimal? Livello { get; set; }
        public string FlgCassaPrevidenzaSino { get; set; }
        public string FlgTipoCanaleDistrAnia { get; set; }
        public string FlgTipoRetrocessione { get; set; }
        public decimal? IdRetevenditaAltri { get; set; }
        public decimal? IdRetevenditaComm { get; set; }
        public string FlgAppartenenzaRete { get; set; }
        public string FlgGruppoGestioneAgenti { get; set; }
        public string FlgTecnicaDistr { get; set; }
        public string FlgSezioneRegistroApp { get; set; }
        public decimal? IdIndirizzo { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Telefono3 { get; set; }
        public string SelezioneDiretta { get; set; }
        public string Fax { get; set; }
        public string EMailIstituzionale { get; set; }
        public string EMailIstituzionale2 { get; set; }
        public string EMail { get; set; }
        public string SitoIstituzionale { get; set; }
        public string SitoPersonale { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
        public string FlgConsolidatoSino { get; set; }
        public DateTime? DtInizioGestione { get; set; }
        public DateTime? DtFineGestione { get; set; }
        public string Descrizione { get; set; }
        public decimal? IdCausale { get; set; }
        public string FlgAnagVisibileFigliSino { get; set; }
        public string RiferimentoEsterno { get; set; }
        public string FlgFirmaGrafoSino { get; set; }
        public string FlgSubAbilEmisDiretSino { get; set; }
        public string FlgSubAbilIncasDiretSino { get; set; }
        public string FlgLdaSino { get; set; }
        public string FlgProgettoCpmiSino { get; set; }
        public int? IdListino { get; set; }
        public string FlgMandConFinanziariaSino { get; set; }
        public string MotRevocaMandFinanziaria { get; set; }
        public string FlgDisabilRimessaSino { get; set; }
        public string FlgDerogaTerritorialeSino { get; set; }
        public decimal? LivelloDerogaTerritoriale { get; set; }
        public string FlgAvvisiScadPol { get; set; }
        public string FlgDisabilitaScontiSino { get; set; }
        public string FlgAzzeraScontoRcaSino { get; set; }
        public string FlgTipoIntermReclamo { get; set; }
        public string FlgTipoFirmaEmail { get; set; }
        public string FlgBloccaForzaImpWsSino { get; set; }
        public int? GgLimiteSenzaEffRca { get; set; }
        public string FlgScadPolCruscottoSino { get; set; }
        public string FlgPropostaRinnovoSino { get; set; }
        public string FlgAbilModQuietSino { get; set; }
        public string FlgRateizzazionePremioSino { get; set; }
        public string FlgDirezioneEstero { get; set; }
    }
}
