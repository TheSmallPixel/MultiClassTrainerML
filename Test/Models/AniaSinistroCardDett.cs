using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaSinistroCardDett
    {
        public int IdAniaSinistroCardDett { get; set; }
        public int IdAniaSinistroCard { get; set; }
        public int? IdFlussoCard { get; set; }
        public int? IdSinistro { get; set; }
        public string FlgGestionarioDebitore { get; set; }
        public string FlgScartatoSino { get; set; }
        public DateTime? DtInvio { get; set; }
        public string FlgTipoVeicoloGestionario { get; set; }
        public string FlgTipoVeicoloDebitore { get; set; }
        public string IdentificativoSinistro { get; set; }
        public string FlgTipoStatoAccadimentoSin { get; set; }
        public string ProvinciaAccadimentoSin { get; set; }
        public string ProtocolloSic { get; set; }
        public string NominativoContraenteGest { get; set; }
        public string CodiceFisContraenteGest { get; set; }
        public string NominativoContraenteDeb { get; set; }
        public string NominativoConducenteDeb { get; set; }
        public string ProvPatenteConducenteDeb { get; set; }
        public string PrgPatenteConducenteDeb { get; set; }
        public string CinPatenteConducenteDeb { get; set; }
        public DateTime? DtNascitaConducenteDeb { get; set; }
        public string ProvResProprietarioGest { get; set; }
        public string ADisposizioneGestionaria { get; set; }
        public string ProtocolloSicRiscontrato { get; set; }
        public string FlgSicRispostaOnline { get; set; }
        public string FlgSicRispostaOffline { get; set; }
        public string FlgSicEsitoKo { get; set; }
        public string FlgSicNonTrovato { get; set; }
        public string FlgSicImpresaGest { get; set; }
        public string FlgSicVeicoloGest { get; set; }
        public string FlgSicImpresaDeb { get; set; }
        public string FlgSicVeicoloDeb { get; set; }
        public string FlgSicDataSinistro { get; set; }
        public string FlgTipoVeicoloForfait { get; set; }
        public string ProvinciaForfait { get; set; }
        public string FlgTipoSiglaProvForfait { get; set; }
        public string RadiceSic { get; set; }
        public string SuffissoSic { get; set; }
        public DateTime? DtElaborazioneAnia { get; set; }
        public int? PrgMovimentoAnia { get; set; }
        public string FlgTipoCaricamento { get; set; }
        public int? IdSospesoCard { get; set; }
        public string CodIstatComune { get; set; }
        public string FlgScoreAia { get; set; }
    }
}
