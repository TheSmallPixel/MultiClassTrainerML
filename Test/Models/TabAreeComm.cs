﻿using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabAreeComm
    {
        public decimal KeyAreaCommerciale { get; set; }
        public decimal IdAreaCommerciale { get; set; }
        public string CodAreaCommerciale { get; set; }
        public decimal IdDipartimento { get; set; }
        public decimal IdDescrizione { get; set; }
        public decimal IdIndirizzo { get; set; }
        public decimal IdAnagrafica { get; set; }
        public string NumTelefono1 { get; set; }
        public string NumTelefono2 { get; set; }
        public string NumTelefono3 { get; set; }
        public string NumSelezioneDiretta { get; set; }
        public string NumFax { get; set; }
        public DateTime? DtCapoareaDal { get; set; }
        public DateTime DtStoEffettoLog { get; set; }
        public DateTime DtStoScadenzaLog { get; set; }
        public string DtStoEffettoFis { get; set; }
        public string DtStoScadenzaFis { get; set; }
        public decimal IdUtente { get; set; }
        public string Descrizione { get; set; }
        public DateTime? DtApertura { get; set; }
        public DateTime? DtChiusura { get; set; }
    }
}
