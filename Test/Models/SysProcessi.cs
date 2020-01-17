using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysProcessi
    {
        public SysProcessi()
        {
            SysAbilitazioniProcessi = new HashSet<SysAbilitazioniProcessi>();
            SysDipendenzeProcessiIdProcessoNavigation = new HashSet<SysDipendenzeProcessi>();
            SysDipendenzeProcessiIdProcessoPadreNavigation = new HashSet<SysDipendenzeProcessi>();
            SysJob = new HashSet<SysJob>();
            SysParametriProcessi = new HashSet<SysParametriProcessi>();
            SysProcessiCompagnie = new HashSet<SysProcessiCompagnie>();
        }

        public decimal IdProcesso { get; set; }
        public string Codice { get; set; }
        public decimal IdDescrizione { get; set; }
        public string Modulo { get; set; }
        public string FlgTipoEsecuzione { get; set; }
        public string FlgTipoProcesso { get; set; }
        public string FlgSchedulabileManSino { get; set; }
        public string Descrizione { get; set; }

        public virtual ICollection<SysAbilitazioniProcessi> SysAbilitazioniProcessi { get; set; }
        public virtual ICollection<SysDipendenzeProcessi> SysDipendenzeProcessiIdProcessoNavigation { get; set; }
        public virtual ICollection<SysDipendenzeProcessi> SysDipendenzeProcessiIdProcessoPadreNavigation { get; set; }
        public virtual ICollection<SysJob> SysJob { get; set; }
        public virtual ICollection<SysParametriProcessi> SysParametriProcessi { get; set; }
        public virtual ICollection<SysProcessiCompagnie> SysProcessiCompagnie { get; set; }
    }
}
