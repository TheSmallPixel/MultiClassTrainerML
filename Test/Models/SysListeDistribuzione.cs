using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysListeDistribuzione
    {
        public SysListeDistribuzione()
        {
            SysMembriListaDistribuzione = new HashSet<SysMembriListaDistribuzione>();
        }

        public decimal IdListaDistribuzione { get; set; }
        public decimal IdUtenteProprietario { get; set; }
        public decimal IdDescrizione { get; set; }
        public string Note { get; set; }
        public string FlgPubblicaSino { get; set; }
        public decimal IdCompagnia { get; set; }
        public string Descrizione { get; set; }

        public virtual ICollection<SysMembriListaDistribuzione> SysMembriListaDistribuzione { get; set; }
    }
}
