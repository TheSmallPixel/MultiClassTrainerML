using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TabCampiAnagrafica
    {
        public decimal IdCampoAnagrafica { get; set; }
        public string NomeCampoAnagrafica { get; set; }
        public decimal? IdDescrizione { get; set; }
        public string ClasseAppartenenza { get; set; }
        public string NomeCampoControllo { get; set; }
        public string FlgTabellaSino { get; set; }
        public string FlgGestibileUtenteSino { get; set; }
        public string Descrizione { get; set; }
    }
}
