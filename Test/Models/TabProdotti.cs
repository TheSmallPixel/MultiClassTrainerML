using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabProdotti
    {
        public decimal KeyProdotto { get; set; }
        public decimal? IdProdotto { get; set; }
        public decimal? IdCompagnia { get; set; }
        public decimal? IdRamo { get; set; }
        public string CodProdotto { get; set; }
        public decimal? IdDescrizione { get; set; }
        public string FlgSinistroSuPropostaSino { get; set; }
        public string FlgAssicuratiSino { get; set; }
        public string FlgUbicazioniSino { get; set; }
        public string FlgVeicoliSino { get; set; }
        public string FlgLineaProdotto { get; set; }
        public decimal? IdUtente { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public string Descrizione { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public string FlgDataAccEventoSino { get; set; }
    }
}
