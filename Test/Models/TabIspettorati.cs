using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabIspettorati
    {
        public decimal KeyIspettorato { get; set; }
        public decimal IdIspettorato { get; set; }
        public string CodIspettorato { get; set; }
        public decimal IdAnagrafica { get; set; }
        public DateTime? DtIniRapporto { get; set; }
        public DateTime? DtFinRapporto { get; set; }
        public decimal? IdAreaSinistri { get; set; }
        public decimal? IdDescrizione { get; set; }
        public decimal? IdIndirizzo { get; set; }
        public DateTime? DtResponsabileDal { get; set; }
        public string NumTelefono1 { get; set; }
        public string NumTelefono2 { get; set; }
        public string NumTelefono3 { get; set; }
        public string NumSelezioneDiretta { get; set; }
        public string NumFax { get; set; }
        public DateTime? DtStoEffettoLog { get; set; }
        public DateTime? DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal? IdUtente { get; set; }
        public string Descrizione { get; set; }
        public string FlgBloccoAbbChiusureSino { get; set; }
        public string Email { get; set; }
        public string FlgVisSpeseAltriIspSino { get; set; }
        public string FlgOutsourcerSino { get; set; }
        public int? IdFiduciario { get; set; }
        public string FlgTipoLiquidazione { get; set; }
        public string NotaOrarioRicevimentoPubb { get; set; }
        public string NotaOrarioRicevimento { get; set; }
        public int? IdUtenteResponsabile { get; set; }
        public string FlgUnitaAntifrodeSino { get; set; }
    }
}
