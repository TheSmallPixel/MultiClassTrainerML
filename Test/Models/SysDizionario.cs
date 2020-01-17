using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysDizionario
    {
        public decimal IdVocedizionario { get; set; }
        public decimal IdDescrizione { get; set; }
        public decimal IdLingua { get; set; }
        public string Descrizione { get; set; }

        public virtual SysLingue IdLinguaNavigation { get; set; }
    }
}
