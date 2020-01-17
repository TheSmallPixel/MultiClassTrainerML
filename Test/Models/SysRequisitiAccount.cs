using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysRequisitiAccount
    {
        public decimal IdRequisitiaccount { get; set; }
        public decimal LunghezzaMinPwd { get; set; }
        public decimal LunghezzaMinUsername { get; set; }
        public decimal NumeroMinCarNumPwd { get; set; }
        public decimal NumeroMinCarAlfPwd { get; set; }
        public decimal NumeroMinCarSpePwd { get; set; }
        public decimal DurataGgMaxPwd { get; set; }
        public decimal DurataGgMaxPwdSens { get; set; }
        public decimal DurataGgMaxLastLogin { get; set; }
        public decimal DurataGgMaxLastLoginSens { get; set; }
        public decimal? NumeroTentativiLoginDef { get; set; }
        public decimal? NumeroMinutiScaAccErrDef { get; set; }
        public int? NumeroPwdNonRiutilizzabili { get; set; }
    }
}
