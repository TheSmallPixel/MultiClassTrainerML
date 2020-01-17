using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolPolizze
    {
        public PolPolizze()
        {
            PolAgenzie = new HashSet<PolAgenzie>();
            PolAllegati = new HashSet<PolAllegati>();
            PolAppendici = new HashSet<PolAppendici>();
            PolAssicurati = new HashSet<PolAssicurati>();
            PolAutorizzazioni = new HashSet<PolAutorizzazioni>();
            PolBeneficiari = new HashSet<PolBeneficiari>();
            PolBeni = new HashSet<PolBeni>();
            PolCoass = new HashSet<PolCoass>();
            PolConducenti = new HashSet<PolConducenti>();
            PolContraenti = new HashSet<PolContraenti>();
            PolContratto = new HashSet<PolContratto>();
            PolCoobbligati = new HashSet<PolCoobbligati>();
            PolDatiTecniciUbicazioni = new HashSet<PolDatiTecniciUbicazioni>();
            PolDatiTecniciVeicoli = new HashSet<PolDatiTecniciVeicoli>();
            PolEsitoFranchigie = new HashSet<PolEsitoFranchigie>();
            PolEventi = new HashSet<PolEventi>();
            PolFranchigie = new HashSet<PolFranchigie>();
            PolGarDettagli = new HashSet<PolGarDettagli>();
            PolGaranzie = new HashSet<PolGaranzie>();
            PolGaranzieFirma = new HashSet<PolGaranzieFirma>();
            PolGaranzieRegolate = new HashSet<PolGaranzieRegolate>();
            PolOperazioniFondi = new HashSet<PolOperazioniFondi>();
            PolOptional = new HashSet<PolOptional>();
            PolParametri = new HashSet<PolParametri>();
            PolPremiFirma = new HashSet<PolPremiFirma>();
            PolProprietari = new HashSet<PolProprietari>();
            PolProvvigioni = new HashSet<PolProvvigioni>();
            PolProvvigioniFirma = new HashSet<PolProvvigioniFirma>();
            PolRca = new HashSet<PolRca>();
            PolRegPremio = new HashSet<PolRegPremio>();
            PolRichiesteRegolazione = new HashSet<PolRichiesteRegolazione>();
            PolRischioImpiego = new HashSet<PolRischioImpiego>();
            PolSegnalazioni = new HashSet<PolSegnalazioni>();
            PolSinistri = new HashSet<PolSinistri>();
            PolSinistriMovimenti = new HashSet<PolSinistriMovimenti>();
            PolSostituite = new HashSet<PolSostituite>();
            PolStati = new HashSet<PolStati>();
            PolUbicazioni = new HashSet<PolUbicazioni>();
            PolVariabili = new HashSet<PolVariabili>();
            PolVariapremi = new HashSet<PolVariapremi>();
            PolVeicoli = new HashSet<PolVeicoli>();
            PolVincoli = new HashSet<PolVincoli>();
            RegTitoli = new HashSet<RegTitoli>();
            TitTitoli = new HashSet<TitTitoli>();
        }

        public decimal IdPolizza { get; set; }
        public decimal IdCompagnia { get; set; }
        public string NPolizza { get; set; }
        public string NProposta { get; set; }
        public decimal IdPrProdotto { get; set; }
        public DateTime? DtEffetto { get; set; }
        public string HhmmEffetto { get; set; }
        public DateTime? DtScadenzaOrig { get; set; }
        public string FlgModProvOrig { get; set; }
        public string NRifEsterno { get; set; }
        public DateTime? DtProdotto { get; set; }
        public string NPreventivo { get; set; }
        public string FlgPolizzaBaseSino { get; set; }
        public string FlgSistemaProvenienza { get; set; }

        public virtual ICollection<PolAgenzie> PolAgenzie { get; set; }
        public virtual ICollection<PolAllegati> PolAllegati { get; set; }
        public virtual ICollection<PolAppendici> PolAppendici { get; set; }
        public virtual ICollection<PolAssicurati> PolAssicurati { get; set; }
        public virtual ICollection<PolAutorizzazioni> PolAutorizzazioni { get; set; }
        public virtual ICollection<PolBeneficiari> PolBeneficiari { get; set; }
        public virtual ICollection<PolBeni> PolBeni { get; set; }
        public virtual ICollection<PolCoass> PolCoass { get; set; }
        public virtual ICollection<PolConducenti> PolConducenti { get; set; }
        public virtual ICollection<PolContraenti> PolContraenti { get; set; }
        public virtual ICollection<PolContratto> PolContratto { get; set; }
        public virtual ICollection<PolCoobbligati> PolCoobbligati { get; set; }
        public virtual ICollection<PolDatiTecniciUbicazioni> PolDatiTecniciUbicazioni { get; set; }
        public virtual ICollection<PolDatiTecniciVeicoli> PolDatiTecniciVeicoli { get; set; }
        public virtual ICollection<PolEsitoFranchigie> PolEsitoFranchigie { get; set; }
        public virtual ICollection<PolEventi> PolEventi { get; set; }
        public virtual ICollection<PolFranchigie> PolFranchigie { get; set; }
        public virtual ICollection<PolGarDettagli> PolGarDettagli { get; set; }
        public virtual ICollection<PolGaranzie> PolGaranzie { get; set; }
        public virtual ICollection<PolGaranzieFirma> PolGaranzieFirma { get; set; }
        public virtual ICollection<PolGaranzieRegolate> PolGaranzieRegolate { get; set; }
        public virtual ICollection<PolOperazioniFondi> PolOperazioniFondi { get; set; }
        public virtual ICollection<PolOptional> PolOptional { get; set; }
        public virtual ICollection<PolParametri> PolParametri { get; set; }
        public virtual ICollection<PolPremiFirma> PolPremiFirma { get; set; }
        public virtual ICollection<PolProprietari> PolProprietari { get; set; }
        public virtual ICollection<PolProvvigioni> PolProvvigioni { get; set; }
        public virtual ICollection<PolProvvigioniFirma> PolProvvigioniFirma { get; set; }
        public virtual ICollection<PolRca> PolRca { get; set; }
        public virtual ICollection<PolRegPremio> PolRegPremio { get; set; }
        public virtual ICollection<PolRichiesteRegolazione> PolRichiesteRegolazione { get; set; }
        public virtual ICollection<PolRischioImpiego> PolRischioImpiego { get; set; }
        public virtual ICollection<PolSegnalazioni> PolSegnalazioni { get; set; }
        public virtual ICollection<PolSinistri> PolSinistri { get; set; }
        public virtual ICollection<PolSinistriMovimenti> PolSinistriMovimenti { get; set; }
        public virtual ICollection<PolSostituite> PolSostituite { get; set; }
        public virtual ICollection<PolStati> PolStati { get; set; }
        public virtual ICollection<PolUbicazioni> PolUbicazioni { get; set; }
        public virtual ICollection<PolVariabili> PolVariabili { get; set; }
        public virtual ICollection<PolVariapremi> PolVariapremi { get; set; }
        public virtual ICollection<PolVeicoli> PolVeicoli { get; set; }
        public virtual ICollection<PolVincoli> PolVincoli { get; set; }
        public virtual ICollection<RegTitoli> RegTitoli { get; set; }
        public virtual ICollection<TitTitoli> TitTitoli { get; set; }
    }
}
