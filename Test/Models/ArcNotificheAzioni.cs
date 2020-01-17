using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ArcNotificheAzioni
    {
        public decimal IdNotificaAzione { get; set; }
        public decimal IdNotifica { get; set; }
        public string Url { get; set; }
        public string FlgTipoBottone { get; set; }
        public int? KeyPolEvento { get; set; }
    }
}
