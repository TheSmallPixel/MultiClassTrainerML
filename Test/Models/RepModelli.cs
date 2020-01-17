using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class RepModelli
    {
        public RepModelli()
        {
            PrModelliAppendici = new HashSet<PrModelliAppendici>();
            PrModelliOperazioni = new HashSet<PrModelliOperazioni>();
            PrModelliProdAppendici = new HashSet<PrModelliProdAppendici>();
            PrModelliProdotti = new HashSet<PrModelliProdotti>();
            RepModelliLingue = new HashSet<RepModelliLingue>();
        }

        public decimal IdModello { get; set; }
        public string Codice { get; set; }
        public string Versione { get; set; }
        public decimal IdDescrizione { get; set; }
        public string UrlRptCrystalReport { get; set; }
        public string UrlRdlcRs { get; set; }
        public string FlgSoloBackgroundSino { get; set; }
        public string FlgArchiviabileSino { get; set; }
        public string FlgCancellabileAutSino { get; set; }
        public string Note { get; set; }
        public string PasswordPdf { get; set; }
        public string FlgStampaPdfSino { get; set; }
        public string FlgModificaPdfSino { get; set; }
        public string FlgCopiaPdfSino { get; set; }
        public string FlgVersionePdf { get; set; }
        public string FlgLivelloCodificaPdf { get; set; }
        public string Descrizione { get; set; }
        public string FlgCartaIntestataSino { get; set; }
        public string FlgFascicoloElettronico { get; set; }
        public string FlgElencoIndirizziSino { get; set; }
        public string FlgConsentiBozzaSino { get; set; }
        public int? LivelloVisibilita { get; set; }
        public string FlgMacroTipologiaModello { get; set; }
        public string FlgTipologiaModello { get; set; }
        public string Url { get; set; }
        public string FlgFirmaGrafoSino { get; set; }
        public string FlgSistemaPostalizzazione { get; set; }
        public string FlgTipoPostalizzazione { get; set; }
        public string PercorsoCreadataset { get; set; }
        public string Parametri { get; set; }
        public string FlgPostAColoriSino { get; set; }
        public string FlgPostFronteRetroSino { get; set; }
        public string FlgAnteprimaSino { get; set; }
        public string FlgSceltaMultiplaSino { get; set; }
        public string FlgInvioCcAgenzia { get; set; }
        public string CodiceEsteso { get; set; }
        public string FlgAppRistampaSino { get; set; }
        public string FlgVisHomeinsuranceSino { get; set; }
        public string FlgQrcodeSino { get; set; }
        public string FlgStampaWsSino { get; set; }
        public string FlgVisHomeInsIncassSino { get; set; }
        public string FlgRichiediFirmaSino { get; set; }

        public virtual ICollection<PrModelliAppendici> PrModelliAppendici { get; set; }
        public virtual ICollection<PrModelliOperazioni> PrModelliOperazioni { get; set; }
        public virtual ICollection<PrModelliProdAppendici> PrModelliProdAppendici { get; set; }
        public virtual ICollection<PrModelliProdotti> PrModelliProdotti { get; set; }
        public virtual ICollection<RepModelliLingue> RepModelliLingue { get; set; }
    }
}
