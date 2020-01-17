using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SinRecuperoCfConducenti
    {
        public int IdRecuperoCf { get; set; }
        public int IdVeicolo { get; set; }
        public DateTime? DtInvioRichiesta { get; set; }
        public DateTime? DtRicezione { get; set; }
        public string FlgStatoRecuperoCf { get; set; }
    }
}
