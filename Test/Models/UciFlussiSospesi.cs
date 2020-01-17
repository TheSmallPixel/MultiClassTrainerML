using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class UciFlussiSospesi
    {
        public int IdFlussoUci { get; set; }
        public DateTime? DtCaricamento { get; set; }
        public DateTime? DtAbbinamento { get; set; }
        public int? IdSinistro { get; set; }
        public int? IdEntitaCoinvolta { get; set; }
        public int IdCompagnia { get; set; }
        public string MotivoScarto { get; set; }
        public int? AnnoEsercizio { get; set; }
        public string NSinistro { get; set; }
        public string CodiceTipoSinistro { get; set; }
        public string CodiceNazioneAssicurato { get; set; }
        public string CodiceNazioneControparte { get; set; }
        public string SiglaOperatoreUci { get; set; }
        public DateTime? DtDenuncia { get; set; }
        public DateTime? DtAvvenimento { get; set; }
        public DateTime? DtIncarico { get; set; }
        public string LocalitaSinistro { get; set; }
        public string NomeAssicurato { get; set; }
        public string IndirizzoAssicurato { get; set; }
        public string CapAssicurato { get; set; }
        public string LocalitaAssicurato { get; set; }
        public string ProvinciaAssicurato { get; set; }
        public string StatoAssicurato { get; set; }
        public string SiglaTargaAssicurato { get; set; }
        public string TargaAssicurato { get; set; }
        public string CodiceCompagniaMandataria { get; set; }
        public string DescCompagniaMandataria { get; set; }
        public string CodiceCompagniaIncaricata { get; set; }
        public string DescCompagniaIncaricata { get; set; }
        public string CodiceBureau { get; set; }
        public string DescrizioneBureau { get; set; }
        public string NumeroProgressivoControparte { get; set; }
        public string NomeControparte { get; set; }
        public string IndirizzoControparte { get; set; }
        public string CapControparte { get; set; }
        public string LocalitaControparte { get; set; }
        public string SiglaProvinciaControparte { get; set; }
        public string SiglaNazioneControparte { get; set; }
        public string SiglaTargaControparte { get; set; }
        public string TargaControparte { get; set; }
        public string NomeLegaleControparte { get; set; }
        public string IndirizzoLegaleControparte { get; set; }
        public string CapLegaleControparte { get; set; }
        public string LocalitaLegaleControparte { get; set; }
        public string ProvinciaLegaleControparte { get; set; }
        public string NazioneLegaleControparte { get; set; }
        public string PraticaLegaleControparte { get; set; }
        public string TelefonoLegaleControparte { get; set; }
        public string EmailLegaleControparte { get; set; }
        public DateTime? DtRicRichiestaUci { get; set; }
    }
}
