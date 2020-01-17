using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysDipendenzeProcessi
    {
        public decimal IdDipendenzaProcesso { get; set; }
        public decimal IdProcesso { get; set; }
        public decimal IdProcessoPadre { get; set; }
        public decimal Ordine { get; set; }

        public virtual SysProcessi IdProcessoNavigation { get; set; }
        public virtual SysProcessi IdProcessoPadreNavigation { get; set; }
    }
}
