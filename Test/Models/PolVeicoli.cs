using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PolVeicoli
    {
        public decimal KeyPolVeicolo { get; set; }
        public decimal? IdPolVeicolo { get; set; }
        public decimal? IdPolizza { get; set; }
        public decimal? IdPolBene { get; set; }
        public decimal? IdUtente { get; set; }
        public decimal? IdSettore { get; set; }
        public decimal? IdClasse { get; set; }
        public decimal? IdUso { get; set; }
        public decimal? IdAllestimento { get; set; }
        public string Descrizione { get; set; }
        public string FlgTipoTarga { get; set; }
        public string Targa { get; set; }
        public string Telaio { get; set; }
        public DateTime? DtImmatricolazione { get; set; }
        public string FlgAbrogaSino { get; set; }
        public decimal? ImpValoreVeicolo { get; set; }
        public string NTesseraAssistenza { get; set; }
        public decimal? IdPolRca { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdValuta { get; set; }
        public decimal? IdNazione { get; set; }
        public string CodIvehicle { get; set; }
        public string XmlVisura { get; set; }
        public string FlgCoperturaAuto { get; set; }
        public string FlgSiglaTargaSpeciale { get; set; }
        public string TargaAnia { get; set; }
        public string CodOmologazione4ruote { get; set; }
        public int? IdNazioneImm { get; set; }
        public string FlgTipoVeicoloMctc { get; set; }

        public virtual PolPolizze IdPolizzaNavigation { get; set; }
    }
}
