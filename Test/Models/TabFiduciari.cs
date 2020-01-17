using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabFiduciari
    {
        public TabFiduciari()
        {
            TabTipiIncaricoFiduciari = new HashSet<TabTipiIncaricoFiduciari>();
            TabZoneCoperturaPeriti = new HashSet<TabZoneCoperturaPeriti>();
        }

        public decimal IdFiduciario { get; set; }
        public string CodFiduciario { get; set; }
        public decimal? IdCompagnia { get; set; }
        public decimal? IdStudiofiduciario { get; set; }
        public decimal? IdIspettorato { get; set; }
        public DateTime DtIniRapporto { get; set; }
        public DateTime DtFinRapporto { get; set; }
        public decimal? IdCalcoloautomatico { get; set; }
        public decimal IdAnagrafica { get; set; }
        public string FlgTipoProfessione { get; set; }
        public decimal? PerSpeseRecupero { get; set; }
        public string FlgMandatoProLiqSino { get; set; }
        public string FlgFiduciarioCtpSino { get; set; }
        public string FlgAbilitaPortaleSino { get; set; }
        public string FlgProponiInvioMailSino { get; set; }
        public string IdentificativoEsterno { get; set; }
        public string FlgStudioSino { get; set; }
        public decimal? ProgFiduciario { get; set; }
        public string FlgPortaleSospesoSino { get; set; }
        public string FlgAltoValore { get; set; }
        public string FlgTipoPortalePeriti { get; set; }

        public virtual ICollection<TabTipiIncaricoFiduciari> TabTipiIncaricoFiduciari { get; set; }
        public virtual ICollection<TabZoneCoperturaPeriti> TabZoneCoperturaPeriti { get; set; }
    }
}
