﻿using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AniaSiviRichieste
    {
        public int IdRichiestaSivi { get; set; }
        public int? IdRichiestaIbd { get; set; }
        public DateTime DtRiferimentoRichiesta { get; set; }
        public string FlgEsitoElaborazione { get; set; }
        public string FlgTipoVeicolo { get; set; }
        public string FlgTipoTargaAlternativo { get; set; }
        public string IdentVeicoloAlternativo { get; set; }
        public DateTime? DtEmissione { get; set; }
        public DateTime? DtImmatricolazione { get; set; }
        public DateTime? SysDtElaborazione { get; set; }
        public string FlgTipoImmatricolazione { get; set; }
        public string FlgCodiceCausaleEmissione { get; set; }
        public string FlgTipoVeicoloMctc { get; set; }
        public string CodiceImologazione { get; set; }
        public string CodProvinciaEmissione { get; set; }
        public string CodProvinciaResidenza { get; set; }
        public string CodNazionalitaCostruttore { get; set; }
        public string FlgCategoriaUso { get; set; }
        public string FlgCodiceCarrozzeria { get; set; }
        public decimal? Cilindrata { get; set; }
        public int? CavalliFiscali { get; set; }
        public int? PotenzaMassima { get; set; }
        public int? Cilindri { get; set; }
        public int? Marce { get; set; }
        public int? Assi { get; set; }
        public int? GiriMotore { get; set; }
        public int? VelocitaMassima { get; set; }
        public string FlgTipoAlimentazione { get; set; }
        public int? Lunghezza { get; set; }
        public int? Larghezza { get; set; }
        public int? PesoVeicolo { get; set; }
        public int? PesoRimorchiabile { get; set; }
        public int? PesoSuRalla { get; set; }
        public int? NumeroPostiTotali { get; set; }
        public int? Tara { get; set; }
        public string CodIstatProvinciaResidenza { get; set; }
        public string CodIstatComuneResidenza { get; set; }
        public string NomeComuneResidenza { get; set; }
        public string CodiceFiscaleIntestatario { get; set; }
        public string ClasseInquinamento { get; set; }
        public string FlgProvenienzaVeicolo { get; set; }
        public string TargaPrecedente { get; set; }
        public string NomeCostruttore { get; set; }
        public string MarcaModello { get; set; }
        public string DenominazioneCommerciale { get; set; }
        public DateTime? DataAggOmologazione { get; set; }
        public string ModelloMotore { get; set; }
        public int? NumeroTempi { get; set; }
        public string TipoPotenzaMassima { get; set; }
        public int? NumeroPostiAnteriori { get; set; }
        public int? PostiASedere { get; set; }
        public int? PostiInPiedi { get; set; }
        public int? PostiDiServizio { get; set; }
        public string TipoCambio { get; set; }
        public string RapportoTrasmissione { get; set; }
        public string Servosterzo { get; set; }
        public string Pneumatici { get; set; }
        public string TipoFrenoServizio { get; set; }
        public string ApprovazioneFrenoServizio { get; set; }
        public string TipoFrenoSoccorso { get; set; }
        public string NumeroDecibel { get; set; }
        public int? GiriNumeroDecibel { get; set; }
        public string ApprovazioneSilenziatore { get; set; }
        public int? PesoPotComplessiva { get; set; }
        public int? PesoPotRimorchiabile { get; set; }
        public int? PesoPotenzialeMassima { get; set; }
        public int? RallaDa { get; set; }
        public int? RallaA { get; set; }
        public string RigheDescrittive { get; set; }
        public int? Portata { get; set; }
        public int? PortataUtile { get; set; }
        public int? PortataPot { get; set; }
        public int? LimiteNumeroRichiami { get; set; }
        public string LimiteAnnoRichiamo { get; set; }
        public string Valore { get; set; }
        public string IndEmissioniAzoto { get; set; }
        public string IndEmissioniCarbonio { get; set; }
        public DateTime? DataOmologazione { get; set; }
        public string TipoValidita { get; set; }
        public string Idfuoristrada { get; set; }
        public string ModOmologazione { get; set; }
        public string EmissioniBiossidoAzoto { get; set; }
        public string TipoAbs { get; set; }
        public string CaratteristicheBase { get; set; }
        public string LimitatoreVelocita { get; set; }
        public int? EmissioniCo2 { get; set; }
        public string TipoModello { get; set; }
        public string VarianteModello { get; set; }
        public string VersioneModello { get; set; }
        public int? AnnoImmatricolazione { get; set; }
        public DateTime? DataInizioCircolazione { get; set; }
        public string TipologiaProprietario { get; set; }
        public int? Sbalzo { get; set; }
        public string RapportoPonte { get; set; }
        public string Interasse1 { get; set; }
        public string Interasse2 { get; set; }
        public string Interasse3 { get; set; }
        public string AppGancioTraino { get; set; }
        public string StatoEsteroCorpiSpeciali { get; set; }
        public string CodiceCicCiclomotore { get; set; }
    }
}
