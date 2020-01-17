using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class P3CodiciProd
    {
        public int IdCodiceProduzione { get; set; }
        public string CodProduzione { get; set; }
        public int IdP3DatiGenerali { get; set; }
        public int IdTipoCodProd { get; set; }
        public DateTime DtDal { get; set; }
        public DateTime DtAl { get; set; }
        public int? IdCausale { get; set; }

        public virtual TabCausaliRete IdCausaleNavigation { get; set; }
    }
}
