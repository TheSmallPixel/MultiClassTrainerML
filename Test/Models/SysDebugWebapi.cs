using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysDebugWebapi
    {
        public decimal IdSysDebugWebapi { get; set; }
        public string IpChiamante { get; set; }
        public string Token { get; set; }
        public string NomeServizio { get; set; }
        public string Esito { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? TimeExeSs { get; set; }
        public int? TimeExeMs { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public string Exception { get; set; }
        public int IdUtente { get; set; }
    }
}
