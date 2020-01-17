using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SysJobMail
    {
        public int IdJobMail { get; set; }
        public int? IdJob { get; set; }
        public string FlgInvioNotificaAvvio { get; set; }
        public string FlgInvioErrore { get; set; }
        public string FlgInvioWarning { get; set; }
        public string FlgInvioSuccesso { get; set; }
        public string FlgInvioAbortita { get; set; }
        public string Destinatario { get; set; }
    }
}
